using System.IO;

namespace Full_GRASP_And_SOLID
{
    public class FilePrinter : IPrinter
    {
        //Modificado por DIP
        public void PrintRecipe(IRecipe recipe)
        {
            File.WriteAllText("Recipe.txt", recipe.GetTextToPrint());
        }
    }
}