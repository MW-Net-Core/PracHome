using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PracHome.Models
{
    //public class User_Role_Status
    //{
    //    [Key]
    //    public Guid URS_PK_Id { get; set; }
    //    // User Forign key
    //    [ForeignKey("User_Id")]
    //    public Guid User_Id { get; set; }
    //  //  public User_Model User_Obj { get; set; }
    //    // User Forign key
    //    [ForeignKey("Role_Id")]
    //    public Guid Role_Id { get; set; }
    //   // public Role_Model Role_Obj { get; set; }
    //}


    public class StudentStandardRelation
    {
        [Key]
        public int StudentStandardRelationId { get; set; }
        public int StandardId { get; set; }
        public int StudentID { get; set; }
        //public ICollection<Standard> Standards { get; set; }
        //public ICollection<Student> Students { get; set; }
    }
}
