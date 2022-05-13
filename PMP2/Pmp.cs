using System;
using System.Collections.Generic;
using System.Text;

namespace PMP2
{
    class Pmp
    {
        //Array for the sales of the company
        private double[] salesPmp = new double[12];

        //Array for the values of the prediction
        private double[] prediction = new double[12];

        //Array with the names of each month
        private String[] months = {"Abril", "Mayo", "Junio", "Julio", "Agosto", "Septiembre",
            "Octubre", "Noviembre", "Diciembre",  "Enero", "Febrero", "Marzo" };

        //Variables for the calculation based on the weight of each month
        private double aux1;
        private double aux2;
        private double aux3;

        //Variables for the weight of each month
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

        //Get for the results of the prediction
        public double[] Prediction { get => prediction; }

        //Get & Set for the sales
        public double[] SalesPmp { get => salesPmp; set => salesPmp = value; }

        //Get & Set for the weight of the third previous month
        public double W1 { get => w1; set => w1 = value; }

        //Get & Set for the weight of the Second previous month
        public double W2 { get => w2; set => w2 = value; }

        //Get & Set for the weight of the last month
        public double W3 { get => w3; set => w3 = value; }


        //Method which shows the predictions for the model
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
