using Cocktails.Interfaces;
using Cocktails.Objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cocktails.DataAction.ValidateElement
{
    class ValidateNewUnit 
    {
        public bool Validate(Unit unit)
        {
            bool exits;
            using (Context con = new Context())
            {
                exits = con.Units.Any(x => x.UnitType == unit.UnitType);
            }
            return (!exits);
        }
    }
}
