using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetalizationSystem
{
    public class XControl
    {
        static XControl instance = new XControl();
        public static XControl Instance {  get { return instance; } }
        public void Start(RunModel runModel)
        {
            foreach (XTask task in XTaskManager.Instance.Tasks.Values)
            {
                task.Start(runModel);
            }
        }

        public void Stop() {

            foreach (XTask task in XTaskManager.Instance.Tasks.Values)
            {
                task.Cancel();
            }
        }
        
        public enum RunModel
        {
            Demo,
            OutLine,
            Online,
        }
    }
}
