using Cocktails.Objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cocktails.DataAction.InsertElement
{
    public class InsertNewUnit
    {
        public bool Insert(Unit unit)
        {
            try
            {
                using (Context con = new Context())
                {
                    con.Units.Add(unit);
                    con.SaveChanges();
                }
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return false;
            }
            
        }
    }
}
