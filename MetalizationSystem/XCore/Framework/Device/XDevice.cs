using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace XCore
{
    public sealed class XDevice : XObject
    {
        private static XDevice instance = new XDevice();
        XDevice()
        {

        }
        public static XDevice Instance
        {
            get { return instance; }
        }

        private Dictionary<int, XCard> cardMap = new Dictionary<int, XCard>();
        private Dictionary<int, XAxis> axisMap = new Dictionary<int, XAxis>();
        private Dictionary<int, XDo> doMap = new Dictionary<int, XDo>();
        private Dictionary<int, XDi> diMap = new Dictionary<int, XDi>();
        private Dictionary<int, XChannelValue> channelValueMap = new Dictionary<int, XChannelValue>();

        public void BindCard(int setCardId, int actCardId, XCommandCard commandCard, string name)
        {
            if (cardMap.ContainsKey(setCardId) == false)
            {
                XCard card = new XCard(actCardId, commandCard, name);
                cardMap.Add(setCardId, card);   
            }        
        }
        public XCard FindCardById(int setCardId)
        {
            if (cardMap.ContainsKey(setCardId) == false)
            {
                return null;
            }
            return cardMap[setCardId];
        }
        public Dictionary<int, XCard> CardMap
        {
            get { return this.cardMap; }
        }

        public void BindAxis(int setCardId, int setAxisId, int actAxisId, double lead, string name,XAxisDirection axisDirection)
        {
            if (cardMap.ContainsKey(setCardId) == true)
            {
                if (axisMap.ContainsKey(setAxisId) == false)
                {
                    XAxis axis = new XAxis(actAxisId, lead, cardMap[setCardId], name);
                    axis.CardId = setCardId;
                    axis.SetId = setAxisId;
                    axis.AxisDirection = axisDirection;
                    axisMap.Add(setAxisId, axis);
                }
            }
        }
        public XAxis FindAxisById(int setAxisId)
        {
            if (axisMap.ContainsKey(setAxisId) == false)
            {
                return null;
            }
            return axisMap[setAxisId];
        }
        public Dictionary<int, XAxis> AxisMap
        {
            get { return this.axisMap; }
        }

        public void BindDo(int setCardId, int setDoId,int channel, int actDoId, string name,string cardname)
        {
            if (cardMap.ContainsKey(setCardId) == true)
            {
                if (doMap.ContainsKey(setDoId) == false)
                {
                    XDo _do = new XDo(cardMap[setCardId], channel, actDoId, name, cardname);
                    _do.CardId = setCardId;
                    _do.SetId = setDoId;
                    doMap.Add(setDoId, _do);
                }             
            }
        }
        public XDo FindDoById(int setDoId)
        {
            if (doMap.ContainsKey(setDoId) == false)
            {
                return null;
            }
            return doMap[setDoId];
        }
        public Dictionary<int, XDo> DoMap
        {
            get { return this.doMap; }
        }


        public void BindDi(int setCardId, int setDiId, int channel, int actDiId, string name,string cardname)
        {
            if (cardMap.ContainsKey(setCardId) == true)
            {
                if (diMap.ContainsKey(setDiId) == false)
                {
                    XDi di = new XDi(cardMap[setCardId], channel, actDiId, name, cardname);
                    di.CardId = setCardId;
                    di.SetId = setDiId;
                    diMap.Add(setDiId, di);

                }
            }
        }
        public XDi FindDiById(int setDiId)
        {
            if (diMap.ContainsKey(setDiId) == false)
            {
                return null;
            }
            return diMap[setDiId];
        }
        public Dictionary<int, XDi> DiMap
        {
            get { return this.diMap; }
        }



        public void BindChannelValue(int setCardId, int setId, int channel, string name)
        {
            if (cardMap.ContainsKey(setCardId) == true)
            {
                if (channelValueMap.ContainsKey(setId) == false)
                {
                    XChannelValue channelValue = new XChannelValue(cardMap[setCardId], channel, name);
                    channelValue.CardId = setCardId;
                    channelValueMap.Add(setId, channelValue);
                }
            }
        }
        public XChannelValue FindChannelValueById(int setId)
        {
            if (channelValueMap.ContainsKey(setId) == false)
            {
                return null;
            }
            return channelValueMap[setId];
        }
        public Dictionary<int, XChannelValue> ChannelValueMap
        {
            get { return this.channelValueMap; }
        }
    }
}
