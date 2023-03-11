using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace AppraisalDemo.Utilities
{
    public static class ToModel
    {
        public static T DataRowToModel<T>(this DataRow dr)
        {
            Type type = typeof(T);
            T anTInstance= (T)Activator.CreateInstance(type);
            foreach (var item in type.GetProperties())
            {
                if(item.PropertyType == typeof(Boolean))
                {
                    item.SetValue(anTInstance, (Byte)dr[item.Name]==0?false:true);
                    continue;
                }
                item.SetValue(anTInstance, dr[item.Name]);
            }
            return anTInstance;
        }
    }


}
