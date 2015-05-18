using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.IO;

namespace spiked3
{
    public static class ConfigManager
    {
        static dynamic jsn = JsonConvert.DeserializeObject(File.ReadAllText("config.json"));

        public static T Get<T>(string key)
        {
            return (T)(jsn?[System.Environment.MachineName]?[key]);
        }
    }
}
