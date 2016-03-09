using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using StepMotorControllerUIPart.DTO;

namespace StepMotorControllerUIPart.Helper
{
    class MathHelper
    {
        private readonly List<MesureDto> _mesures;

        public MathHelper(List<MesureDto> mesures)
        {
            _mesures = mesures;

        }

        public double IEfective()
        {
            return 1;
        }


        public List<CalculatedDataDto> getCalculatedData()
        {
            List<CalculatedDataDto> myMesures = new List<CalculatedDataDto>();
            foreach (var mesure in _mesures)
            {
                myMesures.Add(new CalculatedDataDto(
                    mesure.SwitcherPosition,
                    GetStandardDeviation(DivadingValues(mesure)),
                    DivadingValues(mesure).Average())
                    );
            }
            return myMesures;
        }

        private double GetStandardDeviation(double[] list)
        {
            double average = list.Average();
            double sumOfSquaresOfDifferences = list.Select(val => (val - average) * (val - average)).Sum();
            return Math.Sqrt(sumOfSquaresOfDifferences / list.Length);
        }

        private double[] DivadingValues(MesureDto mesure)
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
