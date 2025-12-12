using System;
using System.Timers;

namespace MetalizationSystem.Devices
{
    public class DoubleActingCylinder
    {
        #region 私有字段
        // 输出点地址
        private int _outputPointA; // 输出点A地址
        private int _outputPointB; // 输出点B地址
        
        // 传感器地址
        private int _extendSensorAddress; // 伸到位传感器地址
        private int _retractSensorAddress; // 缩到位传感器地址
        
        // 传感器稳定时间（毫秒）
        private int _extendSensorStableTime; // 伸到位传感器稳定时间
        private int _retractSensorStableTime; // 缩到位传感器稳定时间
        
        // 传感器屏蔽标志
        private bool _extendSensorShield; // 伸到位传感器屏蔽
        private bool _retractSensorShield; // 缩到位传感器屏蔽
        
        // 延迟时间（毫秒）
        private int _extendDelayTime; // 伸到位延迟时间
        private int _retractDelayTime; // 缩到位延迟时间
        
        // 计时器
        private Timer _extendTimer; // 伸到位计时器
        private Timer _retractTimer; // 缩到位计时器
        
        // 传感器稳定计时器
        private Timer _extendSensorStableTimer; // 伸到位传感器稳定计时器
        private Timer _retractSensorStableTimer; // 缩到位传感器稳定计时器
        
        // 状态标志
        private bool _isExtendSensorStable; // 伸到位传感器是否稳定
        private bool _isRetractSensorStable; // 缩到位传感器是否稳定
        private bool _isExtendDelayReached; // 伸到位延迟是否到达
        private bool _isRetractDelayReached; // 缩到位延迟是否到达
        
        // 输出点XDo对象
        private XDo _outputA; // 输出点A
        private XDo _outputB; // 输出点B
        
        // 传感器XDi对象
        private XDi _extendSensor; // 伸到位传感器
        private XDi _retractSensor; // 缩到位传感器
        #endregion
        
        #region 公共属性
        /// <summary>
        /// 输出点A地址
        /// </summary>
        public int OutputPointA
        {
            get { return _outputPointA; }
            set { _outputPointA = value; }
        }
        
        /// <summary>
        /// 输出点B地址
        /// </summary>
        public int OutputPointB
        {
            get { return _outputPointB; }
            set { _outputPointB = value; }
        }
        
        /// <summary>
        /// 伸到位传感器地址
        /// </summary>
        public int ExtendSensorAddress
        {
            get { return _extendSensorAddress; }
            set { _extendSensorAddress = value; }
        }
        
        /// <summary>
        /// 缩到位传感器地址
        /// </summary>
        public int RetractSensorAddress
        {
            get { return _retractSensorAddress; }
            set { _retractSensorAddress = value; }
        }
        
        /// <summary>
        /// 伸到位传感器稳定时间（毫秒）
        /// </summary>
        public int ExtendSensorStableTime
        {
            get { return _extendSensorStableTime; }
            set { _extendSensorStableTime = value; }
        }
        
        /// <summary>
        /// 缩到位传感器稳定时间（毫秒）
        /// </summary>
        public int RetractSensorStableTime
        {
            get { return _retractSensorStableTime; }
            set { _retractSensorStableTime = value; }
        }
        
        /// <summary>
        /// 伸到位传感器屏蔽
        /// </summary>
        public bool ExtendSensorShield
        {
            get { return _extendSensorShield; }
            set { _extendSensorShield = value; }
        }
        
        /// <summary>
        /// 缩到位传感器屏蔽
        /// </summary>
        public bool RetractSensorShield
        {
            get { return _retractSensorShield; }
            set { _retractSensorShield = value; }
        }
        
        /// <summary>
        /// 伸到位延迟时间（毫秒）
        /// </summary>
        public int ExtendDelayTime
        {
            get { return _extendDelayTime; }
            set { _extendDelayTime = value; }
        }
        
        /// <summary>
        /// 缩到位延迟时间（毫秒）
        /// </summary>
        public int RetractDelayTime
        {
            get { return _retractDelayTime; }
            set { _retractDelayTime = value; }
        }
        
        /// <summary>
        /// 伸到位状态
        /// </summary>
        public bool IsExtended
        {
            get
            {
                if (_extendSensorShield)
                {
                    // 屏蔽传感器，仅检查延迟时间
                    return _isExtendDelayReached;
                }
                else
                {
                    // 检查传感器状态和稳定时间
                    return _outputA.Sts && !_outputB.Sts && _extendSensor.Sts && _isExtendSensorStable;
                }
            }
        }
        
        /// <summary>
        /// 缩到位状态
        /// </summary>
        public bool IsRetracted
        {
            get
            {
                if (_retractSensorShield)
                {
                    // 屏蔽传感器，仅检查延迟时间
                    return _isRetractDelayReached;
                }
                else
                {
                    // 检查传感器状态和稳定时间
                    return !_outputA.Sts && _outputB.Sts && _retractSensor.Sts && _isRetractSensorStable;
                }
            }
        }
        #endregion
        
        #region 构造函数
        /// <summary>
        /// 双作用气缸构造函数
        /// </summary>
        /// <param name="outputPointA">输出点A地址</param>
        /// <param name="outputPointB">输出点B地址</param>
        /// <param name="extendSensorAddress">伸到位传感器地址</param>
        /// <param name="retractSensorAddress">缩到位传感器地址</param>
        /// <param name="extendSensorStableTime">伸到位传感器稳定时间（毫秒）</param>
        /// <param name="retractSensorStableTime">缩到位传感器稳定时间（毫秒）</param>
        /// <param name="extendSensorShield">伸到位传感器屏蔽</param>
        /// <param name="retractSensorShield">缩到位传感器屏蔽</param>
        /// <param name="extendDelayTime">伸到位延迟时间（毫秒）</param>
        /// <param name="retractDelayTime">缩到位延迟时间（毫秒）</param>
        public DoubleActingCylinder(int outputPointA, int outputPointB, 
                                   int extendSensorAddress, int retractSensorAddress, 
                                   int extendSensorStableTime = 500, int retractSensorStableTime = 500,
                                   bool extendSensorShield = false, bool retractSensorShield = false,
                                   int extendDelayTime = 1000, int retractDelayTime = 1000)
        {
            // 初始化输出点地址
            _outputPointA = outputPointA;
            _outputPointB = outputPointB;
            
            // 初始化传感器地址
            _extendSensorAddress = extendSensorAddress;
            _retractSensorAddress = retractSensorAddress;
            
            // 初始化传感器稳定时间
            _extendSensorStableTime = extendSensorStableTime;
            _retractSensorStableTime = retractSensorStableTime;
            
            // 初始化传感器屏蔽标志
            _extendSensorShield = extendSensorShield;
            _retractSensorShield = retractSensorShield;
            
            // 初始化延迟时间
            _extendDelayTime = extendDelayTime;
            _retractDelayTime = retractDelayTime;
            
            // 初始化状态标志
            _isExtendSensorStable = false;
            _isRetractSensorStable = false;
            _isExtendDelayReached = false;
            _isRetractDelayReached = false;
            
            // 获取输出点XDo对象
            _outputA = XMachine.Instance.Card.FindDo(_outputPointA);
            _outputB = XMachine.Instance.Card.FindDo(_outputPointB);
            
            // 获取传感器XDi对象
            _extendSensor = XMachine.Instance.Card.FindDi(_extendSensorAddress);
            _retractSensor = XMachine.Instance.Card.FindDi(_retractSensorAddress);
            
            // 初始化计时器
            _extendTimer = new Timer();
            _extendTimer.Elapsed += ExtendTimer_Elapsed;
            _extendTimer.AutoReset = false;
            
            _retractTimer = new Timer();
            _retractTimer.Elapsed += RetractTimer_Elapsed;
            _retractTimer.AutoReset = false;
            
            _extendSensorStableTimer = new Timer();
            _extendSensorStableTimer.Elapsed += ExtendSensorStableTimer_Elapsed;
            _extendSensorStableTimer.AutoReset = false;
            
            _retractSensorStableTimer = new Timer();
            _retractSensorStableTimer.Elapsed += RetractSensorStableTimer_Elapsed;
            _retractSensorStableTimer.AutoReset = false;
            
            // 订阅传感器状态变化事件
            _extendSensor.StateChanged += ExtendSensor_StateChanged;
            _retractSensor.StateChanged += RetractSensor_StateChanged;
        }
        #endregion
        
        #region 公共方法
        /// <summary>
        /// 伸出指令
        /// </summary>
        public void Extend()
        {
            // 设置输出点A=1，B=0
            _outputA.SetDo(true);
            _outputB.SetDo(false);
            
            // 重置状态标志
            _isExtendSensorStable = false;
            _isRetractSensorStable = false;
            _isExtendDelayReached = false;
            _isRetractDelayReached = false;
            
            // 停止缩到位相关计时器
            _retractTimer.Stop();
            _retractSensorStableTimer.Stop();
            
            if (_extendSensorShield)
            {
                // 屏蔽传感器，启动延迟计时器
                _extendTimer.Interval = _extendDelayTime;
                _extendTimer.Start();
            }
            else
            {
                // 未屏蔽传感器，启动传感器稳定计时器
                _extendSensorStableTimer.Interval = _extendSensorStableTime;
                _extendSensorStableTimer.Start();
            }
        }
        
        /// <summary>
        /// 缩回指令
        /// </summary>
        public void Retract()
        {
            // 设置输出点A=0，B=1
            _outputA.SetDo(false);
            _outputB.SetDo(true);
            
            // 重置状态标志
            _isExtendSensorStable = false;
            _isRetractSensorStable = false;
            _isExtendDelayReached = false;
            _isRetractDelayReached = false;
            
            // 停止伸到位相关计时器
            _extendTimer.Stop();
            _extendSensorStableTimer.Stop();
            
            if (_retractSensorShield)
            {
                // 屏蔽传感器，启动延迟计时器
                _retractTimer.Interval = _retractDelayTime;
                _retractTimer.Start();
            }
            else
            {
                // 未屏蔽传感器，启动传感器稳定计时器
                _retractSensorStableTimer.Interval = _retractSensorStableTime;
                _retractSensorStableTimer.Start();
            }
        }
        
        /// <summary>
        /// 停止气缸动作
        /// </summary>
        public void Stop()
        {
            // 设置输出点A=0，B=0
            _outputA.SetDo(false);
            _outputB.SetDo(false);
            
            // 停止所有计时器
            _extendTimer.Stop();
            _retractTimer.Stop();
            _extendSensorStableTimer.Stop();
            _retractSensorStableTimer.Stop();
            
            // 重置状态标志
            _isExtendSensorStable = false;
            _isRetractSensorStable = false;
            _isExtendDelayReached = false;
            _isRetractDelayReached = false;
        }
        #endregion
        
        #region 事件处理方法
        /// <summary>
        /// 伸到位延迟计时器事件
        /// </summary>
        private void ExtendTimer_Elapsed(object sender, ElapsedEventArgs e)
        {
            _isExtendDelayReached = true;
        }
        
        /// <summary>
        /// 缩到位延迟计时器事件
        /// </summary>
        private void RetractTimer_Elapsed(object sender, ElapsedEventArgs e)
        {
            _isRetractDelayReached = true;
        }
        
        /// <summary>
        /// 伸到位传感器稳定计时器事件
        /// </summary>
        private void ExtendSensorStableTimer_Elapsed(object sender, ElapsedEventArgs e)
        {
            _isExtendSensorStable = true;
        }
        
        /// <summary>
        /// 缩到位传感器稳定计时器事件
        /// </summary>
        private void RetractSensorStableTimer_Elapsed(object sender, ElapsedEventArgs e)
        {
            _isRetractSensorStable = true;
        }
        
        /// <summary>
        /// 伸到位传感器状态变化事件
        /// </summary>
        private void ExtendSensor_StateChanged(object sender, bool newState)
        {
            if (_outputA.Sts && !_outputB.Sts && !_extendSensorShield)
            {
                if (newState)
                {
                    // 传感器为1，启动稳定计时器
                    _extendSensorStableTimer.Interval = _extendSensorStableTime;
                    _extendSensorStableTimer.Start();
                }
                else
                {
                    // 传感器为0，停止稳定计时器，重置稳定标志
                    _extendSensorStableTimer.Stop();
                    _isExtendSensorStable = false;
                }
            }
        }
        
        /// <summary>
        /// 缩到位传感器状态变化事件
        /// </summary>
        private void RetractSensor_StateChanged(object sender, bool newState)
        {
            if (!_outputA.Sts && _outputB.Sts && !_retractSensorShield)
            {
                if (newState)
                {
                    // 传感器为1，启动稳定计时器
                    _retractSensorStableTimer.Interval = _retractSensorStableTime;
                    _retractSensorStableTimer.Start();
                }
                else
                {
                    // 传感器为0，停止稳定计时器，重置稳定标志
                    _retractSensorStableTimer.Stop();
                    _isRetractSensorStable = false;
                }
            }
        }
        #endregion
    }
}
