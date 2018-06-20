﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SMSPlatformAPI.Models
{
    public class Permission
    {
        [Key]
        public string PermissionId { get; set; }
        public string PermissionName { get; set; }
    }
}
