using AppraisalDemo.Utilities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace AppraisalDemo.Models
{
    internal class UserAppraisalCoefficient
    {
        public int Id { get; set; } 
        public int UserId { get; set; }
        public int CoefficientId { get; set; } 
        public double Count { get; set; }
        public int AccessmentYear { get; set; }
        public string AppraisalType { get; set; }
        public decimal AppraisalCoefficient { get; set; }
        public int CalculationMethod { get; set; }
        public bool IsDel { get; set; }

        public UserAppraisalCoefficient()
        {

        }

        public UserAppraisalCoefficient(int id, int userId, int coefficientId, double count, int accessmentYear, string appraisalType, decimal appraisalCoefficient, int calculationMethod, bool isDel)
        {
            Id = id;
            UserId = userId;
            CoefficientId = coefficientId;
            Count = count;
            AccessmentYear = accessmentYear;
            AppraisalType = appraisalType;
            AppraisalCoefficient = appraisalCoefficient;
            CalculationMethod = calculationMethod;
            IsDel = isDel;
        }
        public static List<UserAppraisalCoefficient> GetAll()
        {
            List<UserAppraisalCoefficient> userAppraisalCoefficients = new List<UserAppraisalCoefficient>()
            {
                //new UserAppraisalCoefficient(1,1,1,12,2018,"Leave",0.1,-1,false),
                //new UserAppraisalCoefficient(2,1,2,2,2018,"Late",0.05,-1,false),
                //new UserAppraisalCoefficient(3,1,3,12,2018,"Overtime",0.1,1,false),
                //new UserAppraisalCoefficient(4,1,4,158,2018,"CaseNumber",0.0005,1,false),
                //new UserAppraisalCoefficient(5,1,5,36,2018,"Maintenance",0.002,1,false),
                //new UserAppraisalCoefficient(6,1,6,3,2018,"Project",0.3,1,false),

                //new UserAppraisalCoefficient(7,2,1,9,2018,"Leave",0.1,-1,false),
                //new UserAppraisalCoefficient(8,2,2,7,2018,"Late",0.05,-1,false),
                //new UserAppraisalCoefficient(9,2,3,15,2018,"Overtime",0.1,1,false),
                //new UserAppraisalCoefficient(10,2,4,90,2018,"CaseNumber",0.0005,1,false),
                //new UserAppraisalCoefficient(11,2,5,98,2018,"Maintenance",0.002,1,false),
                //new UserAppraisalCoefficient(12,2,6,4,2018,"Project",0.3,1,false),

                //new UserAppraisalCoefficient(13,3,1,8,2018,"Leave",0.1,-1,false),
                //new UserAppraisalCoefficient(14,3,2,6,2018,"Late",0.05,-1,false),
                //new UserAppraisalCoefficient(15,3,3,17,2018,"Overtime",0.1,1,false),
                //new UserAppraisalCoefficient(16,3,4,79,2018,"CaseNumber",0.0005,1,false),
                //new UserAppraisalCoefficient(17,3,5,89,2018,"Maintenance",0.002,1,false),
                //new UserAppraisalCoefficient(18,3,6,3,2018,"Project",0.3,1,false),

                //new UserAppraisalCoefficient(13,4,1,9,2018,"Leave",0.1,-1,false),
                //new UserAppraisalCoefficient(14,4,2,5,2018,"Late",0.05,-1,false),
                //new UserAppraisalCoefficient(15,4,3,14,2018,"Overtime",0.1,1,false),
                //new UserAppraisalCoefficient(16,4,4,66,2018,"CaseNumber",0.0005,1,false),
                //new UserAppraisalCoefficient(17,4,5,90,2018,"Maintenance",0.002,1,false),
                //new UserAppraisalCoefficient(18,4,6,4,2018,"Project",0.3,1,false),
            };
            return userAppraisalCoefficients;
        }

        public static List<UserAppraisalCoefficient> GetAllTest() 
        {
            List<UserAppraisalCoefficient> userAppraisalCoefficients = new List<UserAppraisalCoefficient>();
            string sql= "SELECT ua.Id, ua.UserId,ua.CoefficientId, ac.AppraisalType,ac.AppraisalCoefficent AS AppraisalCoefficient,ac.AppraisalSign AS CalculationMethod,ua.Count,ua.Year AS AccessmentYear,ua.IsDel " +
                "FROM UserAppraisal AS ua " +
                "LEFT JOIN AppraisalCoefficent AS ac " +
                "ON ua.CoefficientId = ac.Id";
            DataTable dt =SqlHelper.ExecuteTable(sql); 
            foreach(DataRow dr in dt.Rows)
            {
                var t=ToModel.DataRowToModel<UserAppraisalCoefficient>(dr);
                userAppraisalCoefficients.Add(t);
            }
            return userAppraisalCoefficients; 
        }


    }
}


