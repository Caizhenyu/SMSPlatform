using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SMSPlatform.Models
{
    public enum MemberStatus
    {
        NoUse=0,
        Normal=1
    }
    public class Member
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int MemberId { get; set; }

        [Required]
        public string MemberNo { get; set; }

        [Required]
        public string MemberName { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime Birthday { get; set; }

        [Required]
        public string Phone { get; set; }

        [DefaultValue(1)]
        public MemberStatus Status { get; set; }
    }
}
