using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEMSonWeb.Shared.Entities
{
    public class SPModelEquip
    {
        [Key]
        public string?      PHEquipCode { get; set; }
        public string?      PHEquipName { get; set; }
        public string?      PHEquipImg { get; set; }
        public int          PHEquipAmount { get; set; }
        public int          PHEquipLost { get; set; }
        public int          PHEquipBroken { get; set; }
        public int          PHEquipTotal { get; set; }
        public int          PHEquipBorroww { get; set; }
        public string?      PHEquipUnit { get; set; }
        public string?      PHEquipStatus { get; set; }

        public DateTime?    PHEquipwhenCreate { get; set; }
        public DateTime?    PHEquipwhenEdit { get; set; }
        public string?      PHEquipWhoCreate { get; set; }
        public string?      PHEquipWhoEdit { get; set; }

        public string?      PHSportCode { get; set; }
        public SPModelSport? LSPModelSport { get; set; }
    }
}
