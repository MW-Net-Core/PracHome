using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PracHome.Models
{
    public class TblRole
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public List<TblUserRole> TblUserRoles { get; set; }
    }
}
