using System;

namespace Full_GRASP_And_SOLID
{
    public class ConsolePrinter : IPrinter
    {
        //Modificado por dip
        public void PrintRecipe(IRecipe recipe)
        {
            Console.WriteLine(recipe.GetTextToPrint());
        }
    }
}