using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace Xugz
{
    /// <summary>
    /// 文件读写操作
    /// </summary>
    public class StreamOP
    {
        class FileBase
        {
            public interface IFileFactory
            {
                void SetPar(object[] obj);
                void Write(object value, string path);
                object Read(string path);
            }
            public class CsvFactory : IFileFactory
            {
                public void SetPar(object[] obj)
                {

                }
                public void Write(object value, string path)
                {
                    try
                    {
                        if (!File.Exists(path))
                        {
                            Directory.CreateDirectory(path);
                            Directory.Delete(path);
                        }
                    }
                    catch { }
                    StreamWriter streamWriter = new StreamWriter(path, true, Encoding.Default);
                    streamWriter.WriteLine(value);
                    streamWriter.Close();
                }
                public object Read(string path)
                {
                    string strline;
                    ArrayList array = new ArrayList();
                    StreamReader mysr = new StreamReader(path, Encoding.Default);
                    while ((strline = mysr.ReadLine()) != null)
                    {
                        array.Add(strline);
                    }
                    return (string[])array.ToArray(typeof(string));
                }
            }
            public class BinaryFactory : IFileFactory
            {
                public void SetPar(object[] obj)
                {

                }
                public void Write(object value, string path)
                {
                    try
                    {
                        try
                        {
                            if (!File.Exists(path))
                            {
                                Directory.CreateDirectory(path);
                                Directory.Delete(path);
                            }
                        }
                        catch { }
                        FileStream myStream = new FileStream(path, FileMode.OpenOrCreate, FileAccess.ReadWrite);
                        BinaryFormatter myFormatter = new BinaryFormatter();
                        myFormatter.Serialize(myStream, value);
                        myStream.Close();
                    }
                    catch { }
                }
                public object Read(string path)
                {
                    object obj;
                    using (FileStream myStream = new FileStream(path, FileMode.OpenOrCreate))
                    {
                        BinaryFormatter myFormatter = new BinaryFormatter();
                        obj = myFormatter.Deserialize(myStream);
                        myStream.Close();
                    }
                    return obj;
                }
            }
            public class IniFactory : IFileFactory
            {
                [DllImport("kernel32")]
                private static extern int WritePrivateProfileString(string name, string key, string value, string path);
                [DllImport("kernel32")]
                private static extern int GetPrivateProfileString(string name, string key, string def, StringBuilder retVal, int size, string path);
                string _name = "";
                string _key = "";
                string _value;
                public void SetPar(object[] obj)
                {
                    _name = obj[0].ToString();
                    _key = obj[1].ToString();
                    _value = obj[2].ToString();
                }
                public void Write(object value, string path)
                {
                    try
                    {
                        if (!File.Exists(path))
                        {
                            Directory.CreateDirectory(path);
                            Directory.Delete(path);
                        }
                    }
                    catch { }
                    WritePrivateProfileString(_name, _key, _value, path);
                }
                public object Read(string path)
                {
                    StringBuilder retValue = new StringBuilder(500);
                    if (GetPrivateProfileString(_name, _key, "", retValue, 500, path) > 0) { _value = retValue.ToString(); }
                    else { WritePrivateProfileString(_name, _key, _value, path); }
                    return _value;
                }
            }
        }
        public class FileBaseFactory
        {
            FileBase.IFileFactory iFileBase;
            public enum FileType
            {
                Csv,
                Binary,
                Text,
                Ini,
            }
            public FileBaseFactory(FileType fileType)
            {
                switch (fileType)
                {
                    case FileType.Csv:
                    case FileType.Text:
                        iFileBase = new FileBase.CsvFactory();
                        break;
                    case FileType.Binary:
                        iFileBase = new FileBase.BinaryFactory();
                        break;
                    case FileType.Ini:
                        iFileBase = new FileBase.IniFactory();
                        break;
                }
            }

            public void Write(object value, string path)
            {
                string[] obj = new string[3] { "", "", "" };
                iFileBase.SetPar(obj);
                iFileBase.Write(value, path);
            }
            public void Write(string name, string key, string value, string path)
            {
                string[] obj = new string[3] { name, key, value };
                iFileBase.SetPar(obj);
                iFileBase.Write(value, path);
            }
            public object Read(string path)
            {
                string[] obj = new string[3] { "", "", "" };
                iFileBase.SetPar(obj);
                return iFileBase.Read(path);
            }
            public object Read(string name, string key, string value, string path)
            {
                string[] obj = new string[3] { name, key, value };
                iFileBase.SetPar(obj);
                return iFileBase.Read(path);
            }
        }
    }
}
