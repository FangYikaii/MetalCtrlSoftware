using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.Messaging.Messages;
using Xugz;

namespace MetalizationSystem.DataCollection
{
    [Serializable]
    public class OrderInfo 
    {
        public string SN { get; set; } 
        public bool IsBusy { get; set; }
        public bool IsFinish { get; set; }
        public int Id { get; set; } = 1;
        public int Count { get; set; } = 1;
        public LiquidDispensingParameter LiquidDispensing { get; set; } = new LiquidDispensingParameter();
        public ReactionTankInfo[] ReactionTanks { get; set; } = new ReactionTankInfo[17] { new ReactionTankInfo(0), new ReactionTankInfo(1), new ReactionTankInfo(2), new ReactionTankInfo(3),
                                                                    new ReactionTankInfo(4), new ReactionTankInfo(5), new ReactionTankInfo(6), new ReactionTankInfo(7),
                                                                    new ReactionTankInfo(8), new ReactionTankInfo(9), new ReactionTankInfo(10), new ReactionTankInfo(11),
                                                                    new ReactionTankInfo(12), new ReactionTankInfo(13), new ReactionTankInfo(14), new ReactionTankInfo(15),
                                                                    new ReactionTankInfo(16)};
        public DryBoxInfo DryBox { get; set; } = new DryBoxInfo();
        public ReactionTankInfo UltrasonicCleaner { get; set; } = new ReactionTankInfo(1);
        public LineMotorInfo LineMotor { get; set; } =new LineMotorInfo();
        public LineMotorInfo Robot {  get; set; } = new LineMotorInfo();



        public CoatingActivateParameter CoatingActivate { get; set; } = new CoatingActivateParameter();
        public CoatingBakeParameter CoatingBake { get; set; } = new CoatingBakeParameter();
        public CoatingCopperingParameter CoatingCoppering { get; set; } = new CoatingCopperingParameter();
        public CoatingModifiedParameter CoatingModified { get; set; } = new CoatingModifiedParameter();
        public CoatingPostImmersionParameter CoatingPostImmersion { get; set; } = new CoatingPostImmersionParameter();
        public CoatingPrepregParameter CoatingPrepreg { get; set; } = new CoatingPrepregParameter();
        public CopperingBakeParameter CopperingBake { get; set; } = new CopperingBakeParameter();
        public GlassAcidPicklingParameter GlassAcidPickling { get; set; } = new GlassAcidPicklingParameter();
        public GlassBakeParameter GlassBake { get; set; } = new GlassBakeParameter();
        public GlassCoatingParameter GlassCoating { get; set; } = new GlassCoatingParameter();
        public GlassDegreasingParameter GlassDegreasing { get; set; } = new GlassDegreasingParameter();
        public GlassEthanolCleaningParameter GlassEthanolCleaning { get; set; } = new GlassEthanolCleaningParameter();
        public GlassUltrasonicCleanerParameter GlassUltrasonicCleaner { get; set; } = new GlassUltrasonicCleanerParameter();

        public CharacterizationResult Results { get; set; } = new CharacterizationResult();
        public OrderInfo()
        {
            SN = "";
            IsBusy = false;
            IsFinish = false;    
            Count = 1;
            //Results = new CharacterizationResult();
        }
        public OrderInfo(string sn)
        {
            SN = sn;
            IsBusy = false;
            IsFinish = false;
        
            Count = 1;
            //Results = new CharacterizationResult();
        }

        public static implicit operator OrderInfo(ValueChangedMessage<OrderInfo> v)
        {
            throw new NotImplementedException();
        }
    }
}
