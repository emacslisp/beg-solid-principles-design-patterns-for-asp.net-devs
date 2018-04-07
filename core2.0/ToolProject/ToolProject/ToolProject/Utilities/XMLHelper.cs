using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ToolProject.Utilities
{
    /// <summary>
    /// xml helper
    /// </summary>
    public class XMLHelper
    {
        /// <summary>
        /// format xml
        /// </summary>
        /// <param name="xml"></param>
        /// <returns></returns>
        public static string formatXML(string xml)
        {
            try
            {
                XDocument doc = XDocument.Parse(xml);
                return doc.Declaration == null ? doc.ToString() : (doc.Declaration + Environment.NewLine + doc.ToString());
            }
            catch (Exception)
            {
                return xml;
            }
        }
    }
}
