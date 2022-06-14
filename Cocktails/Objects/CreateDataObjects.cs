using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cocktails.Objects
{
    class CreateDataObjects
    {
        private Context con;
        public CreateDataObjects()
        {
            using (con = new Context())
            {
                CreateUnits();
                con.SaveChanges();

                CreateIngredientTypes();
                con.SaveChanges();

                CreateIngredients();
                con.SaveChanges();

                CreateGlasses();
                con.SaveChanges();

                CreateDrinks();
      
                
                con.SaveChanges();
            }
        }

        private void CreateUnits()
        {
            //Units
            var ingredientUnit = new Unit() { UnitType = "ml" };
            var ingredientUnit2 = new Unit() { UnitType = "cl" };
            var ingredientUnit3 = new Unit() { UnitType = "Count" };
            var ingredientUnit4 = new Unit() { UnitType = "Slice" };

            con.Units.AddRange(new List<Unit>() { ingredientUnit, ingredientUnit2, ingredientUnit3, ingredientUnit4 });

        }

        private void CreateIngredientTypes()
        {
            //IngredientTypes 
            var ingredientType = new IngredientType() { IngredientTypeName = "Rom" };
            var ingredientType2 = new IngredientType() { IngredientTypeName = "Cola" };
            var ingredientType3 = new IngredientType() { IngredientTypeName = "Lime" };
            con.IngredientTypes.AddRange(new List<IngredientType>() { ingredientType, ingredientType2, ingredientType3 });

        }
        private void CreateIngredients()
        {
            //Ingredients
            var ingredient = new Ingredient()
                { IngredientAmount = 30, 
                    IngredientType = con.IngredientTypes.FirstOrDefault(x => x.IngredientTypeName == "Rom"),
                    Unit = con.Units.FirstOrDefault(x => x.UnitType == "ml") };
            var ingredient2 = new Ingredient()
                { IngredientAmount = 300, IngredientType = con.IngredientTypes.FirstOrDefault(x => x.IngredientTypeName == "Cola"), Unit = con.Units.FirstOrDefault(x => x.UnitType == "ml") };
            var ingredient3 = new Ingredient()
                { IngredientAmount = 1, IngredientType = con.IngredientTypes.FirstOrDefault(x => x.IngredientTypeName == "Lime"), Unit = con.Units.FirstOrDefault(x => x.UnitType == "slice") };
            con.Ingredients.AddRange(new List<Ingredient>() { ingredient, ingredient2, ingredient3 });

        }
        private void CreateGlasses()
        {
            //Glasses
            var glass = new DrinkGlass() { DrinkGlassName = "Tall" };
            var glass2 = new DrinkGlass() { DrinkGlassName = "Short and Fat" };

            con.Glasses.AddRange(new List<DrinkGlass>() { glass, glass2 });

        }
        private void CreateDrinks()
        {
            //Drinks
            con.Drinks.AddRange(new List<Drink>(){
                    new Drink()
                    {
                        DrinkIngredients = new List<Ingredient>()
                        {
                            //Gets an ingredient that has an amount of 30ml and is Rom.
                            con.Ingredients.FirstOrDefault(x => (x.IngredientAmount == 30 && 
                                                        x.Unit.UnitType == "ml") &&
                                                       x.IngredientType.IngredientTypeName == "Rom"),
                            //Gets an ingredient that has an amount of 300ml and is Cola.
                            con.Ingredients.FirstOrDefault(x => (x.IngredientAmount == 300 &&
                                                        x.Unit.UnitType == "ml") &&
                                                       x.IngredientType.IngredientTypeName == "Cola"),
                        },
                        DrinkGarnish = new List<Ingredient>()
                        {
                            //Gets the ingredient 1 slice of Lime.
                            con.Ingredients.FirstOrDefault(x=> x.IngredientAmount == 1 && 
                                                      x.Unit.UnitType == "slice" &&
                                                      x.IngredientType.IngredientTypeName == "Lime")
                        },
                        DrinkName = "Rom And Coke",
                        DrinkPrice = 40,
                        //Gets the tall glass.
                        DrinkGlass = con.Glasses.FirstOrDefault(x => x.DrinkGlassName == "Tall")
                    }
                });
        }
    }
}
