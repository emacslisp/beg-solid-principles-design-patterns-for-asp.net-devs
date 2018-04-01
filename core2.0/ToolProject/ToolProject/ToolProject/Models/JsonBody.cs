using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ToolProject.Models
{
    public class JsonBody
    {
        [DataType(DataType.MultilineText)]
        public string Body { get; set; }
    }
}
