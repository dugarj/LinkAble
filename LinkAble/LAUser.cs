using Microsoft.AspNetCore.Identity;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LABOL
{
    //[Table("LAUser")]
    public class LAUser:IdentityUser
    {
        public string Contact { get; set; }
        public IEnumerable<LAUrl> LAUrls { get; set; }
    }
}
