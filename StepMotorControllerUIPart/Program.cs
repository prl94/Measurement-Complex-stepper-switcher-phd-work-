using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using StepMotorControllerUIPart.Helper;
using StepMotorControllerUIPart.Logic;
using StepMotorControllerUIPart.Properties;
using StepMotorControllerUIPart.SettingsFolder;
using StepMotorControllerUIPart.UsedTypes;
using StepMotorControllerUIPart.View;

namespace StepMotorControllerUIPart
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            var i = DiaphragmsStn.Default.Properties["D1"];


            double[] xV = {0,0.052999999,0.105999999,0.200999998, 0.295999996,0.48399999, 0.671999983, 0.859999977, 1.047999971, 1.235999964, 1.423999958, 1.611999951,
1.799999945,
1.987999938,
2.175999932,
2.363999926,
2.551999919,
2.739999913,
2.927999906,
3.1159999
};
            double[] yV = {1,
0.953624921,
0.902108917,
0.850110129,
0.797251482,
0.740856968,
0.694353742,
0.643481034,
0.597720818,
0.54536602,
0.503472496,
0.45399683,
0.405885866,
0.354604981,
0.3024869,
0.246092386,
0.195277086,
0.143724983,
0.097964767,
0.04635667
};

            LinearRegression lr = new LinearRegression(xV, yV);

            Console.WriteLine("a = {0}",lr.a);
            Console.WriteLine("b = {0}", lr.b);



            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
           Application.Run(new GeneralView());
        }
    }
}
