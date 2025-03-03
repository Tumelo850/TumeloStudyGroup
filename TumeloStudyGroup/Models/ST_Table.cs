using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace TumeloStudyGroup.Models
{
    public class ST_Table
    {
        [DisplayNameAttribute("STUDENT NUMBER")]
        public string St_Number { get; set; }
        [DisplayNameAttribute(" NAME")]
        public string St_Name { get; set; }
        [DisplayNameAttribute("SURNAME")]
        public string St_Surname { get; set; }
        [DisplayNameAttribute("EMAIL ADDRESS")]
        public string St_Email { get; set; }
    }
}