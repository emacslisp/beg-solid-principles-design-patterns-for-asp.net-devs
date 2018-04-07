using System.ComponentModel.DataAnnotations;

namespace ToolProject.Models
{
    public class XMLBody
    {
        [DataType(DataType.MultilineText)]
        public string Description { get; set; }

        [DataType(DataType.MultilineText)]
        public string Output { get; set; }
    }
}
