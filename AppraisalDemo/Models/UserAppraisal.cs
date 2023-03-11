using AppraisalDemo.Utilities;
using System.Data;
using System.Data.SqlClient;

namespace AppraisalDemo.Models
{
    public class UserAppraisal
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int CoefficientId { get; set; }
        public int Count { get; set; }
        public int Year { get; set; }
        public bool IsDel { get; set; }

        public static List<UserAppraisal> GetAllTest()
        {
            string sql = "SELECT * FROM UserAppraisal";
            DataTable dt = SqlHelper.ExecuteTable(sql);

            List<UserAppraisal> list = new List<UserAppraisal>();
            foreach (DataRow dr in dt.Rows)
            {
                var userAppraisal = ToModel.DataRowToModel<UserAppraisal>(dr);
                list.Add(userAppraisal);
            }
            return list;
        }
        public static int Delete(int year, int userId, int id)
        {
            string sql = "DELETE FROM UserAppraisal WHERE " +
                "UserId=@UserID AND Year=@Year AND CoefficientId=@CoefficientId";
            return SqlHelper.ExecuteNonQuery(sql,
                new SqlParameter("@UserID", userId),
                new SqlParameter("@Year", year),
                new SqlParameter("@CoefficientId", id));

        }

        internal static int Insert(UserAppraisal userAppraisal)
        {
            string sql = "INSERT INTO UserAppraisal(UserId,CoefficientId,Count,Year,IsDel) " +
                "VALUES(@UserId,@CoefficientId,@Count,@Year,@IsDel)";
            return SqlHelper.ExecuteNonQuery(sql,
                    new SqlParameter("@UserId",userAppraisal.UserId),
                    new SqlParameter("@CoefficientId",userAppraisal.CoefficientId),
                    new SqlParameter("@Count",userAppraisal.Count),
                    new SqlParameter("@Year",userAppraisal.Year),
                    new SqlParameter("@IsDel",userAppraisal.IsDel)
                    );
        }

    }
}
