using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SMSPlatform.Models
{
    public enum Level
    {
        User=0,
        Admin =1
    }

    public enum UserStatua
    {
        NoUse=0,
        Normal=1
    }

    public class User
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int UserId { get; set; }

        [Required]
        public string UserNo { get; set; }

        [Required]
        public string UserName { get; set; }

        [Required]
        public string Password { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime Birthday { get; set; }

        [Required]
        public string Phone { get; set; }

        [Required]
        [DefaultValue(0)]
        public Level Level { get; set; }

        [DefaultValue(1)]
        public UserStatua Status { get; set; }

        public string PermissionList { get; set; }
    }
}
