using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace SEMSonWeb.Shared.Entities
{
    public class SPClientUser
    {
        [Key]
        public string?          PHUserCode { get; set; }
        public string?          PHUserName { get; set; }
        public string?          PHUserPassword { get; set; }
        public string?          PHUserState { get; set; }
        public bool?          PHUserStatus { get; set; }

        public DateTime?        PHUserwhenCreate { get; set; }
        public DateTime?        PHUserwhenEdit { get; set; }
        public string?          PHUserWhoCreate { get; set; }
        public string?          PHUserWhoEdit { get; set; }


        public string?          PHProfileCode { get; set; }
        public SPClientProfile LSPClientProfile { get; set; }
    }
}
