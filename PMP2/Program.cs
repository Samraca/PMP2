using System;

namespace PMP2
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] ventas = { 10, 12, 13, 16, 19, 23, 26, 30, 28, 18, 16, 14 };
            
            Pmp nuevaPrediccion = new Pmp(ventas,0.2,0.3,0.5);

            nuevaPrediccion.Calculate();

            
           
        }
    }
}
