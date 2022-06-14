using Cocktails.DataAction.InsertElement;
using Cocktails.DataAction.ValidateElement;
using Cocktails.Interfaces;
using Cocktails.Objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cocktails.DataAction.CreateElement
{
    public class AddNewUnitManager : IAddNewElementToDB
    {
        Unit unit = new Unit();
        public AddNewUnitManager(string UnitType)
        {
            unit.UnitType = UnitType;
        }
        public bool AddNewElement()
        {
            ValidateNewUnit validate = new ValidateNewUnit();
            if (!validate.Validate(unit))
                return false;

            InsertNewUnit insertNewUnit = new InsertNewUnit();
            return (insertNewUnit.Insert(unit));
        }
    }
}
