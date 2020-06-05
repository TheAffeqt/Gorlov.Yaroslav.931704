using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FourthLab.Models
{
    public class ControlModel
    {
        public string Result { get; set; }
        public string ControlElement { get; set; }
        public string Name { get; set; }
        public string Radio { get; set; } = null;
        public string DropDownList { get; set; } = null;
        public string ListBox { get; set; } = null;
    }
}
