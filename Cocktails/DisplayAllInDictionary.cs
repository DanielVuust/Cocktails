using Cocktails.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cocktails
{
    public class DisplayAllInDictionary
    {
        public void Display(Dictionary<string, IDrinkDataAction> IDrinkDataActionDictionary)
        {
            for (int i = 0;i < IDrinkDataActionDictionary.Count;i++)
            {
                Console.WriteLine(i + ". " + IDrinkDataActionDictionary.ElementAt(i).Key);
            }
        }
    }
}
