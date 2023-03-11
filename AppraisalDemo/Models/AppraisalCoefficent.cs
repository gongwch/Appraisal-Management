using AppraisalDemo.Utilities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppraisalDemo.Models
{
    public class AppraisalCoefficient
    {
        public int Id { get; set; }
        public string AppraisalType { get; set; }  
        public decimal AppraisalCoefficent { get; set; }
        public int AppraisalSign { get; set; }
        public bool IsDel { get; set; }

        public AppraisalCoefficient()
        {

        }

        public AppraisalCoefficient(int id, string appraisalType, decimal appraisalCoefficient, int calculationMethod, bool isDel)
        {
            Id = id;
            AppraisalType = appraisalType;
            AppraisalCoefficent = appraisalCoefficient;
            AppraisalSign = calculationMethod;
            IsDel = isDel;
        }

        public static List<AppraisalCoefficient> GelAll()
        {
            List<AppraisalCoefficient> appraisalCoefficents = new List<AppraisalCoefficient>()
              {
                  new AppraisalCoefficient(1,"Leave",0.1m,-1,false),
                  new AppraisalCoefficient(2,"Late",0.05000m,-1,false),
                  new AppraisalCoefficient(3,"Overtime",0.10000m,1,false),
                  new AppraisalCoefficient(4,"CaseNumber",0.0005m,1,false),
                  new AppraisalCoefficient(5,"Maintenance",0.002m,1,false),
                  new AppraisalCoefficient(6,"Project",0.3m,1,false)

              };
            return appraisalCoefficents;


        }
        public static List<AppraisalCoefficient> GetAllTest()
        {
            List<AppraisalCoefficient> appraisalCoefficents = new List<AppraisalCoefficient>();
            DataTable dt = SqlHelper.ExecuteTable("SELECT * FROM AppraisalCoefficent");

            foreach (DataRow dr in dt.Rows)
            {
                appraisalCoefficents.Add(ToModel.DataRowToModel<AppraisalCoefficient>(dr));
            }
            return appraisalCoefficents;
        }

    }
}
