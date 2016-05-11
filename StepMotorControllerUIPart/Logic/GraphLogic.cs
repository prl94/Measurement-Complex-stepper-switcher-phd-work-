using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using StepMotorControllerUIPart.UsedTypes;
using ZedGraph;

namespace StepMotorControllerUIPart.Logic
{
    static class GraphLogic
    {
        public static PointPairList GetDataForGraph(List<Mesure> mesuresList)
        {
            int count = mesuresList.Count;
            double[] inormArray = new double[count];
            double[] diaphragmasArray = new double[count];

            for (int i = 0; i < count; i++)
            {
                inormArray[0] = mesuresList[0].Inorm;
                diaphragmasArray[0] = mesuresList[0].Diaphragm;
            }

            double[] inormArrayComplete = PrepareCurrentArray(inormArray);
            double[] diaphragmasArrayComplete = PrepareDiaphragmArray(diaphragmasArray);


            var pointPairList = new PointPairList();
            for (int i = 0; i < count; i++)
            {
                pointPairList.Add(inormArrayComplete[i] / inormArrayComplete[0], diaphragmasArrayComplete[0]);
            }

            return pointPairList;
        }
        private static double[] PrepareCurrentArray(double[] arr)
        {
            double[] inormArrayComplete = new double[arr.Length];

            inormArrayComplete[0] = arr.Sum();
            for (int i = 1; i < arr.Count(); i++)
            {
                inormArrayComplete[i] = arr.Skip(i).Sum();
            }
            return inormArrayComplete;
        }
        private static double[] PrepareDiaphragmArray(double[] arr)
        {
            double[] diaphragmasArrayComplete = new double[arr.Length];

            for (int i = 1; i < arr.Count(); i++)
            {
                diaphragmasArrayComplete[i] = arr.Take(i).Sum();
            }
            return diaphragmasArrayComplete;
        }
    }
}
