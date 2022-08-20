using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace SEMSonWeb.Shared.Entities
{
    public class SPClientProfile
    {
        [Key]
        public string?      PHProfileCode { get; set; }
        public string?      PHProfilefName { get; set; }
        public string?      PHProfilelName { get; set; }
        public string?      PHProfileEmail { get; set; }
        public string?      PHProfileImg { get; set; }
        public string?      PHProfilePhone { get; set; }
        public string?      PHProfileClassroom { get; set; }

        public string?      PHProfileIDcard { get; set; }
        public string?      PHProfileIDstudent { get; set; }

        public DateTime?    PHwhenCreate { get; set; }
        public DateTime?    PHwhenEdit { get; set; }
        public string?      PHWhoCreate { get; set; }
        public string?      PHWhoEdit { get; set; }

        public string? PHClassCode { get; set; }
        public string? PHDepCode { get; set; }
        public string? PHPosCode { get; set; }
        public string? PHPreCode { get; set; }


        public SPClientClass? LSPClientClass { get; set; }
        public SPClientDep? LSPClientDep { get; set; }
        public SPClientPre? LSPClientPre { get; set; }
        public SPClientPos? LSPClientPos { get; set; }


        [JsonIgnore]
        public SPClientUser? LSPClientUser { get; set; }
    }
}
