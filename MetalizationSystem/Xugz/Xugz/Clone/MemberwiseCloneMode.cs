using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xugz
{
    /// <summary>浅拷贝，创建的类继承此类</summary>   
    [Serializable]
    public class MemberwiseCloneMode :XObject
    {
        /// <summary>拷贝时调用 实例化类.Clone<类名>()</summary>
        public T Clone<T>() { return (T)this.MemberwiseClone(); }       
    }
}
