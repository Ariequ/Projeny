using System.Collections.Generic;
using System.IO;
using System.Text;
using YamlDotNet.Serialization;
using YamlDotNet.Serialization.NamingConventions;

namespace Projeny
{
    public class ProjectConfig
    {
        public List<string> AssetsFolder = new List<string>();
        public List<string> PluginsFolder = new List<string>();
    }
}
