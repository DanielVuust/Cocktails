using Cocktails.Objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cocktails.DataAction.InsertElement
{
    public class InsertNewIngredientType
    {
        public bool Insert(IngredientType ingredientType)
        {
            try
            {
                using (Context con = new Context())
                {
                    con.IngredientTypes.Add(ingredientType);
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

