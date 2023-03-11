using AppraisalDemo.Utilities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace AppraisalDemo.Models
{
    public  class UserAppraisalBases
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Sex { get; set; }
       // public string Password { get; set; }
        public int BaseTypeId { get; set; }
        public string BaseType { get; set; }
        public int AppraisalBase { get; set; }
        public bool IsDel { get; set; }

        public UserAppraisalBases()
        {

        }
        public UserAppraisalBases(int id, string userName, string sex, string password, int baseTypeId, string baseType, int appraisalBase, bool isDel)
        {
            Id = id;
            UserName = userName;
            Sex = sex;
            //Password = password;
            BaseTypeId = baseTypeId;
            BaseType = baseType;
            AppraisalBase = appraisalBase;
            IsDel = isDel;
        }

        //public static List<UserAppraisalBases> GetUserAppraisals()
        //{
        //    List<UserAppraisalBases> userAppraisalBases = new List<UserAppraisalBases>() {
        //        new UserAppraisalBases(1,"ZhangSan","M", "111",1,"ZFBZ",20000,false),
        //        new UserAppraisalBases(2,"LiSI","F","111",2,"XZBZ",18000,false),
        //        new UserAppraisalBases(3,"WangWu","M","111",3,"SYBZ1",18000,false),
        //        new UserAppraisalBases(4,"ZhaoLiu","F","111",4,"SYBZ2",19800,false),
        //        new UserAppraisalBases(5,"TianQi","M","111",5,"SYBZ3",16000,false),
        //        new UserAppraisalBases(6,"ZhouBa","F","111",6,"SHHYG",8000,false),
        //        new UserAppraisalBases(7,"WuJiu","F","111",6,"SHHYG",8000,false)
        //    };

        //    return userAppraisalBases;
        //}

        public static List<UserAppraisalBases> GetUserAppraisalsTest()
        {
            List<UserAppraisalBases> userAppraisalBases = new List<UserAppraisalBases>();
            string sql = "SELECT Users.Id, Users.UserName, Users.Sex,AppraisalBases.Id AS BaseTypeId, AppraisalBases.BaseType, AppraisalBases.AppraisalBase, AppraisalBases.IsDel FROM Users LEFT JOIN AppraisalBases ON Users.BaseTypeId=AppraisalBases.Id";
            DataTable dt = SqlHelper.ExecuteTable(sql);
            foreach (DataRow dr in dt.Rows)
            {
                var model=ToModel.DataRowToModel<UserAppraisalBases>(dr);
                userAppraisalBases.Add(model);
            }
            return userAppraisalBases;
        }
  


    }
}
