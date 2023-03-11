using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppraisalDemo.Common
{
    public class FormFactory
    {
        private static Form _form;
        public static Form CreateFormFactory(int index)
        {
            switch (index)
            {
                case 0:
                    _form = new FrmUserManager();
                    break;
                case 1:
                    _form = new FrmBaseManager();
                    break;
                default:
                    break;
            }
            return _form;
        }

       public static Form CreateFormFactory(string name)
        {
            string path = AppDomain.CurrentDomain.BaseDirectory;
            //Assembly assembly = Assembly.LoadFrom("AppraisalDemo");
            Assembly assembly= Assembly.Load("AppraisalDemo");

            List<Type> types = assembly.GetTypes().ToList();
            Type aType = types.Find(m => m.Name == name);
            Form form;
            if (aType != null)
            {
                 form = (Form)Activator.CreateInstance(aType);
            }
            else
            {
                 form= new Form();
            }
            
            return form;


        }
    }
}
