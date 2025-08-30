using System;
using System.Collections.Generic;
using System.DirectoryServices.ActiveDirectory;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace j0rpiPlayer
{
    public class IniFile
    {
        private string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "settings.ini");
        private readonly Dictionary<string, Dictionary<string, string>> data;

        public IniFile()
        {
            data = new Dictionary<string, Dictionary<string, string>>(StringComparer.OrdinalIgnoreCase);

            if (File.Exists(filePath))
            {
                Load();
            }
        }

        private void Load()
        {
            string? currentSection = null;

            foreach (var line in File.ReadAllLines(filePath))
            {
                var trimmed = line.Trim();

                if (string.IsNullOrEmpty(trimmed) || trimmed.StartsWith(";"))
                    continue;

                // Section
                if (trimmed.StartsWith("[") && trimmed.EndsWith("]"))
                {
                    currentSection = trimmed.Substring(1, trimmed.Length - 2).Trim();
                    if (!data.ContainsKey(currentSection))
                        data[currentSection] = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
                }
                else if (currentSection != null)
                {
                    int idx = trimmed.IndexOf('=');
                    if (idx > 0)
                    {
                        string key = trimmed.Substring(0, idx).Trim();
                        string value = trimmed.Substring(idx + 1).Trim();

                        data[currentSection][key] = value;
                    }
                }
            }
        }

        public string? GetValue(string section, string key, string? defaultValue = null)
        {
            if (data.TryGetValue(section, out var sectionData) &&
                sectionData.TryGetValue(key, out var value))
            {
                return value;
            }
            return defaultValue;
        }

        public int GetInt(string section, string key, int defaultValue = 0)
        {
            var val = GetValue(section, key);
            return int.TryParse(val, out int result) ? result : defaultValue;
        }

        public float GetFloat(string section, string key, float defaultValue = 0f)
        {
            var val = GetValue(section, key);
            return float.TryParse(val, out float result) ? result : defaultValue;
        }

        public bool GetBool(string section, string key, bool defaultValue = false)
        {
            var val = GetValue(section, key);
            return bool.TryParse(val, out bool result) ? result : defaultValue;
        }

        public void SetValue(string section, string key, string value)
        {
            if (!data.ContainsKey(section))
                data[section] = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);

            data[section][key] = value;
        }

        public void Save()
        {
            using (var writer = new StreamWriter(filePath))
            {
                foreach (var section in data)
                {
                    writer.WriteLine($"[{section.Key}]");
                    foreach (var kv in section.Value)
                    {
                        writer.WriteLine($"{kv.Key}={kv.Value}");
                    }
                    writer.WriteLine();
                }
            }
        }
    }
}
