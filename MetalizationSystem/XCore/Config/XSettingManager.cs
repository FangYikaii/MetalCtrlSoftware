using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace XCore
{
    public sealed class XSettingManager
    {
        private static readonly XSettingManager instance = new XSettingManager();
        XSettingManager()
        {

        }
        public static XSettingManager Instance
        {
            get { return instance; }
        }

        private Dictionary<int, XSetting> settingMap = new Dictionary<int, XSetting>();

        public void BindSetting(int setId, XSetting setting, string name)
        {
            if (settingMap.ContainsKey(setId) == false)
            {
                setting.Name = name;
                settingMap.Add(setId, setting);
            }
        }

        public XSetting FindSettingById(int setId)
        {
            if (settingMap.ContainsKey(setId) == false)
            {
                return null;
            }
            return settingMap[setId];
        }

        public Dictionary<int, XSetting> SettingMap
        {
            get { return this.settingMap; }
        }

        public void LoadSettings()
        {
            foreach (XSetting setting in settingMap.Values)
            {
                setting.LoadSetting();
            }
        }
    }
}
