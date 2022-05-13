﻿using System;
using System.Collections.Generic;
using System.Text;

namespace PMP2
{
    class Pmp
    {
        //Stack for the sales of the company
        private double[] salesPmp = new double[11];
        private double[] prediction = new double[11];
        private String[] months = { "Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio", "Julio", "Agosto", "Septiembre",
            "Octubre", "Noviembre", "Diciembre" };
        //Variables for the calculation based on the weight of each month
        private double aux1;
        private double aux2;
        private double aux3;

        private double w1;
        private double w2;
        private double w3;

        //Constructor for Pmp class
        public Pmp(double[] sales, double ThirdPrevMonth, double SecondPrevMonth, double LastMonth) {
            salesPmp = sales;
            this.w1 = ThirdPrevMonth;
            this.w2 = SecondPrevMonth;
            this.w3 = LastMonth;
        }

        public void Calculate() {

            for (int i = 0; i < salesPmp.Length; i++)
            { 
                if (i == 0)
                {
                    aux1 = salesPmp[i];
                    
                }
                else if (i==1)
                {
                    aux2 = salesPmp[i];
                }
                else if (i==2)
                {
                    aux3 = salesPmp[i];
                }
            }


            for (int i = 0; i < prediction.Length; i++)
            {
                prediction[i] = ((aux1 * w1) + (aux2 * w2) + (aux3 * w3));
                Console.WriteLine("Predicción mes de " + months[i] +" es: "+prediction[i]);
            }
        }

    }
}
