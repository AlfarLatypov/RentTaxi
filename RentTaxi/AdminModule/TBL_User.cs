using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentTaxi.AdminModule
{
    public enum Gender { Male, fmale}
   public class TBL_User
    {
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public int Department { get; set; }
        public DateTime DOB { get; set; }
        public Gender Gender { get; set; }
        List<Tbl_Roles> Roles;

    }

    public class Tbl_Roles
    {
        public int RoleId { get; set; }
        public string Names { get; set; }
    }


    //class UserRoles
    //{
    //    public int UserRoleId { get; set; }
    //    public string Names { get; set; }
    //}

}
