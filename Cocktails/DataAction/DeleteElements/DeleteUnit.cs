using Cocktails.Objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cocktails.DataAction.DeleteElements
{
    public class DeleteUnit
    {
        public bool Execute(Unit unit)
        {
            try
            {
                using (Context con = new Context())
                {
                    Unit toBeRemovedUnit = con.Units.First(x => x.UnitType == unit.UnitType);
                    con.Units.Remove(toBeRemovedUnit);
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
