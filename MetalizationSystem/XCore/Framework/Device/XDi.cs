using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace XCore
{
    public class XDi : XObject
    {
        private XCard card;
        private int channel;
        private int actDiId;
        private string name;
        private int m_STS;
        private bool m_PLS;
        private bool m_PLF;
        private int m_DiStsLast;
        private string cardname;
        public XDi(XCard card, int channel, int actDiId, string name, string cardname)
        {
            this.card = card;
            this.channel = channel;
            this.actDiId = actDiId;
            this.name = name;
            this.cardname = cardname;
           

        }
        
        public int CardId { get; set; }

        public int TaskId { get; set; }

        public int Update()
        {
            int sts = 0;
            int ret = GetDi(ref sts);
            lock (this)
            {
                if ((sts > 0) && (m_DiStsLast <= 0))
                {
                    m_PLS = true;
                    m_PLF = false;
                }
                else if ((sts <= 0) && (m_DiStsLast > 0))
                {
                    m_PLF = true;
                    m_PLS = false;
                }
                else
                {
                    m_PLS = false;
                    m_PLF = false;
                }

                m_STS = sts;
                m_DiStsLast = m_STS;
            }
            return ret;
        }

        private int GetDi(ref int sts)
        {
            return card.GetDi(channel, actDiId, ref sts);
        }

        public int ActId
        {
            get
            {
                return actDiId;
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

        public bool PLS
        {
            get
            {
                lock (this)
                {
                    return m_PLS;
                }
            }
        }

        public bool PLF
        {
            get
            {
                lock (this)
                {
                    return m_PLF;
                }
            }
        }

        
    }
}
