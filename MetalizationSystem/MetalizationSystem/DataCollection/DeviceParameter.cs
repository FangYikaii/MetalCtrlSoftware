using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using SqlSugar;

namespace MetalizationSystem.DataCollection
{

    [Serializable]
    public class DeviceSerialze
    {
        public string Key { get; set; }
        public string Name {  get; set; }
        public DeviceParameter DevicePar { get; set; }
    }

    [Serializable]
    public class DeviceParameter
    {

    }
    /// <summary>上料工站</summary>
    [Serializable]
    public class PalletParameter
    {
        public bool[] IsHave = new bool[61]{true, true, true, true, true, true, true, true, true, true, true,
                                            true, true, true, true, true, true, true, true, true, true,
                                            true, true, true, true, true, true, true, true, true, true,
                                            true, true, true, true, true, true, true, true, true, true,
                                            true, true, true, true, true, true, true, true, true, true,
                                            true, true, true, true, true, true, true, true, true, true};

        public int FristId
        {
            get
            {
                int id = 0;
                for (int i = 1; i < IsHave.Length; i++)
                {
                    if (IsHave[i]) { id = i; break; }
                }
                return id;
            }
        }

        public int LastId
        {
            get
            {
                int id = 0;
                for (int i = IsHave.Length -1; i > 0; i--)
                {
                    if (IsHave[i]) { id = i; break; }
                }
                return id;
            }
        }
        public int NextX
        {
            get
            {
                if (LastId > 55) return 0;
                return (LastId - 1) % 10 >= 5 ? 1 : 2;
            }
        }
        public int NextY
        {
            get
            {
                if (LastId > 55) return 0;
                return NextX == 1 ? ((LastId - 1) / 10 + 2) : ((LastId - 1) / 10 + 1);
            }
        }

        public int X { get {               
                if (FristId == 0) return 0;
                return (FristId - 1) % 10 >= 5 ? 2 : 1;
            } }
        public int Y
        {
            get
            {
                if (FristId == 0) return 0;
                return (FristId - 1) / 10 + 1;
            }
        }

        public string GetIsHave
        {
            get {
                string message = string.Empty;
                if (FristId == 0) return string.Empty;

                int id = (FristId - 1) / 5;
                for(int i = id*5+ 1; i <= id * 5+ 5; i++)
                {
                    message += (message == string.Empty ? "": "," ) + (IsHave[i] ? "1" : "0") ;
                }
                return message;               
            }
        }

        public void Clear(int index)
        {
            if (FristId == 0) return;
            int id = (FristId - 1) / 5;
            for (int i = id * 5 + 1; i <= id * 5 + 5; i++)
            {
                IsHave[i] = false;              
            }           
        }
    }
    /// <summary>配液工站</summary>
    [Serializable]
    public class LiquidDispensingParameter : DeviceParameter
    {
        [SugarColumn(IsPrimaryKey = true)]
        public string Sn {  get; set; }

        public DateTime Data {  get; set; }

        [SugarColumn(IsIgnore = true)]
        public string IP { get; set; } = "192.168.10.11";
        [SugarColumn(IsIgnore = true)]
        public short Port { get; set; } = 23;

        [SugarColumn( IsIgnore= true)]
        public RawMaterialInfo[] Solvent { get; set; } = new RawMaterialInfo[]
        {
            new RawMaterialInfo(),
            new RawMaterialInfo(),
            new RawMaterialInfo(),
            new RawMaterialInfo(),
            new RawMaterialInfo()
        };
        [SugarColumn(IsIgnore = true)]
        public RawMaterialInfo[] TransitionFluid { get; set; } = new RawMaterialInfo[]
        {
            new RawMaterialInfo(),
            new RawMaterialInfo(),
            new RawMaterialInfo(),
            new RawMaterialInfo(),
            new RawMaterialInfo(),
            new RawMaterialInfo()
        };
        public string S1_Name { get { return Solvent!=null?  Solvent[1].Name : ""; } }
        public double S1_Use { get { return Solvent != null ? Solvent[1].Use : 0; } }
        public string S2_Name { get { return Solvent != null ? Solvent[2].Name : ""; } }
        public double S2_Use { get { return Solvent != null ? Solvent[2].Use : 0; } }
        public string S3_Name { get { return Solvent != null ? Solvent[3].Name : ""; } }
        public double S3_Use { get { return Solvent != null ? Solvent[3].Use : 0; } }
        public string S4_Name { get { return Solvent != null ? Solvent[4].Name : ""; } }
        public double S4_Use { get { return Solvent != null ? Solvent[4].Use : 0; } }
        public string T1_Name { get { return TransitionFluid != null ? TransitionFluid[1].Name : ""; } }
        public double T1_Use { get { return TransitionFluid != null ? TransitionFluid[1].Use : 0; } }
        public string T2_Name { get { return TransitionFluid != null ? TransitionFluid[2].Name : ""; } }
        public double T2_Use { get { return TransitionFluid != null ? TransitionFluid[2].Use : 0; } }
        public string T3_Name { get { return TransitionFluid != null ? TransitionFluid[3].Name : ""; } }
        public double T3_Use { get { return TransitionFluid != null ? TransitionFluid[3].Use : 0; } }
        public string T4_Name { get { return TransitionFluid != null ? TransitionFluid[4].Name : ""; } }
        public double T4_Use { get { return TransitionFluid != null ? TransitionFluid[4].Use : 0; } }
        public string T5_Name { get { return TransitionFluid != null ? TransitionFluid[5].Name : ""; } }
        public double T5_Use { get { return TransitionFluid != null ? TransitionFluid[5].Use : 0; } }
        [SugarColumn(IsIgnore = true)]
        public string Json
        {
            get { 
                string message=string.Empty;
                for(int i = 1; i < Solvent.Length; i++)
                {
                    if (Solvent != null)
                    {
                        if (Solvent[i].Use > 0)
                        {
                            if (message == string.Empty) message += Solvent[i].Name + ":" + Solvent[i].Use.ToString();
                            else message += "," +  Solvent[i].Name + ":" + Solvent[i].Use.ToString();
                        }                           
                    }                  
                }
                for (int i = 1; i < TransitionFluid.Length; i++)
                {               
                    if (TransitionFluid != null)
                    {
                        if (TransitionFluid[i].Use > 0)
                        {
                            if (message == string.Empty) message += TransitionFluid[i].Name + ":" + TransitionFluid[i].Use.ToString();
                            else message += "," + TransitionFluid[i].Name + ":" + TransitionFluid[i].Use.ToString();
                        }
                    }
                }

                return message;            
            }
        }

        public LiquidDispensingParameter()
        {
         
        }
        [Serializable]
        public class RawMaterialInfo
        {
            /// <summary>名称</summary>
            public string Name { get; set; } = "";
            /// <summary>剩余量</summary>
            public double Residue { get; set; } = 100;
            /// <summary>单次使用量</summary>
            public double Use { get; set; } = 0;
            /// <summary>硬件Id</summary>
            public int ModbusId { get; set; } = 11;
            public RawMaterialInfo() { }
        }
    }
    /// <summary>镀铜烘干</summary>
    [Serializable]
    public class CopperingBakeParameter : DeviceParameter
    {
        public double Temperature { get; set; } = 70;
        public int Time { get; set; } = 5 * 60;
        public CopperingBakeParameter() { }
        public string Json
        {
            get { return JsonConvert.SerializeObject(this); }
        }
    }
    /// <summary>膜镀铜</summary>
    [Serializable]
    public class CoatingCopperingParameter : DeviceParameter
    {      
        public double Time { get; set; } = 4 * 60;
        public string Json
        {
            get { return JsonConvert.SerializeObject(this); }
        }
    }
    /// <summary>膜后浸</summary>
    [Serializable]
    public class CoatingPostImmersionParameter : DeviceParameter
    {
        public double Time { get; set; } = 4 * 60;
        public string Json
        {
            get { return JsonConvert.SerializeObject(this); }
        }
    }
    /// <summary>膜活化</summary>
    [Serializable]
    public class CoatingActivateParameter : DeviceParameter
    {
        public double Time { get; set; } = 4 * 60;
        public string Json
        {
            get { return JsonConvert.SerializeObject(this); }
        }
    }
    /// <summary>膜预浸</summary>
    [Serializable]
    public class CoatingPrepregParameter : DeviceParameter
    {
        public double Time { get; set; } = 4 * 60;
        public string Json
        {
            get { return JsonConvert.SerializeObject(this); }
        }
    }
    /// <summary>膜改性</summary>
    [Serializable]
    public class CoatingModifiedParameter : DeviceParameter
    {
        public double Time { get; set; } = 4 * 60;
        public string Json
        {
            get { return JsonConvert.SerializeObject(this); }
        }
    }
    /// <summary>玻璃超声波</summary>
    [Serializable]
    public class GlassUltrasonicCleanerParameter : DeviceParameter
    {
        public double Time { get; set; } = 2 * 60;
        public string Json
        {
            get { return JsonConvert.SerializeObject(this); }
        }
    }
    /// <summary>膜烘干</summary>
    [Serializable]
    public class CoatingBakeParameter : DeviceParameter
    {
        public double Temperature { get; set; } = 140;
        public int Time { get; set; } = 30 * 60;
        public CoatingBakeParameter() { }
        public string Json
        {
            get { return JsonConvert.SerializeObject(this); }
        }
    }

    /// <summary>玻璃除油</summary>
    [Serializable]
    public class GlassDegreasingParameter : DeviceParameter
    {
        public double Time { get; set; } = 2 * 60;
        public int WashTime { get; set; } = 5;
        public string Json
        {
            get { return JsonConvert.SerializeObject(this); }
        }
    }

    /// <summary>玻璃酸洗</summary>
    [Serializable]
    public class GlassAcidPicklingParameter : DeviceParameter
    {
        public double Time { get; set; } = 2 * 60;
        public string Json
        {
            get { return JsonConvert.SerializeObject(this); }
        }
    }
    /// <summary>玻璃烘干</summary>
    [Serializable]
    public class GlassBakeParameter : DeviceParameter
    {
        public double Temperature { get; set; } = 30;
        public double Time { get; set; } = 2 * 60;
        public string Json
        {
            get { return JsonConvert.SerializeObject(this); }
        }
    }
    /// <summary>玻璃镀膜</summary>
    [Serializable]
    public class GlassCoatingParameter : DeviceParameter
    {
        public double Time { get; set; } = 30 * 60;
        public string Json
        {
            get { return JsonConvert.SerializeObject(this); }
        }
    }
    /// <summary>乙醇清洗</summary>
    [Serializable]
    public class GlassEthanolCleaningParameter : DeviceParameter
    {
        public double Time { get; set; } = 2 * 60;
        public string Json
        {
            get { return JsonConvert.SerializeObject(this); }
        }
    }
    /// <summary>机械手</summary>
    [Serializable]
    public class RobotParmeter : DeviceParameter
    {
        public double Speed { get; set; } = 0;
        public string Json
        {
            get { return JsonConvert.SerializeObject(this); }
        }
    }
    /// <summary>直线电机</summary>
    [Serializable]
    public class LineMotorParmeter : DeviceParameter
    {
        public double Speed { get; set; } = 0;
        public string Json
        {
            get { return JsonConvert.SerializeObject(this); }
        }
    }


   
}
