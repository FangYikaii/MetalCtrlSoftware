using DocumentFormat.OpenXml.Drawing.Charts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace MetalizationSystem.WorkFlows.Recipe
{
    /// <summary>
    /// 外部配方类：包含10组参数
    /// </summary>
    [Serializable]
    public class Recipe
    {
        private ParameterSet[] _parameterSets;
        private int _number;
        private int _index;
        public ParameterSet[] ParameterSets 
        { 
            get
            { return _parameterSets; }
            set
            {
                _number = value.Length;
                for (int i = 0; i < _number; i++)
                {
                    _parameterSets[i] = value[i];
                }
            }
        }

        public int Number 
        { 
            get { return _number; }
        }

        public int Index 
        {
            get{ return _index;} 
            set{ _index = value; }
        }

        public ParameterSet CurrentParameterSet
        {
            get 
            {
                if (_index < 0 || _index >= _number) throw new IndexOutOfRangeException("Index value exceeds the range");
                
                // 获取当前参数集
                ParameterSet currentSet = ParameterSets[_index];
                
                // 检查时间是否为0，如果是则修改为1秒
                if (currentSet.Time.TotalSeconds <= 0)
                {
                    currentSet.Time = new TimeSpan(0, 0, 1); // 设置为1秒
                }
                
                return currentSet;
            }
        }

        public Recipe()
        {
            _number = 6;
            _index = 0;
            _parameterSets = new ParameterSet[_number];
            for (int i = 0; i < _number; i++)
            {
                _parameterSets[i] = new ParameterSet();
            }
        }

        public void Initial()
        {
            _index = 0;
        }
    }
}
