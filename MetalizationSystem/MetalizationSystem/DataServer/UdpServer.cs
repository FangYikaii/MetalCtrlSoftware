using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using DbOperationLibrary;
using MetalizationSystem.DataCollection;

namespace MetalizationSystem.DataServer
{
    public class UdpServer
    {

        // 定义事件
        public event Action<string> BarcodeUpdated;

        private UdpClient udpServer;
        private int listenPort;
        private CommonDbOperation dbOperation;

        public UdpServer(int port, CommonDbOperation dbOp)
        {
            listenPort = port;
            dbOperation = dbOp;
            udpServer = new UdpClient(listenPort);
        }

        public void Start()
        {
            Task.Run(() => Listen());
        }

        private async Task Listen()
        {
            while (true)
            {
                var result = await udpServer.ReceiveAsync();
                string message = Encoding.UTF8.GetString(result.Buffer);

                // 解析消息
                if (message.StartsWith("CV_GEN|"))
                {
                    // 假设格式：CV_GEN|barcode值
                    var parts = message.Split('|');
                    if (parts.Length == 2)
                    {
                        string barcode = parts[1];
                        // 查询Samples表
                        var sample = dbOperation.GetInfo<Samples>(x => x.barCode == barcode).FirstOrDefault();
                        if (sample != null)
                        {
                            // 更新BayesExperData表
                            var bayes = dbOperation.GetInfo<BayesExperData>(x => x.Barcode == barcode).FirstOrDefault();
                            if (bayes != null)
                            {
                               
                                bayes.Uniformity = (double)Math.Round(sample.Uniformity, 2);
                                bayes.Coverage = (double)Math.Round(sample.Coverage, 2);
                                dbOperation.UpdateInfo(bayes, x => new { x.Uniformity, x.Coverage });
                            }
                        }
                        // 回复客户端
                        string reply = $"CV_REC|{barcode}";
                        byte[] replyBytes = Encoding.UTF8.GetBytes(reply);
                        await udpServer.SendAsync(replyBytes, replyBytes.Length, result.RemoteEndPoint);

                        // 触发事件，通知ViewModel刷新
                        BarcodeUpdated?.Invoke(barcode);
                    }
                }
            }
        }
    }
}
