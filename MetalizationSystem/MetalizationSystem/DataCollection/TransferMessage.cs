using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetalizationSystem.DataCollection
{
    public class TransferMessage
    {
        public static TransferMessage Instance =new TransferMessage();
        public Dictionary<int, OrderInfo> map {  get; set; }   

        public void Bind(int id,OrderInfo order)
        {
            if (!map.ContainsKey(id)) map.Add(id, order);            
            else map[id] = order;       
        }

        public OrderInfo Find(int id) {
            if (!map.ContainsKey(id)) return null;
            return map[id];
        }
        
        public void TransferOrder(int i,int j)
        {            
            //map[j] = map[i].Clone<OrderInfo>();
        }

    }
}
