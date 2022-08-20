using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEMSonWeb.Shared.Entities
{
    public class SPHisAction
    {
        [Key]
        public string?  PHHisActionCode { get; set; }
        public string?  PHIDuser { get; set; }
        public string?  PHIDequip { get; set; }
        public bool     PHHisStautus { get; set; }
        public int      PHequipBorrow { get; set; }
        public int      PHequipReturn { get; set; }

        public DateTime? PHborrow { get; set; }
        public DateTime? PHreturn { get; set; }
    }
}
