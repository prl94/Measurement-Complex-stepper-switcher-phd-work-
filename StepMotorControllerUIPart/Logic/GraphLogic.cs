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
        

        public static PointPairList PrepareDataForGraph(List<MesureLatest> mesuresList)
        {
            int count = mesuresList.Count;

            double[] InormArray = new double[count];
            float[] DiaphragmasArray = new float[count];

            for (int i = 0; i < count; i++)
            {
              InormArray[0] = mesuresList[0].Inorm;
              DiaphragmasArray[0] =  mesuresList[0].Diaphragm;
            }

            double[] InormArrayComplete = new double[count];
            float[] DiaphragmasArrayComplete = new float[count];


            //todo logic for graph
            for (int i = 0; i < count; i++)
            {

            }



            // diaphragmas array
            DiaphragmasArrayComplete[0] = 0;
            float val = 0;

            for (int i = 0; i < count; i++)
            {
                if (i == count-1)
                {
                    break;
                }
                val += DiaphragmasArray[i];
                DiaphragmasArrayComplete[i + 1] = val;

            }




            return null;
        }
    }
}
