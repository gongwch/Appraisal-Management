using AppraisalDemo.Models;
using AppraisalDemo.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppraisalDemo
{
    public partial class FrmUserAppraisal : Form
    {
        private DataTable _dtUser;
        public FrmUserAppraisal()
        {
            InitializeComponent();
        }

        private void FrmUserAppraisal_Load(object sender, EventArgs e)
        {
            //Prepare view
            //ExtendColumns();

            //Prepare data structure.
            DataTable _dtUser = PrepareDataStructure();
            PopulateData();
            dgvUserAppraisal.Columns.Clear();
            dgvUserAppraisal.DataSource = _dtUser;
        }

        public  void PopulateData()
        {
            foreach (var item in UserAppraisalBases.GetUserAppraisalsTest())
            {
                var user = UserAppraisalCoefficient.GetAllTest().FindAll(user => user.UserId == item.Id);
                //if (dtUser.Rows[tempId] == null)
                //{
                //    dtUser.Rows[tempId] = new DataRow();
                //}
                var row = _dtUser.NewRow();
                row["Id"] = item.Id;
                row["UserName"] = item.UserName;
                row["Sex"] = item.Sex;
                row["BaseType"] = item.BaseType;
                double yearBonusCoeff = 0;
                for (int i = 0; i < user.Count; i++)
                {
                    string appraisalTypeKey = user[i].AppraisalType;
                    double appraisalTypeValue = user[i].Count;

                    string appraisalCoefficientkey = "AC" + user[i].CoefficientId;
                    decimal appraisalCoefficientValue = user[i].AppraisalCoefficient;

                    string calculationMethodKey = "Sign" + user[i].CoefficientId;
                    int calculationMethodValue = user[i].CalculationMethod;
                    row[appraisalTypeKey] = appraisalTypeValue;
                    row[appraisalCoefficientkey] = appraisalCoefficientValue;
                    //row[calculationMethodKey] = calculationMethodValue;

                    //YearBonus contribution
                    yearBonusCoeff += appraisalTypeValue * (double)appraisalCoefficientValue * calculationMethodValue;

                }
                var b = AppraisalBases.GetAllTest().Find(b => b.Id == item.Id);
                if (b != null)
                {
                    double yearBonus = (yearBonusCoeff + 1) * b.AppraisalBase;
                    row["YearBonus"] = yearBonus < 0 ? 0 : yearBonus;
                }


                _dtUser.Rows.Add(row);
            }
        }

        private DataTable PrepareDataStructure()
        {
            DataTable aDataTable = new DataTable();

            aDataTable.Columns.Add(new DataColumn()
            {
                ColumnName = "Id",
                
            });

            aDataTable.Columns.Add(new DataColumn()
            {
                ColumnName = "UserName"
            });

            aDataTable.Columns.Add(new DataColumn()
            {
                ColumnName = "Sex"
            });

            aDataTable.Columns.Add(new DataColumn()
            {
                ColumnName = "BaseType"
            });
            List<AppraisalCoefficient> appraisalCoefficents = AppraisalCoefficient.GetAllTest();
         //   List<AppraisalCoefficient> appraisalCoefficents1 = AppraisalCoefficient.GetAllTest();
            foreach (var item in appraisalCoefficents)
            {
                aDataTable.Columns.Add(new DataColumn()
                {
                    ColumnName = item.AppraisalType //+ item.Id.ToString(),
                    
                    
                });

                aDataTable.Columns.Add(new DataColumn()
                {
                    ColumnName = "AC" + item.Id.ToString(),
                });
                //aDataTable.Columns.Add(new DataColumn()
                //{
                //    ColumnName = "Sign" + item.Id.ToString(),
                //});

            }
            aDataTable.Columns.Add(new DataColumn() 
            { 
                ColumnName= "YearBonus"
            });
            return aDataTable;
        }

        private void ExtendColumns()
        {
            List<AppraisalCoefficient> appraisalCoefficents = AppraisalCoefficient.GetAllTest();
            List<DataGridViewTextBoxColumn> textBoxColumns = new List<DataGridViewTextBoxColumn>();
            foreach (var item in appraisalCoefficents)
            {
                textBoxColumns.Add(new DataGridViewTextBoxColumn()
                {
                    HeaderText = "A_Type" + item.Id.ToString(),
                    Name = "A_Type"+ item.Id.ToString(),
                    DataPropertyName = "AppraisalType" + item.Id.ToString(),
                    ReadOnly = true,
                    Width = 88

                });

                textBoxColumns.Add(new DataGridViewTextBoxColumn()
                {
                    HeaderText = "A_Coef" + item.Id.ToString(),
                    Name = "A_Coef" + item.Id.ToString(),
                    DataPropertyName = "AppraisalCoefficient" + item.Id.ToString(),
                    ReadOnly = true,
                    Width = 88

                });
                //textBoxColumns.Add(new DataGridViewTextBoxColumn()
                //{
                //    HeaderText = "AppraisalCoefficient" + item.Id.ToString(),
                //    Name = "AppraisalCoefficient" + item.Id.ToString(),
                //    DataPropertyName = "AppraisalCoefficient" + item.Id.ToString(),
                //    ReadOnly = true,
                //    Width = 88

                //});

                textBoxColumns.Add(new DataGridViewTextBoxColumn()
                {
                    HeaderText = "A_Sign",
                    Name = "A_Sign" + item.Id.ToString(),
                    DataPropertyName = "AppraisalSign" + item.Id.ToString(),
                    ReadOnly = true,
                    Width = 88

                });
            }
            textBoxColumns.Add(new DataGridViewTextBoxColumn()
            {
                HeaderText = "YearBonus",
                Name = "YearBonus",
                DataPropertyName = "YearBonus",
                ReadOnly = true,
                Width = 88
            }) ;
            
            dgvUserAppraisal.Columns.AddRange(textBoxColumns.ToArray());
        }

        private void dgvUserAppraisal_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if(e.Button== MouseButtons.Right) 
            {
                if (e.RowIndex > -1)
                {
                    editTsm.Visible = true;
                    dgvUserAppraisal.ClearSelection();
                    dgvUserAppraisal.Rows[e.RowIndex].Selected = true;
                }
            }
        }

        private void dgvUserAppraisal_MouseDown(object sender, MouseEventArgs e)
        {
            editTsm.Visible= false;
        }

        private void editTsm_Click(object sender, EventArgs e)
        {
            int userId =Convert.ToInt32(dgvUserAppraisal.SelectedRows[0].Cells["Id"].Value);
            int year = 2018;
            FrmUserAppraisalFormEdit form = new FrmUserAppraisalFormEdit(userId,year);
            //form.SaveAction+=delegate { PrepareDataStructure(); };
            form.SaveAction+= PopulateData;
            form.ShowDialog();
        }
    }
}
