using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ToolProject.Utilities
{
    public class JsonHelper
    {
        public static string formatJson(string json)
        {
            string result = "";
            try
            {
                result = JValue.Parse(json).ToString(Formatting.Indented);
            }
            catch (Exception ex)
            {
                System.Diagnostics.Trace.WriteLine(ex.StackTrace);
            }
            return result;
        }
    }
}
