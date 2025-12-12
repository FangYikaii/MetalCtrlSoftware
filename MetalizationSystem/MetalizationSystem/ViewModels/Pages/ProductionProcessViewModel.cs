using CommunityToolkit.Mvvm.Input;
using DocumentFormat.OpenXml.Bibliography;
using DocumentFormat.OpenXml.Wordprocessing;
using DynamicData;
using MetalizationSystem.DataCollection;
using MetalizationSystem.ViewModels.Node;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using static MetalizationSystem.EnumCollection.EnumInfo;

namespace MetalizationSystem.ViewModels
{
    public partial class ProductionProcessViewModel : ObservableObject
    {
        double _scale = 1;
        bool _isMoving = false;
        bool _isAllMoving = false;
        Point _oPoint = new Point();
        Point _aPoint = new Point();
        List<TreeWorkFlow> workFlow = new List<TreeWorkFlow>();
        [ObservableProperty]
        string _processName;
        [ObservableProperty]
        string _processStationName;
        [ObservableProperty]
        bool _stationLock = false;
        [ObservableProperty]
        ObservableCollection<string> _menuItems;
        [ObservableProperty]
        double _scaleX = 1;
        [ObservableProperty]
        double _scaleY = 1;
        [ObservableProperty]
        object _pObj;

        public ObservableCollection<NodeModel> ProcessList { get; set; } = new ObservableCollection<NodeModel>();    
        public void ListViewItem_MouseDown(object sender, MouseButtonEventArgs e)
        {
            DragDrop.DoDragDrop((DependencyObject)sender,(sender as ListViewItem).Tag , DragDropEffects.Copy);
        }
        public void ItemsControl_Drop(object sender, DragEventArgs e)
        {
            string tag= e.Data.GetData(typeof(string)) as string;
            Point point = e.GetPosition((IInputElement)sender);

            Type type = Assembly.GetExecutingAssembly().GetType("MetalizationSystem.ViewModels.Node." + tag);
            NodeModel instance = (NodeModel)Activator.CreateInstance(type);
            instance.X = point.X;
            instance.Y = point.Y;
            instance.Width *= _scale; 
            instance.Height *= _scale;
            instance.Scale = _scale;
            instance.Key = DateTime.Now.ToString("yyyyMMddHHmmssfff");
            ProcessList.Add(instance);
        }

        NodeModel selectNode = null;
        public void Border_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            _isMoving = true;
            _oPoint= e.GetPosition((IInputElement)sender);
            Mouse.Capture((IInputElement)sender);
            var model = (sender as FrameworkElement).DataContext as NodeModel;
            selectNode= model;
            ProcessName = model.Name;
            ProcessStationName = model.Station;
            StationLock = model.StationLock;         
            PObj = model.DevicePar;
        }
        public void Border_MouseMove(object sender, MouseEventArgs e)
        {
            if (!_isMoving) return;
            Point nPoint = e.GetPosition((IInputElement)sender);
            var model =(sender as FrameworkElement).DataContext as NodeModel;
            model.X += nPoint.X - _oPoint.X;
            model.Y += nPoint.Y - _oPoint.Y;   
            NodePoint(ref model);
        }
        public void Border_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            _isMoving = false;
            Mouse.Capture(null);
        }
        NodeModel startNodeModel = null;
        public void Border_MouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            startNodeModel = (sender as FrameworkElement).DataContext as NodeModel;
        }
        public void Border_MouseRightButtonUp(object sender, MouseButtonEventArgs e)
        {
            if (startNodeModel == null) return;           
            var model =( sender as FrameworkElement).DataContext as NodeModel;
            if (startNodeModel == model) return;

            if ((startNodeModel.OutputLine[0] == null | startNodeModel.OutputLine[1] == null)
                & (model.InputLine[0] ==null | model.InputLine[1] == null))
            {

                LineModel lm = new LineModel();

                lm = AddLine(startNodeModel, model);
                ProcessList.Add(lm);

                if (startNodeModel.OutputLine[0] == null) startNodeModel.OutputLine[0] = lm;
                else if (startNodeModel.OutputLine[1] == null) startNodeModel.OutputLine[1] = lm;
                else return;

                if (model.InputLine[0] == null) model.InputLine[0] = lm;
                else if (model.InputLine[1] == null) model.InputLine[1] = lm;
                else return;
                startNodeModel = null;
            }


        }
        public void ItemsControl_MouseWheel(object sender, MouseWheelEventArgs e)
        {
            
            double curscale = ScaleX;
            int delta = e.Delta;
            Point point = e.GetPosition((IInputElement)sender);
            if (delta > 0) {
                if (ScaleX * _scale > 2) return;
                ScaleX += 0.1;
                ScaleY += 0.1;
            }
            else
            {
                if (ScaleX *_scale < 0.3) return ;
                ScaleX -= 0.1;
                ScaleY -= 0.1;
            }

            foreach (var v in ProcessList) {
                v.Scale = ScaleX *_scale;
                if (v.NodeType == 0)
                {            
                    v.Width /= curscale;
                    v.Height /= curscale;
                    v.X = point.X - (point.X - v.X) * ScaleX / curscale;
                    v.Y = point.Y - (point.Y - v.Y) * ScaleY/ curscale;          
                    v.Width *= ScaleX;
                    v.Height *= ScaleY;
                }         
            }
            foreach (var v in ProcessList)
            {
                if (v.NodeType == 1)
                {
                    NodeModel startNode = null, endNode = null;
                    LineModel olm = null;
                    foreach (var p in ProcessList)
                    {
                        if (p.Key == (v as LineModel).Input) endNode = p;
                        if (p.Key == (v as LineModel).Output) startNode = p;
                        if (p.Key == v.Key) olm = p as LineModel;
                    }                  
                    LineModel lm = AddLine(startNode, endNode);                  
                    (v as LineModel).Sx = lm.Sx;
                    (v as LineModel).Sy = lm.Sy;
                    (v as LineModel).Ex = lm.Ex;
                    (v as LineModel).Ey = lm.Ey;
                    (v as LineModel).X1 = lm.X1;
                    (v as LineModel).Y1 = lm.Y1;
                    (v as LineModel).X1 = lm.X1;
                    (v as LineModel).Y1 = lm.Y1;
                    (v as LineModel).X2 = lm.X2;
                    (v as LineModel).Y2 = lm.Y2;
                    (v as LineModel).X3 = lm.X3;
                    (v as LineModel).Y3 = lm.Y3;
                    (v as LineModel).X4 = lm.X4;
                    (v as LineModel).Y4 = lm.Y4;
                }
            }
        }

        public void ItemsControl_MouseDown(object sender, MouseButtonEventArgs e)
        {
            _isAllMoving = true;
            _aPoint = e.GetPosition((IInputElement)sender);        
        }

        public void ItemsControl_MouseUp(object sender, MouseButtonEventArgs e)
        {
            _isAllMoving = false;
        }

        public void ItemsControl_MouseMove(object sender, MouseEventArgs e)
        {
            if (!_isAllMoving | _isMoving) { _isAllMoving = false; return; }     
            Point point = e.GetPosition((IInputElement)sender);   
            foreach (var v in ProcessList)
            {
                if (v.NodeType == 0)
                {               
                    v.X += point.X - _aPoint.X;
                    v.Y += point.Y - _aPoint.Y;
                   
                }
            }
            _aPoint = point;
            foreach (var v in ProcessList)
            {
                if (v.NodeType == 1)
                {
                    NodeModel startNode = null, endNode = null;
                    LineModel olm = null;
                    foreach (var p in ProcessList)
                    {
                        if (p.Key == (v as LineModel).Input) endNode = p;
                        if (p.Key == (v as LineModel).Output) startNode = p;
                        if (p.Key == v.Key) olm = p as LineModel;
                    }
                    LineModel lm = AddLine(startNode, endNode);
                    (v as LineModel).Sx = lm.Sx;
                    (v as LineModel).Sy = lm.Sy;
                    (v as LineModel).Ex = lm.Ex;
                    (v as LineModel).Ey = lm.Ey;
                    (v as LineModel).X1 = lm.X1;
                    (v as LineModel).Y1 = lm.Y1;
                    (v as LineModel).X1 = lm.X1;
                    (v as LineModel).Y1 = lm.Y1;
                    (v as LineModel).X2 = lm.X2;
                    (v as LineModel).Y2 = lm.Y2;
                    (v as LineModel).X3 = lm.X3;
                    (v as LineModel).Y3 = lm.Y3;
                    (v as LineModel).X4 = lm.X4;
                    (v as LineModel).Y4 = lm.Y4;
                }
            }
        }

        [RelayCommand ]
        public void Delect()
        {
            if (selectNode == null) return;
            List<NodeModel> nodeModels = new List<NodeModel>();
            foreach (var v in ProcessList) {

                if (v.Key == selectNode.Key) continue;
                for(int i = 0; i <= 1; i++)
                {
                    if (v.InputLine[i] !=null)
                    {
                        if ((v.InputLine[i] as LineModel).Output == selectNode.Key) v.InputLine[i] = null;
                    }
                    if (v.OutputLine[i] != null)
                    {
                        if ((v.OutputLine[i] as LineModel).Input == selectNode.Key) v.OutputLine[i] = null;
                    }
                 
                  
                }
                if (v.NodeType == 1)
                {
                    LineModel lm = (LineModel)v;
                    if (lm.Input== selectNode.Key | lm.Output == selectNode.Key)
                    {
                        nodeModels.Add(lm);
                    }
                }
            }

       
            ProcessList.Remove(selectNode);
            for (int i = 0; i < nodeModels.Count; i++)
            {
                ProcessList.Remove(nodeModels[i]);
            }

        }

        public void ItemsControl_KeyDown(object sender, KeyEventArgs e)
        {            
            var key = e.Key;
        }
        public void ItemsControl_MouseRightButtonUp(object sender, MouseButtonEventArgs e)
        {
           startNodeModel = null;
        }

        partial void OnProcessNameChanged(string value)
        {
            if (selectNode.Name == value) return;
            foreach (var item in ProcessList)
            {
                if (item.Key == selectNode.Key)
                {
                    item.Name = value;
                }
            }
            Save();    
            ProcessList.Clear();
            LoadJson();
        }
        partial void OnStationLockChanged(bool value)
        {
            if (selectNode.StationLock == value) return;
            foreach (var item in ProcessList) {

                if (item.Key == selectNode.Key)
                {
                    item.StationLock = value;
                }
            }
        }    
        [RelayCommand]
        public void Save()
        {
            List<NodeSerialze> nodeSerialzes = new List<NodeSerialze>(); 
            foreach(var item in ProcessList)
            {
                NodeSerialze nodeSerialze = new NodeSerialze();

                nodeSerialze.Key = item.Key;
                nodeSerialze.TaskId= item.TaskId;
                nodeSerialze.Name = item.Name;
                nodeSerialze.Station= item.Station;
                nodeSerialze.StationLock = item.StationLock;
                nodeSerialze.Tag = item.Tag;
                nodeSerialze.Width = item.Width;
                nodeSerialze.Height = item.Height;
       
                nodeSerialze.DevicePar= item.DevicePar;
                nodeSerialze.X = item.X;
                nodeSerialze.Y = item.Y;
                nodeSerialze.Scale = item.Scale;
                nodeSerialze.NodeType= item.NodeType;
                nodeSerialze.NeedRobot = item.NeedRobot;
                if (nodeSerialze.NodeType == 1)
                {
                    nodeSerialze.Sx = (item as LineModel).Sx;
                    nodeSerialze.Sy = (item as LineModel).Sy;
                    nodeSerialze.Ex = (item as LineModel).Ex;
                    nodeSerialze.Ey = (item as LineModel).Ey;
                    nodeSerialze.X1 = (item as LineModel).X1;
                    nodeSerialze.Y1 = (item as LineModel).Y1;
                    nodeSerialze.X2 = (item as LineModel).X2;
                    nodeSerialze.Y2 = (item as LineModel).Y2;
                    nodeSerialze.X3 = (item as LineModel).X3;
                    nodeSerialze.Y3 = (item as LineModel).Y3;
                    nodeSerialze.X4 = (item as LineModel).X4;
                    nodeSerialze.Y4 = (item as LineModel).Y4;
                    nodeSerialze.Input = (item as LineModel).Input;
                    nodeSerialze.Output = (item as LineModel).Output;
                }
                nodeSerialzes.Add(nodeSerialze);
            }
            Globa.DataManager.ProcessList = nodeSerialzes;
            foreach (var v in ProcessList)
            {
                if (v.Station == "Start")
                {
                    string nextNodeKey = "";
                    if (v.OutputLine[0] != null) { nextNodeKey = (v.OutputLine[0] as LineModel).Input; }
                    else if (v.OutputLine[1] != null) { nextNodeKey = (v.OutputLine[1] as LineModel).Input; }
                    else return;
                    workFlow = GetTreeNode(nextNodeKey);
                }
            }
            Globa.DataManager.WorkFlows = workFlow;            
        }
        public ObservableCollection<string> SourceStationCategories { get; }
        public ObservableCollection<string> DirStationCategories { get; }        
        public ProductionProcessViewModel() {    
            LoadJson();
            PObj = this;
        }
        void NodePoint(ref NodeModel model)
        {        
            for(int i = 0; i < model.InputLine.Length; i++)
            {
                if (model.InputLine[i] != null)
                {
                    string output = (model.InputLine[i] as LineModel).Output;
                    NodeModel outputNodeModel = null;
                    foreach (var v in ProcessList)
                    {
                        if (v.Key == output) outputNodeModel = v;
                    }
                    LineModel lm = AddLine(outputNodeModel, model);
                    LineModel inputLine = model.InputLine[i] as LineModel;
                    inputLine.Sx = lm.Sx;
                    inputLine.Sy = lm.Sy;
                    inputLine.Ex = lm.Ex;
                    inputLine.Ey = lm.Ey;
                    inputLine.X1 = lm.X1;
                    inputLine.Y1 = lm.Y1;
                    inputLine.X2 = lm.X2;
                    inputLine.Y2 = lm.Y2;
                    inputLine.X3 = lm.X3;
                    inputLine.Y3 = lm.Y3;
                    inputLine.X4 = lm.X4;
                    inputLine.Y4 = lm.Y4;
                }
            }
            for(int i = 0; i < model.OutputLine.Length; i++)
            {
                if (model.OutputLine[i] != null)
                {
                    string input = (model.OutputLine[i] as LineModel).Input;
                    NodeModel inputNodeModel = null;
                    foreach(var v in ProcessList)
                    {
                        if (v.Key == input) inputNodeModel= v;
                    }
                    LineModel lm = AddLine(model, inputNodeModel);
                    LineModel inputLine = model.OutputLine[i] as LineModel;
                    inputLine.Sx = lm.Sx;
                    inputLine.Sy = lm.Sy;
                    inputLine.Ex = lm.Ex;
                    inputLine.Ey = lm.Ey;
                    inputLine.X1 = lm.X1;
                    inputLine.Y1 = lm.Y1;
                    inputLine.X2 = lm.X2;
                    inputLine.Y2 = lm.Y2;
                    inputLine.X3 = lm.X3;
                    inputLine.Y3 = lm.Y3;
                    inputLine.X4 = lm.X4;
                    inputLine.Y4 = lm.Y4;
                }
            }            
        }

        LineModel AddLine(NodeModel startNode, NodeModel endNode) {
            LineModel lm= new LineModel();
            lm.NodeType = 1;
            lm.Input = endNode.Key;
            lm.Output = startNode.Key;
            if (startNode.CenterX + startNode.Width / 2 < endNode.CenterX - endNode.Width / 2)
            {
                lm.Sx = startNode.CenterX + startNode.Width / 2;
                lm.Sy = startNode.CenterY;
                lm.Ex = endNode.CenterX - endNode.Width / 2;
                lm.Ey = endNode.CenterY;
                lm.X1 = (lm.Sx + lm.Ex) / 2;
                lm.Y1 = lm.Sy;
                lm.X2 = lm.X1;
                lm.Y2 = lm.Ey;
                lm.X3 = lm.Ex - 5;
                lm.Y3 = lm.Ey + 5;
                lm.X4 = lm.Ex - 5;
                lm.Y4 = lm.Ey - 5;
            }
            else
            {
                if (startNode.CenterY + startNode.Height / 2 < endNode.CenterY - endNode.Height / 2)
                {
                    lm.Sx = startNode.CenterX;
                    lm.Sy = startNode.CenterY + startNode.Height / 2;
                    lm.Ex = endNode.CenterX;
                    lm.Ey = endNode.CenterY - endNode.Height / 2;
                    lm.X1 = lm.Sx;
                    lm.Y1 = (lm.Sy + lm.Ey) / 2;
                    lm.X2 = lm.Ex;
                    lm.Y2 = lm.Y1;
                    lm.X3 = lm.Ex + 5;
                    lm.Y3 = lm.Ey - 5;
                    lm.X4 = lm.Ex - 5;
                    lm.Y4 = lm.Ey - 5;
                }
                else if (startNode.CenterY - startNode.Height / 2 > endNode.CenterY + endNode.Height / 2)
                {
                    lm.Sx = startNode.CenterX;
                    lm.Sy = startNode.CenterY - startNode.Height / 2;
                    lm.Ex = endNode.CenterX;
                    lm.Ey = endNode.CenterY + endNode.Height / 2;
                    lm.X1 = lm.Sx;
                    lm.Y1 = (lm.Sy + lm.Ey) / 2;
                    lm.X2 = lm.Ex;
                    lm.Y2 = lm.Y1;
                    lm.X3 = lm.Ex + 5;
                    lm.Y3 = lm.Ey + 5;
                    lm.X4 = lm.Ex - 5;
                    lm.Y4 = lm.Ey + 5;
                }
                else
                {
                    lm.Sx = startNode.CenterX;
                    lm.Sy = startNode.CenterY - startNode.Height / 2;
                    lm.Ex = endNode.CenterX;
                    lm.Ey = endNode.CenterY - endNode.Height / 2;
                    lm.X1 = lm.Sx;
                    lm.Y1 = (lm.Sy < lm.Ey ? lm.Sy : lm.Ey) - endNode.Height / 2;
                    lm.X2 = lm.Ex;
                    lm.Y2 = lm.Y1;
                    lm.X3 = lm.Ex + 5;
                    lm.Y3 = lm.Ey - 5;
                    lm.X4 = lm.Ex - 5;
                    lm.Y4 = lm.Ey - 5;
                }


            }
            lm.Sx /= ScaleX;
            lm.Sy /= ScaleX;
            lm.Ex /= ScaleX;
            lm.Ey /= ScaleX;
            lm.X1 /= ScaleX;
            lm.Y1 /= ScaleX; ;
            lm.X2 /= ScaleX;
            lm.Y2 /= ScaleX;
            lm.X3 /= ScaleX;
            lm.Y3 /= ScaleX;
            lm.X4 /= ScaleX;
            lm.Y4 /= ScaleX;

            return lm;     
        }
        void LoadJson()
        {    
            if (Globa.DataManager.ProcessList == null) return;
            List< NodeSerialze> nodeModels = Globa.DataManager.ProcessList;
            for (int i = 0; i < nodeModels.Count; i++)
            {
               
                if (nodeModels[i].NodeType == 0)
                {
                   
                    Type type = Assembly.GetExecutingAssembly().GetType("MetalizationSystem.ViewModels.Node." + nodeModels[i].Tag);
                    NodeModel instance = (NodeModel)Activator.CreateInstance(type);                   
                    instance.Key= nodeModels[i].Key;
                    instance.X = nodeModels[i].X;
                    instance.Y = nodeModels[i].Y;
                    instance.Name = nodeModels[i].Name;
                    instance.TaskId = nodeModels[i].TaskId;
                    instance.Tag = nodeModels[i].Tag;
                    instance.Width = nodeModels[i].Width;
                    instance.Height = nodeModels[i].Height;
        
                    instance.NodeType = nodeModels[i].NodeType;
                    instance.Scale = nodeModels[i].Scale;
                    instance.StationLock = nodeModels[i].StationLock;
                    instance.DevicePar = nodeModels[i].DevicePar;
                    instance.NeedRobot = nodeModels[i].NeedRobot;
                    _scale = instance.Scale;
                    ProcessList.Add(instance);
                }
            }
            for (int i = 0; i < nodeModels.Count; i++)
            {
                if (nodeModels[i].NodeType == 1)
                {
                    Type type = Assembly.GetExecutingAssembly().GetType("MetalizationSystem.ViewModels.Node." + nodeModels[i].Tag);
                    LineModel instance = (LineModel)Activator.CreateInstance(type);

                    NodeModel startNode = null, endNode = null;
                    foreach (var v in ProcessList)
                    {
                        if (v.Key == nodeModels[i].Output) startNode = v;
                        if (v.Key == nodeModels[i].Input) endNode = v;
                        if (startNode != null & endNode != null) break;
                    }
                    LineModel lm = new LineModel();
                    lm = AddLine(startNode, endNode);
                    ProcessList.Add(lm);
                    if (startNode.OutputLine[0] == null) startNode.OutputLine[0] = lm;
                    else if (startNode.OutputLine[1] == null) startNode.OutputLine[1] = lm;
                    if (endNode.InputLine[0] == null) endNode.InputLine[0] = lm;
                    else if (endNode.InputLine[1] == null) endNode.InputLine[1] = lm;
                }
            }

                    
        }

        List<TreeWorkFlow> GetTreeNode(string key, bool end = false)
        {
            List<TreeWorkFlow> workFlows = new List <TreeWorkFlow >();
            NodeModel nextNode = null;
            bool finish = false;
            string nextKey = "";
            foreach (var v in ProcessList)
            {
                if (v.Key == key)
                {
                    TreeWorkFlow workFlow = new TreeWorkFlow();
                   
                    workFlow.Node = new TreeNode() { TaskId =v.TaskId, Station = v.Station, Key = v.Key, StationLock = v.StationLock,NeedRobot = v.NeedRobot,Name= v.Name};
                    workFlow.Node.NeedTwoWay = v.InputLine[0] != null & v.InputLine[1] != null;
                    if (end)
                    {
                        workFlow.Node.NeedRun = false;
                        workFlows.Insert(0, workFlow);
                        return workFlows;
                    }
                    if (v.OutputLine[0] != null & v.OutputLine[1] != null)
                    {
                        workFlows = GetTreeNode((v.OutputLine[0] as LineModel).Input);
                        workFlow.WorkFlows = GetTreeNode((v.OutputLine[1] as LineModel).Input);
                    }
                    else if (v.OutputLine[0] != null)
                    {
                        bool ed = false;
                        nextKey = (v.OutputLine[0] as LineModel).Input;
                        nextNode = GetNodeModel(nextKey);
                        if (nextNode.InputLine[0] != null & nextNode.InputLine[1] != null)
                        {
                            if ((nextNode.InputLine[1] as LineModel).Output == v.Key)
                            {
                                ed = true;
                            }
                        }                  
                         workFlows = GetTreeNode(nextKey, ed);                   

                    }
                    else if (v.OutputLine[1] != null) {
                        bool ed = false;
                        nextKey = (v.OutputLine[1] as LineModel).Input;
                        nextNode = GetNodeModel(nextKey);
                        if (nextNode.InputLine[0] != null & nextNode.InputLine[1] != null)
                        {
                            if ((nextNode.InputLine[1] as LineModel).Output == v.Key)
                            {
                                ed = true;
                            }
                        }
                        workFlows = GetTreeNode(nextKey, ed);
                    }
                    workFlows.Insert(0, workFlow);
                }              
            }

            return workFlows;
        }

        NodeModel GetNodeModel(string key)
        {
            NodeModel nodeModel = null;
            foreach (var v in ProcessList)
            {
                if (v.Key == key)
                {
                    nodeModel = v; break;
                }
            }
            return nodeModel;
        }
    }

}
