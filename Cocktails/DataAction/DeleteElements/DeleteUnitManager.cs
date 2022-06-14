using Cocktails.Objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cocktails.DataAction.DeleteElements
{
    public class DeleteUnitManager
    {
        Unit unit = new Unit();
        public DeleteUnitManager(Unit unit)
        {
            this.unit = unit;
        }
        public bool DeleteUnit()
        {

            DeleteUnit deleteUnit = new DeleteUnit();
            return (deleteUnit.Execute(unit));
        }
    }
}
