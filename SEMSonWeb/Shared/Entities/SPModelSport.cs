using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEMSonWeb.Shared.Entities
{
    public class SPModelSport
    {
        [Key]
        public string? PHSportCode { get; set; }
        public string? PHSportName { get; set; }
    }
}
