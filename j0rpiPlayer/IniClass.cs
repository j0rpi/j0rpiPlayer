using System;
using System.Runtime.InteropServices;
using System.Text;

namespace INI
{
    public class IniFile
    {
        public string path;

        [DllImport("kernel32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
        private static extern bool WritePrivateProfileString(
    string section, string key, string value, string filePath);

        [DllImport("kernel32.dll", CharSet = CharSet.Unicode)]
        private static extern int GetPrivateProfileString(
            string section, string key, string defaultValue,
            StringBuilder retVal, int size, string filePath);
        StringBuilder temp = new StringBuilder(1024);

        public IniFile(string INIPath)
        {
            path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, INIPath);
        }
        public void IniWriteValue(string Section, string Key, string Value)
        {
            WritePrivateProfileString(Section, Key, Value, this.path);
        }
        public string IniReadValue(string Section, string Key)
        {
            StringBuilder temp = new StringBuilder(1024);
            int i = GetPrivateProfileString(Section, Key, "", temp,
                                            255, this.path);
            return temp.ToString();

        }
        public void Flush()
        {
            WritePrivateProfileString(null, null, null, path);
        }
    }
}