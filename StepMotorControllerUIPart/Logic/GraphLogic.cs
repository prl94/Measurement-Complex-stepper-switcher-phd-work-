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
        public static PointPairList GetDataForGraph(List<MesureLatest> mesuresList)
        {
            int count = mesuresList.Count;
            double[] InormArray = new double[count];
            float[] DiaphragmasArray = new float[count];

            for (int i = 0; i < count; i++)
            {
                InormArray[0] = mesuresList[0].Inorm;
                DiaphragmasArray[0] = mesuresList[0].Diaphragm;
            }

            double[] InormArrayComplete = prepareCurrentArray(InormArray);
            float[] DiaphragmasArrayComplete = prepareDiaphragmArray(DiaphragmasArray);


            var pointPairList = new PointPairList();
            for (int i = 0; i < count; i++)
            {
                pointPairList.Add(InormArrayComplete[i] / InormArrayComplete[0], DiaphragmasArrayComplete[0]);
            }

            return pointPairList;
        }
        private static double[] prepareCurrentArray(double[] arr)
        {
            double[] InormArrayComplete = new double[arr.Length];

            InormArrayComplete[0] = arr.Sum();
            for (int i = 1; i < arr.Count(); i++)
            {
                InormArrayComplete[i] = arr.Skip(i).Sum();
            }
            return InormArrayComplete;
        }
        private static float[] prepareDiaphragmArray(float[] arr)
        {
            float[] DiaphragmasArrayComplete = new float[arr.Length];

            for (int i = 1; i < arr.Count(); i++)
            {
                DiaphragmasArrayComplete[i] = arr.Take(i).Sum();
            }
            return DiaphragmasArrayComplete;
        }
    }
}
