using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PracHome.Models
{
    public class TblUserRole
    {
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public Guid RoleId { get; set; }
        

        [ForeignKey(nameof(UserId))]
        public TblUser User { get; set; }

        [ForeignKey(nameof(RoleId))]
        public TblRole Role { get; set; }

    }
}
