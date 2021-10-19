using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PracHome.Models
{
    //public class Role_Model
    //{
    //    [Key]
    //    public Guid Role_Id { get; set; }
    //    public string Role_Name { get; set; }
    //    public IEnumerable<User_Role_Status> URS_Objs { get; set; }

    //}

    public class Student
    {
        public int StudentID { get; set; }
        public string StudentName { get; set; }

        //Foreign key for Standard
        public int StandardId { get; set; }
        public Standard Standard { get; set; }
    }
}
