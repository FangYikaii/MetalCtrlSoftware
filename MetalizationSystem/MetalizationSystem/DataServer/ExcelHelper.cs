using MetalizationSystem.DataCollection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xugz;

namespace MetalizationSystem.DataServer
{
    public class ExcelHelper
    {
        XmlHelper xmlHelper = new XmlHelper();
        public static void ImportData(string filePath, string message)
        {
            string[] info = message.Split(',');
            XmlHelper.Write(filePath, info);
        }

        public static void ImportData(string sn, double[] message, string filePath, string[] header)
        {
            if (!File.Exists(filePath)) XmlHelper.Creat(filePath, header);
            string[] infos = new string[message.Length + 1];
            infos[0] = sn;
            for (int i = 0; i < message.Length; i++) infos[i + 1] = message[i].ToString();
            XmlHelper.Write(filePath, infos);
        }

        public static List<OrderInfo> Read(string filePath)
        {
            List<OrderInfo> orderInfos = new List<OrderInfo>();

            List<string[]> gets = XmlHelper.Read(filePath);

            for (int i = 1; i < gets.Count; i++)
            {
                OrderInfo orderInfo = new OrderInfo();
                string[] cells = gets[i];
                orderInfo.SN = cells[0];
                for (int su = 1; su <= 4; su++)
                {
                    orderInfo.LiquidDispensing.Solvent[su].Use = double.Parse(cells[su]);          
                }
                for (int su = 5; su <= 9; su++)
                {
                    orderInfo.LiquidDispensing.TransitionFluid[su - 4].Use = double.Parse(cells[su]);
                }
                orderInfo.Count = int.Parse(cells[10]);
                orderInfos.Add(orderInfo);
            }
            return orderInfos;
        }
    }
}
