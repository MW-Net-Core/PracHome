using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PracHome.Models
{
    public class TblUser
    {
        public Guid Id { get; set; }

        [StringLength(200)]
        public string FirstName { get; set; }
        [StringLength(200)]
        public string LastName { get; set; }
        [StringLength(200)]
        public string Email { get; set; }
        [StringLength(200)]
        public string Phone { get; set; }
        [StringLength(200)]
        public string Address { get; set; }



        public virtual ICollection<TblUserAuth> TblUserAuths { get; set; }
        public virtual ICollection<TblUserRole> TblUserRoles { get; set; }

    }
}
