using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace XCore
{
    public class XChannelValue : XObject
    {
        private XCard card;
        private int channel;
        private string name;
        private double m_Value;
        public XChannelValue(XCard card, int channel, string name)
        {
            this.card = card;
            this.channel = channel;
            this.name = name;
        }

        public int CardId { get; set; }

        public int ChannelId { get; set; }

        public int Update()
        {
            return card.ReadChannel(channel, out m_Value);
        }

        public int ReadValue(out double value)
        {
            return card.ReadChannel(channel, out value);
        }

        public void SetVaule(double value)
        {
            card.WriteChannel(channel, value);
        }

        public string Name
        {
            get
            {
                return this.name;
            }
        }

        public double Value
        {
            get
            {
                lock (this)
                {
                    return this.m_Value;
                }
            }
        }

        
    }
}
