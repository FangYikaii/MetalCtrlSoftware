using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using MetalizationSystem.Devices;
using MetalizationSystem.ViewModels.Node;
using Newtonsoft.Json;
using Xugz;

namespace MetalizationSystem.DataCollection
{
    public class DataManage
    {
        StreamOP.FileBaseFactory bf = new StreamOP.FileBaseFactory(StreamOP.FileBaseFactory.FileType.Binary);

        public class Info
        {
            public string Path;
            public object Obj;
            public Info(object obj, string path)
            {
                Path = path;
                Obj = obj;
            }
        }

        public List<OrderInfo> CurOrderList
        {
            get { return (List<OrderInfo>)curOrderInfo.Obj; }
            set 
            {
                curOrderInfo.Obj = value;
                Write(curOrderInfo);
            }
        }
        public OrderInfo ParameterList
        {
            get { return (OrderInfo)parameterList.Obj; }
            set
            {
                parameterList.Obj = value;
                Write(parameterList);
            }
        }

        public List<PositionInfo> Axis7
        {
            get { return (List<PositionInfo>)axis7Info.Obj; }
            set
            {
                axis7Info.Obj = value;
                Write(axis7Info);
            }
        }

        public List<RobotPositionInfo> RobotPos
        {
            get { return (List<RobotPositionInfo>)robotPosInfo.Obj; }
            set
            {
                robotPosInfo.Obj = value;
                Write(robotPosInfo);
            }
        }

        public List<NodeSerialze> ProcessList
        {
            get { return (List<NodeSerialze>)processInfo.Obj; }
            set
            {
                processInfo.Obj = value;
                Write(processInfo);
            }
        }
        public List<TreeWorkFlow> WorkFlows
        {
            get { return (List<TreeWorkFlow>)workFlowInfo.Obj; }
            set
            {
                workFlowInfo.Obj = value;
                Write(workFlowInfo);
            }
        }

        public PalletParameter LoadPallet
        {
            get { return (PalletParameter)loadInfo.Obj; }
            set
            {
                loadInfo.Obj = value;
                Write(loadInfo);
            }
        }
        public PalletParameter UnLoadPallet
        {
            get { return (PalletParameter)unLoadInfo.Obj; }
            set
            {
                unLoadInfo.Obj = value;
                Write(unLoadInfo);
            }
        }
        public 

   

        Info parameterList = new Info(new OrderInfo(), AppDomain.CurrentDomain.BaseDirectory + @"Par\ParameterList.dat");
        Info curOrderInfo = new Info(new List<OrderInfo>(), AppDomain.CurrentDomain.BaseDirectory + @"Par\CurOderList.dat");
    
        Info axis7Info = new Info(new List<PositionInfo>(), AppDomain.CurrentDomain.BaseDirectory + @"Par\Axis7Info.dat");
        Info robotPosInfo = new Info(new List<RobotPositionInfo>(), AppDomain.CurrentDomain.BaseDirectory + @"Par\RobotPosInfo.dat");
        Info processInfo = new Info(new List<NodeSerialze>(), AppDomain.CurrentDomain.BaseDirectory + @"Par\Process.dat");
        Info workFlowInfo = new Info(new List<TreeWorkFlow>(), AppDomain.CurrentDomain.BaseDirectory + @"Par\WorkFlow.dat");
        Info loadInfo = new Info(new PalletParameter(), AppDomain.CurrentDomain.BaseDirectory + @"Par\LoadInfo.dat");
        Info unLoadInfo =new Info(new PalletParameter(), AppDomain.CurrentDomain.BaseDirectory + @"Par\UnLoadInfo.dat");


        public DataManage()
        {
            curOrderInfo.Obj = (List<OrderInfo>)Read(curOrderInfo);
            parameterList.Obj =(OrderInfo)Read(parameterList);
            axis7Info.Obj =(List<PositionInfo>)Read(axis7Info);
 
            processInfo.Obj = (List<NodeSerialze>)Read(processInfo);
            workFlowInfo.Obj = (List<TreeWorkFlow>)Read(workFlowInfo);
            loadInfo.Obj = (PalletParameter)Read(loadInfo);
            unLoadInfo.Obj = (PalletParameter)Read(unLoadInfo);
        }

        public void Write(Info info)
        {
            try
            {
                bf.Write(info.Obj, info.Path);
            }
            catch (Exception ex) { }
        }

        public void Write(object obj, string path)
        {
            try
            {
                bf.Write(obj, path);
            }
            catch (Exception ex) { }
        }
        public object Read(Info info)
        {
            try
            {
                return bf.Read(info.Path);
            }
            catch (Exception ex) { bf.Write(info.Obj, info.Path); }
            return info.Obj;
        }
        public object Read(object obj, string path)
        {
            try
            {
                return bf.Read(path);
            }
            catch (Exception ex) { bf.Write(obj, path); }
            return obj;
        }
    }
}
