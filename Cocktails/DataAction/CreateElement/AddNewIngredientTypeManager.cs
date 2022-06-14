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
    class AddNewIngredientTypeManager : IAddNewElementToDB
    {
        IngredientType ingredientType = new IngredientType();
        public AddNewIngredientTypeManager(string ingredientTypeName)
        {
            ingredientType.IngredientTypeName = ingredientTypeName;
        }
        public bool AddNewElement()
        {
            ValidateNewIngredientType validate = new ValidateNewIngredientType();
            if (!validate.Validate(ingredientType))
                return false;

            InsertNewIngredientType insertNewUnit = new InsertNewIngredientType();
            return (insertNewUnit.Insert(ingredientType));
        }
    }
}
