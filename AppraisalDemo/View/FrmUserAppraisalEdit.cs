using AppraisalDemo.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using TextBox = System.Windows.Forms.TextBox;

namespace AppraisalDemo.View
{
    public partial class FrmUserAppraisalFormEdit : Form
    {
        private int _userId;
        private int _year;
        public Action SaveAction;
        public FrmUserAppraisalFormEdit()
        {
            InitializeComponent();
        }
        public FrmUserAppraisalFormEdit(int userId, int year) : this()
        {
            _userId = userId;
            _year = year;
        }

        private void FrmUserAppraisalFormEdit_Load(object sender, EventArgs e)
        {
            LoadControls();
            LoadData();


        }
        /// <summary>
        /// Load controls.
        /// </summary>
        private void LoadControls()
        {
            List<AppraisalCoefficient> appraisalCoefficents = AppraisalCoefficient.GelAll();
            foreach (var appraisalCoefficent in appraisalCoefficents)
            {
                Panel panel = new Panel();
                Label label = new Label()
                {
                    Text = appraisalCoefficent.AppraisalType,
                    AutoSize = true,

                };
                TextBox textBox = new TextBox()
                {
                    Location = new Point(200, 0),
                    Width = 120,
                    Tag = appraisalCoefficent.Id



                };
                panel.Controls.Add(label);
                panel.Controls.Add(textBox);
                panel.AutoSize = true;
                flowLayoutPanel.Controls.Add(panel);

            }
        }

        /// <summary>
        /// Load data for controls, data comes from UserAppraisalCoefficient
        /// </summary>
        private void LoadData()
        {
            var temp = UserAppraisal.GetAllTest().FindAll(i => i.Year == _year && i.UserId == _userId);
            foreach (var t in temp)
            {
                foreach (var c in flowLayoutPanel.Controls)
                {
                    var panel = c as Panel;
                    if (panel != null)
                    {
                        foreach (var item in panel.Controls)
                        {

                            if (item is TextBox)
                            {
                                if (t.CoefficientId == (int)((TextBox)item).Tag)
                                {
                                    ((TextBox)item).Text = t.Count.ToString();
                                }
                            }
                        }

                    }


                }
            }
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            var temp = UserAppraisal.GetAllTest().FindAll(i => i.Year == _year && i.UserId == _userId);

            foreach (var t in temp)
            {
                foreach (var c in flowLayoutPanel.Controls)
                {
                    var panel = c as Panel;
                    if (panel != null)
                    {
                        foreach (var item in panel.Controls)
                        {

                            if (item is TextBox)
                            {
                                if (t.CoefficientId == (int)((TextBox)item).Tag)
                                {
                             
                                    int count = Convert.ToInt32(((TextBox)item).Text);
                                    UserAppraisal.Delete(_year, _userId, t.CoefficientId);
                                    //First delete, then insert.
                                    UserAppraisal userAppraisal = new UserAppraisal()
                                    {
                                        UserId = _userId,
                                        CoefficientId = t.CoefficientId,
                                        Count = count,
                                        Year = _year,
                                        IsDel = false

                                    };
                                    UserAppraisal.Insert(userAppraisal);
                                }
                            }

                        }
                    }

                }


            }
            if(SaveAction!=null) { SaveAction(); }
            
        }

    }
}

