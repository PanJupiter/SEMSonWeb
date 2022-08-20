using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEMSonWeb.Shared.Entities
{
    public class SPClientPos
    {
        [Key]
        public string? PHPosCode { get; set; } 
        public string? PHPosName { get; set; }
        //public List<SPClientProfile>? SPClientProfilePos { get; set; }
    }
}
