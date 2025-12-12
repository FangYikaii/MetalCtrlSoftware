using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using MetalizationSystem.DataCollection;
using MetalizationSystem.ViewModels.Node;
using static MetalizationSystem.EnumCollection.EnumInfo;

namespace MetalizationSystem
{
    public abstract class XTask
    {
        private Thread _thread;
        protected bool IsPause = false;

        public ManualResetEvent ManualResetEvent = new ManualResetEvent(false);
        public Status XStatus { get; set; } = Status.Nona;
        public int[] BackTask = new int[] { -1, -1 };
        public int[] NextTask = new int[] { -1, -1 };
        public int RunningTime { get; set; } = 0;
        public bool NeedTwoWay = false;
        public int ReadyId = -1;
        public int BackTaskId = -1;
        public bool StationLock = false;
        public enum Status
        {
            Nona,
            Ready,
            Start,
            Working,
            NeedUnload,
            UnloadFinshed
        }
        public string Key {  get; set; }
        public int TaskId { get; set; }
        public string Name { get; set; }
        public int StationID {  get; set; }
        public string SN { get; set; } = string.Empty;
        public List<ParDescribe> ProductInfo = new List<ParDescribe>();
        public DeviceParameter DevicePar { get; set; }

        /// <summary>
        /// 启动，调用Running
        /// </summary>
        public void Start(object runMode)
        {
            if (_thread != null)
            {
                _thread.Abort();
            }
            _thread = new Thread(new ParameterizedThreadStart(Running));
            _thread.IsBackground = true;
            _thread.Start(runMode);
        }
        /// <summary>
        /// 暂停、继续
        /// </summary>
        public void Pause()
        {
            IsPause = !IsPause;
        }
        /// <summary>
        /// 复位，调用Homing
        /// </summary>
        public void Reset()
        {       
            if (_thread != null)
            {
                _thread.Abort();
            }
            _thread = new Thread(new ThreadStart(Homing));
            _thread.IsBackground = true;
            _thread.Start();
        }
        /// <summary>
        /// 任务线程取消
        /// </summary>
        public void Cancel()
        {
            if (_thread != null)
            {
                _thread.Abort();
            }
        }

        /// <summary>
        /// 任务初始化
        /// </summary>
        public virtual void Initialize()
        {

        }
        /// <summary>
        /// 任务退出
        /// </summary>
        public virtual void Exit()
        {
            Cancel();
        }
        /// <summary>
        /// 任务运行，需用户重写
        /// </summary>
        protected virtual void Running(object runMode) { }
        /// <summary>
        /// 任务复位，需用户重写
        /// </summary>
        protected virtual void Homing() { }


        /// <summary>
        /// 设置单个Do状态
        /// </summary>
        /// <param name="index"></param>
        /// <param name="doStsType"></param>
        /// <returns></returns>
        protected bool SetDo(int index,bool on)
        {
            return XMachine.Instance.Card.SetDo(index, on);           
        }

        protected bool WaitDi(int index,bool on,int time) 
        {
            if (time != -1)
            {
                Stopwatch sw = new Stopwatch();
                sw.Start();
                while (XMachine.Instance.Card.GetDi(index) != on & sw.ElapsedMilliseconds < time)
                {
                    Thread.Sleep(3);
                }               
            }
            else
            {
                while (XMachine.Instance.Card.GetDi(index) != on)
                {
                    Thread.Sleep(3);
                }
            }
            if (XMachine.Instance.Card.GetDi(index) == on) return true;
            else return false;
        }
        protected void ResetSts()
        {
            NeedTwoWay = false;
            ReadyId = -1;
            BackTaskId = -1;     
        }
        protected void ClearData()
        {
            ResetSts();
            StationLock = false;
            SN = string.Empty;
            ProductInfo = new List<ParDescribe>();
        }

    }
}
