using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PracHome.Models
{
    public class TblUserAuth
    {
        public Guid Id { get; set; }
        public Guid UserId { get; set; }


        public bool EmailConfirmed { get; set; }
        [StringLength(200)]
        public string PasswordHash { get; set; }
        [StringLength(200)]
        public string SecurityStamp { get; set; }
        public bool TwoFactorEnabled { get; set; }
        public bool LockoutEnabled { get; set; }

        

        [ForeignKey(nameof(UserId))]
        public virtual TblUser User { get; set; }
    }
}
