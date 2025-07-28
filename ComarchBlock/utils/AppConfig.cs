using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComarchBlock.utils
{
    public class AppConfig
    {
        public int ActiveUsersCheck { get; set; } = 0;

        public static AppConfig Load(string path)
        {
            if (!File.Exists(path)) return new AppConfig();

            var doc = new System.Xml.XmlDocument();
            doc.Load(path);
            var root = doc.DocumentElement;

            var value = root?.SelectSingleNode("ActiveUsersCheck")?.InnerText;
            if (int.TryParse(value, out var parsed))
            {
                return new AppConfig { ActiveUsersCheck = parsed };
            }

            return new AppConfig();
        }
    }
}
