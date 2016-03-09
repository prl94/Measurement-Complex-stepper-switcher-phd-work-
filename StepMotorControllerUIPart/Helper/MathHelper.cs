using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using StepMotorControllerUIPart.DTO;

namespace StepMotorControllerUIPart.Helper
{
    class MathHelper
    {
        private List<MesureDto> _mesures;

        public MathHelper(List<MesureDto> mesures)
        {
            _mesures = mesures;

        }

        private double getStandardDeviation(double[] list)
        {
            double average = list.Average();
            double sumOfSquaresOfDifferences = list.Select(val => (val - average) * (val - average)).Sum();
            return Math.Sqrt(sumOfSquaresOfDifferences / list.Length);
        }

            private double[] DivadingValues(MesureDto mesuresList)
           {
                double[] divadingValues = new double[mesuresList.DataFromOscillatorArray.Length];
                double[] dataFromOscillator = mesuresList.DataFromOscillatorArray;
                double[] dataFromSwircher = mesuresList.DataFromSwitcherArray;
                for (int i = 0; i < divadingValues.Length; i++)
                {
                    divadingValues[i] = dataFromSwircher[i]/dataFromOscillator[i];
                }
                return divadingValues;
           }


    }
}
