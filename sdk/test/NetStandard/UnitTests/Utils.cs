using System.IO;
using System.Reflection;

namespace AWSSDK_NetStandard.UnitTests
{
    public class Utils
    {   
        public static Stream GetAssemblyResourceStream(string resourceName)
        {
            Assembly assembly = typeof(Utils).GetTypeInfo().Assembly;
            return assembly.GetManifestResourceStream(resourceName);
        }
    }
}