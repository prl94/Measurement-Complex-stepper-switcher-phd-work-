using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using StepMotorControllerUIPart.DTO;
using StepMotorControllerUIPart.SerialPortController;
using ZedGraph;

namespace StepMotorControllerUIPart.Controller
{
    class GlobalController
    {

        public static Dictionary<int, double> StartMesures(ParametersDto parameters)
        {

            var testData = ComPortController.CatchDataFromADTs(parameters.StepsCount, 20);

            foreach (var mesure in testData)
            {
                Console.WriteLine(mesure.SwitcherPosition);
                Console.WriteLine(mesure.DataFromOscillatorArray[0]);
                Console.WriteLine(mesure.DataFromSwitcherArray[0]);
            }
            Console.WriteLine(testData.Count);

            return null;
        }

        private PointPairList GraphPointsGenerator(Dictionary<double, double> lineArray)
        {
            var pointList = new PointPairList();

            foreach (var point in lineArray)
            {
                pointList.Add(point.Key, point.Value);

            }
            return pointList;
        }
    }
}
