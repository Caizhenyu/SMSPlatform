using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SMSPlatform.Models
{
    public enum ApiStatus
    {
        NoUse=0,
        Normal=1
    }
    public class Api
    {
        [Key]
        public string ApiId { get; set; }
        public string ApiName { get; set; }

        [DefaultValue(1)]
        public ApiStatus Status { get; set; }
        public string Address { get; set; }
    }
}
