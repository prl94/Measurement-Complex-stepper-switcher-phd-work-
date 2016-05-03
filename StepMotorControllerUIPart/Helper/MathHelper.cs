using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using StepMotorControllerUIPart.UsedTypes;

namespace StepMotorControllerUIPart.Helper
{
    public  class MathHelper
    {

      /*  public List<CalculatedData> getCalculatedData()
        {
            List<CalculatedData> myMesures = new List<CalculatedData>();
            foreach (var mesure in _mesures)
            {
                myMesures.Add(new CalculatedData(
                    mesure.SwitcherPosition,
                    GetStandardDeviation(DivadingValues(mesure)),
                    DivadingValues(mesure).Average())
                    );
            }
            return myMesures;
        }*/

        public static double GetStandardDeviation(float[] list)
        {
            double average = list.Average();
            double sumOfSquaresOfDifferences = list.Select(val => (val - average) * (val - average)).Sum();
            return Math.Sqrt(sumOfSquaresOfDifferences / list.Length);
        }
        public static double GetAverage(float[] list)
        {
            return list.Average();
        }


        private double[] DivadingValues(MesureOld mesure)
           {
                double[] divadingValues = new double[mesure.DataFromOscillatorArray.Length];
                double[] dataFromOscillator = mesure.DataFromOscillatorArray;
                double[] dataFromSwircher = mesure.DataFromSwitcherArray;
                for (int i = 0; i < divadingValues.Length; i++)
                {
                    divadingValues[i] = dataFromSwircher[i]/dataFromOscillator[i];
                }
                return divadingValues;
           }


    }
}
