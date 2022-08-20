using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace SEMSonWeb.Shared.Entities
{
    public class SPClientClass
    {
        [Key]
        public string? PHClassCode { get; set; }
        public string? PHClassName { get; set; }
        //public List<SPClientProfile>? SPClientProfileCla { get; set; }
    }
}
