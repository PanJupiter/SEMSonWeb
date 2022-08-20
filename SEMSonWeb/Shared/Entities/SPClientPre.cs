using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEMSonWeb.Shared.Entities
{
    public class SPClientPre
    {
        [Key]
        public string? PHPreCode { get; set; }
        public string? PHPreName { get; set; }
        //public List<SPClientProfile>? SPClientProfilePre { get; set; }

    }
}
