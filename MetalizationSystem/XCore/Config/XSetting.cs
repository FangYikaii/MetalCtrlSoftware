using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.Collections;
using System.Collections.Concurrent;
using System.IO;
using System.Diagnostics;

namespace XCore
{
    public class XSetting : XObject
    {
        protected ConcurrentDictionary<string, string> settingMap = new ConcurrentDictionary<string, string>();
        protected string path ="";
        protected string root = "";
        protected string BackUpPath = "";

        public void SetPathAndRoot(string path, string root)
        {
            this.path = path;
            this.root = root;
        }

        public void SetBackUpPath(string BackUpPath)
        {
            this.BackUpPath = BackUpPath;
        }

        public string Name;

        public int LoadSetting()
        {
            try
            {
                XmlDocument doc = new XmlDocument();
                doc.Load(path);
                XmlNode parent = doc.SelectSingleNode(root);
                if (parent == null)
                {
                    return 1;
                }
                XmlNodeList children = parent.ChildNodes;
                foreach (XmlElement child in children)
                {
                    settingMap.TryAdd(child.Name, child.InnerText);
                }
                return 0;
            }
            catch(Exception ex)
            {
                Trace.WriteLine(ex, this.GetType().ToString());
                return -1;
            }
        }

        public int SaveSetting()
        {
            try
            {
                if (BackUpPath!="")
                {
                    SaveFileToBackUp();
                }
                XmlDocument doc = new XmlDocument();
                doc.Load(path);
                XmlNode parent = doc.SelectSingleNode(root);
                XmlNodeList children = parent.ChildNodes;
                foreach (XmlElement xe in children)
                {
                    foreach (KeyValuePair<string,string> kvp in settingMap)
                    {
                        if (xe.Name == kvp.Key)
                        {
                            xe.InnerText = kvp.Value;
                        }
                    }
                }
                doc.Save(path);
                return 0;
            }
            catch(Exception ex)
            {
                Trace.WriteLine(ex, this.GetType().ToString());
                return -1;
            }
        }

        public bool SaveFileToBackUp()
        {
            string BackUpFileName = "";
            string FileName = "";
            string DirPath = DateTime.Now.ToString("yyyy-MM-dd");
            DirPath = BackUpPath+DirPath+"\\";
            if (Directory.Exists(DirPath) == false)
            {
                Directory.CreateDirectory(DirPath);
            }
            FileName = path.Substring(path.LastIndexOf("\\") + 1);
            FileName = FileName.Remove(FileName.LastIndexOf(".xml")) + " " + DateTime.Now.ToString("HH-mm-ss") + ".xml";
            BackUpFileName = DirPath + FileName  ;
            File.Copy(path, BackUpFileName, true);
            return true;
        }

    }
}
