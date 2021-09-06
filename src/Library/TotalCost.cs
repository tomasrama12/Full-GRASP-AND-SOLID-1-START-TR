using System;
using System.Collections;

namespace Full_GRASP_And_SOLID.Library
{
    public class TotalCost
    {
        public static double costoTotal = 0;
        public static double calcularTotal(Recipe recipe)
        {
            //public double costoTotal = 0;
            foreach (Step item in recipe.steps)
            {
                costoTotal = costoTotal + item.CostoInsumos + item.CostoEquipamento;
            }
            Console.WriteLine(costoTotal);

            return costoTotal;
        }
        
    }
}