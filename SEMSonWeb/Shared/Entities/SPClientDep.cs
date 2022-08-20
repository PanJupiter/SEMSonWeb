using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEMSonWeb.Shared.Entities
{
    public class SPClientDep
    {
        [Key]
        public string? PHDepCode { get; set; }
        public string? PHDepName { get; set; }
        //public List<SPClientProfile>? SPClientProfileDep { get; set; }
    }
}
