using AppraisalDemo.Utilities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppraisalDemo.Models
{
    public class AppraisalBases
    {
        public int Id { get; set; }
        public string BaseType { get; set; }
        public int AppraisalBase { get; set; }
        public bool IsDel { get; set; }
        public AppraisalBases()
        {

        }

        public AppraisalBases(int id,string baseType,int apprisalBase,bool isDel)
        {
            this.Id = id;
            this.BaseType = baseType; 
            this.AppraisalBase = apprisalBase;
            this.IsDel = isDel;
        }
        public static List<AppraisalBases> GetAllTest()
        {

            //List<AppraisalBases> appraisalBases= new List<AppraisalBases>() { 
            //    new AppraisalBases(1,"ZFBZ",20000,false),
            //    new AppraisalBases(2,"XZBZ",18000,false),
            //    new AppraisalBases(3,"SYBZ1",18000,false),
            //    new AppraisalBases(4,"SYBZ2",19800,false),
            //    new AppraisalBases(5,"SYBZ3",16000,false),
            //    new AppraisalBases(6,"SHHYG",8000,false)
            //};
            List<AppraisalBases> appraisalBases = new List<AppraisalBases>();
            DataTable dt=SqlHelper.ExecuteTable("SELECT * FROM AppraisalBases");


            foreach (DataRow dr in dt.Rows)
            {
                var temp=ToModel(dr);
                appraisalBases.Add(temp);
                
            }
            return appraisalBases;
        }
         private static AppraisalBases ToModel(DataRow dr)
        {
            AppraisalBases anAppraisalBase = new AppraisalBases();
            anAppraisalBase.Id = (int)dr["Id"];
            anAppraisalBase.BaseType= (string)dr["BaseType"]; 
            anAppraisalBase.AppraisalBase= (int)dr["AppraisalBase"];
            anAppraisalBase.IsDel = (Byte)dr["IsDel"]==0?false:true;
            return anAppraisalBase; 
        }

    }
}
