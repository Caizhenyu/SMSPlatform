using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SMSPlatformAPI.Models
{
    public class UserApiExtend
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int KeyId { get; set; }
        public int UserId { get; set; }
        public string ApiId { get; set; }
        public string ApiName { get; set; }
        public string Remark { get; set; }
    }
}
