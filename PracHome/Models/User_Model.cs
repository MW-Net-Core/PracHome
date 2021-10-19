using Microsoft.EntityFrameworkCore;
using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PracHome.Models
{
    //public class User_Model
    //{
    //    [Key]
    //    public Guid User_Id { get; set; }
    //    public string User_Name { get; set; }
    //    public string User_Password { get; set; }
    //    public IEnumerable<User_Role_Status> URS_Objs { get; set; }
    //}

    public class Standard
    {
        public int StandardId { get; set; }
        public string StandardName { get; set; }

        public ICollection<Student> Students { get; set; }
    }
}
