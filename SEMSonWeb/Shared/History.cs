using SEMSonWeb.Shared.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEMSonWeb.Shared
{
    public class History : SPModelEquip
    {
        public string? PHHisActionCode { get; set; }
        public int PHequipReturn { get; set; }
        public int PHequipBorrow { get; set; }

        public string? SPClientUsrCode { get; set; }
        public string? SPClientUsrName { get; set; }
        public DateTime? SPClientWhenBorrow { get; set; }
        public DateTime? SPClientWhenReturn { get; set; }

        public SPClientUser SPClientUsers { get; set; } = new SPClientUser { LSPClientProfile = new SPClientProfile() };
    }
}
