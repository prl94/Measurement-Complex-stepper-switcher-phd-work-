using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using StepMotorControllerUIPart.DTO;

namespace StepMotorControllerUIPart.Helper
{
    class MathHelper
    {




        public static double CalculateDispersion(List<MesureDto> mesuresList)
        {
            return 1.2;
        }

       

        public double CalculateAvarageValue(List<MesureDto> mesuresList)
        {
            return 1.2;
        }
    //    private List<double> DivadingValues()
     //   {
      //      var divadingValues = new List<double>();
          //  int oCount = _oscillatorOutputList.Count;
         //   int sCount = _switcherOutputList.Count;

        //    if (oCount == sCount)
  //          {
        //        for (int i = 0; i < oCount; i++)
   //             {
   //      //           if (_switcherOutputList[i] != 0)
   //                 {
           //             divadingValues.Add(_switcherOutputList[i] / _oscillatorOutputList[i]);
    //                }
          //          else
          //          {
          //              divadingValues.Add(_switcherOutputList[i] / 0.001);
    //                }
    //            }
    //        }
        //    return divadingValues;
   //     }


    }
}
