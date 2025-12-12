using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace XCore
{
    public class XDo : XObject
    {
        private XCard card;
        private int channel;
        private int actDoId;
        private string name;
        private int m_STS;
        private string cardname;

        public XDo(XCard card, int channel, int actDoId, string name,string cardname)
        {
            this.card = card;
            this.channel = channel;
            this.actDoId = actDoId;
            this.name = name;
            this.cardname = cardname;
            
        }

        public int CardId { get; set; }

        public int TaskId { get; set; }

        public int Update()
        {
            int sts = 0;
            int ret;
            lock (this)
            {
                ret = GetDo(ref sts);
                m_STS = sts;
            }
            return ret;
        }

        public int SetDo(int sts)
        {
            return card.SetDo(channel, actDoId, sts);
        }

        private int GetDo(ref int sts)
        {
            return card.GetDo(channel, actDoId, ref sts);
        }

        public bool STS
        {
            get
            {
                lock (this)
                {
                    return m_STS > 0;
                }
            }
        }

        public int ActId
        {
            get
            {
                return actDoId;
            }
        }

        public int SetId { get; set; }

        public string Name
        {
            get
            {
                return name;
            }
        }
        public string CardName
        {
            get
            {
                return cardname;
            }
        }
    }
}
