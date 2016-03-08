using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using StepMotorControllerUIPart.Helper;

namespace StepMotorControllerUIPart
{
    class Dimention

    {
        private readonly int _switcherPosition;
        private readonly List<double> _oscillatorOutputList;
        private readonly List<double> _switcherOutputList;
        public static List<Dimention> Dimentions;
        public Dimention(int switcherPosition)
        {
            Random rnd = new Random();

            var oscillatorOutputTestList = new List<double>();
            var switcherOutputTestList = new List<double>();
            
            for (int i = 1; i <= 20; i++)
            {
                oscillatorOutputTestList.Add(rnd.NextDouble());
                switcherOutputTestList.Add(rnd.NextDouble());
            }
            _oscillatorOutputList = oscillatorOutputTestList;
            _switcherOutputList = switcherOutputTestList;
            _switcherPosition = switcherPosition;
        }

        public Dimention(List<double> oscillatorOutputList, List<double> switcherOutputList, int switcherPosition)
        {
            _oscillatorOutputList = oscillatorOutputList;
            _switcherOutputList = switcherOutputList;
            _switcherPosition = switcherPosition;
        }

        public static void AddDimentionToDimentionsList(Dimention dimention)
        {
            if (Dimentions == null)
            {
                Dimentions = new List<Dimention>();
                Dimentions.Add(dimention);
            }
            else
            {
                Dimentions.Add(dimention);
            }
        }

        public float GetSwitcherPosition()
        {
            return _switcherPosition;
        }

        public double AverageValue()
        {
            var reduction = DivadingValues();
            var totalValue = reduction.Sum();
            return totalValue / reduction.Count;
        }


        //TODO review this method
        public double StandardDeviation()
        {

            var divandingCount = DivadingValues().Count;
            
            double sum = 0;
           
            foreach (double value in DivadingValues())
            {
                sum += Math.Pow((value - AverageValue()), 2);
            }

            return Math.Sqrt(sum / divandingCount);
        }

        

        private List<double> DivadingValues()
        {
            var divadingValues = new List<double>();
            int oCount = _oscillatorOutputList.Count;
            int sCount = _switcherOutputList.Count;

            if (oCount == sCount)
            {
                for (int i = 0; i < oCount; i++)
                {
                    if (_switcherOutputList[i] != 0)
                    {
                        divadingValues.Add(_switcherOutputList[i] / _oscillatorOutputList[i]);
                    }
                    else
                    {
                        divadingValues.Add(_switcherOutputList[i] / 0.001);
                    }
                }
            }
            return divadingValues;
        }
    }
}
