using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Xugz.FIleOp
{
    public class CsvHelper
    {
        Thread _thread;
        object _obj = new object();
        ConcurrentQueue<CsvInfo> _queue = new ConcurrentQueue<CsvInfo>();
        readonly static CsvHelper instance = new CsvHelper();
        public static CsvHelper Instance { get { return instance; } }
        public CsvHelper()
        {
            _thread = new Thread(ProcessEventQueue);
            _thread.IsBackground = true;
            _thread.Start();
        }

        public void Write<T>(IEnumerable<T> records, string filePath,bool isCover = false)
        {          
            if (isCover) {
                var preamble = true;
                var sb = new StringBuilder();
                foreach (var record in records)
                {
                    var props = typeof(T).GetProperties();
                    if (preamble)
                    {
                        sb.AppendLine(string.Join(",", props.Select(p => p.Name)).Replace("{", "").Replace("}", "")); // 写入标题行
                        preamble = false;
                    }
                    sb.AppendLine(string.Join(",", props.Select(p => p.GetValue(record)?.ToString() ?? ""))); // 写入数据行
                }
                File.WriteAllText(filePath, sb.ToString());
            }
            else
            {
                foreach (var record in records)
                {
                    var props = typeof(T).GetProperties();
                    if (!File.Exists(filePath))
                    {
                        Directory.CreateDirectory(filePath);
                        Directory.Delete(filePath, true);
                        WriteLine(filePath, string.Join(",", props.Select(p => p.Name)).Replace("{", "").Replace("}", "")); // 写入标题行
                    }
                    WriteLine(filePath, string.Join(",", props.Select(p => p.GetValue(record)?.ToString() ?? ""))); // 写入数据行
                }              
            }           
        }
   
        public void WriteLine(string path, string line)
        {
            if (!File.Exists(path))
            {
                Directory.CreateDirectory (path);
                Directory.Delete(path, true);
            }
            CsvInfo csvInfo = new CsvInfo();
            csvInfo.Path = path;
            csvInfo.Line = line;
            _queue.Enqueue(csvInfo);
        }
        public string[] Read(string path)
        {
            string strline;
            List<string> array = new List<string>();
            StreamReader mysr = new StreamReader(path, Encoding.Default);
            while ((strline = mysr.ReadLine()) != null)
            {
                array.Add(strline);
            }
            return array.ToArray();
        }
        /// <summary>
        /// 程序关闭时使用
        /// </summary>
        public void Stop()
        {
            if (_thread != null) _thread.Abort();
        }
        void ProcessEventQueue()
        {
            while (true)
            {
                if (_queue.Count > 0)
                {
                    CsvInfo csvInfo;
                    _queue.TryDequeue(out csvInfo);
                    try
                    {
                        lock (_obj)
                        {
                            //Kill();
                            StreamWriter sw = File.AppendText(csvInfo.Path);
                            sw.WriteLine(csvInfo.Line);
                            sw.Dispose();
                        }
                    }
                    catch { }
                }
                Thread.Sleep(20);
            }
        }
        void Kill()
        {
            Process[] process = Process.GetProcesses();
            foreach (Process p in process)
            {
                if (p.ProcessName.ToUpper() == "ET" || p.ProcessName.ToUpper() == "EXCEL")
                {
                    p.Kill();
                    p.CloseMainWindow();
                    p.WaitForExit();
                }
            }
        }
        class CsvInfo
        {
            public string Path { get; set; }
            public string Line { get; set; }
        }
    }
}
