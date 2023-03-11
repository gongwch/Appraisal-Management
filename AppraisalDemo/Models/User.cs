using AppraisalDemo.Utilities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppraisalDemo.Models
{
    public class User
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Sex { get; set; }
        public int BaseTypeId { get; set; }
        public bool IsDel { get; set; }
        public static List<User> GetList()
        {
             
            var list = new List<User>();
            DataTable dtUser = SqlHelper.ExecuteTable("SELECT * FROM Users");
            foreach (DataRow item in dtUser.Rows)
            {
                var aUser=item.DataRowToModel<User>();
                list.Add(aUser);
            }
            return list;
        
        }
        public static int Insert(User user)
        {
            return SqlHelper.ExecuteNonQuery
                ($"INSERT INTO Users(UserName,Password,Sex,BaseTypeId,IsDel) " +
                $"VALUES(@UserName,@Password,@Sex,@BaseTypeId,@IsDel)",
                new SqlParameter("@UserName",user.UserName),
                new SqlParameter("@Password",user.Password),
                new SqlParameter("@Sex",user.Sex),
                new SqlParameter("@BaseTypeId",user.BaseTypeId),
                new SqlParameter("@IsDel",user.IsDel)
                );
        }
        public static int Update(User user)
        {
            return SqlHelper.ExecuteNonQuery
            ($"UPDATE Users SET Password=@Password, BaseTypeId=@BaseTypeId," +
            $"UserName=@UserName,Sex=@Sex,IsDel=@IsDel WHERE Id=@Id",
              
            new SqlParameter("@UserName", user.UserName),
            new SqlParameter("@Password", user.Password),
            new SqlParameter("@Sex", user.Sex),
            new SqlParameter("@BaseTypeId", user.BaseTypeId),
            new SqlParameter("@IsDel", user.IsDel)
            );
        }

        
    }

 
}
