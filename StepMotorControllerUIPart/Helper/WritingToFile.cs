using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using StepMotorControllerUIPart.UsedTypes;

namespace StepMotorControllerUIPart.Helper
{
    public class WritingToFile
    {

        public static void WriteMesure_MyToFile(List<Mesure> mesures)
        {

            String fileName = ("Виміри " + DateTime.Now.ToString("MM/dd/yyyy HH-mm-ss") + ".txt");
            StreamWriter writer = new StreamWriter(fileName);

            // Display header
            string header = String.Format("{0,-4}{1,-25}{2,-25}{3,-25}{4,-25}{5,-25}{6,-25}\n",
                "#", "U_SEM ", "StDev_SEM", "U_Channel1", "StDev_Ch1", "U_Channel2", "StDev_Ch2");
            writer.WriteLine(header);

            StringBuilder sb = new StringBuilder();

            foreach (var mesure in mesures)
            {
                writer.Write("{0,-4}{1,-25}{2,-25}{3,-25}{4,-25}{5,-25}{6,-25}{7}",
                    mesure.MesureNumber, MathHelper.GetAverage(mesure.USecondaryEmmisionMonitor), MathHelper.GetStandardDeviation(mesure.USecondaryEmmisionMonitor),
                    MathHelper.GetAverage(mesure.UChannel1), MathHelper.GetStandardDeviation(mesure.UChannel1),
                    MathHelper.GetAverage(mesure.UChannel2), MathHelper.GetStandardDeviation(mesure.UChannel2), Environment.NewLine);
                
            }

            writer.WriteLine(sb.ToString());
            writer.Close();

        }




        public static void WriteDataToFile(String fileName, List<CalculatedData> dimentions, double iEfective)
        {
            string length = "Крок: ";
            string averageValue = "Середнє значення: ";
            string standartDeviation = "Дисперсія: ";
            string effective = "Середнє ефективне: ";

            foreach (var dim in dimentions)
            {
                length += dim.SwitcherPosition.ToString(CultureInfo.InvariantCulture) + ", ";
                averageValue += dim.AverageValue.ToString(CultureInfo.InvariantCulture) + ", ";
                standartDeviation += dim.Dispersion.ToString(CultureInfo.InvariantCulture) + ", ";
            }
            effective += iEfective;
            string[] lines = {length, averageValue, standartDeviation, effective};
            System.IO.File.WriteAllLines(fileName + DateTime.Now.ToString("MM/dd/yyyy HH-mm-ss"), lines);

        }
        public static void Writer()
        {


            String fileName = ("Виміри " + DateTime.Now.ToString("MM/dd/yyyy HH-mm-ss")+".txt");
            StreamWriter writer = new StreamWriter(fileName);

            Tuple<string, DateTime, int, DateTime, int>[] cities =
            {
                Tuple.Create("Los Angeles", new DateTime(1940, 1, 1), 1504277,
                    new DateTime(1950, 1, 1), 1970358),
                Tuple.Create("New York", new DateTime(1940, 1, 1), 7454995,
                    new DateTime(1950, 1, 1), 7891957),
                Tuple.Create("Chicago", new DateTime(1940, 1, 1), 3396808,
                    new DateTime(1950, 1, 1), 3620962),
                Tuple.Create("Detroit", new DateTime(1940, 1, 1), 1623452,
                    new DateTime(1950, 1, 1), 1849568)
            };

            // Display header
            string header = String.Format("{0,-12}{1,-8}{2,-12}{1,-8}{2,-12}{3,-14}\n",
                "№ Діафрагми ", "U, V мон. втор емісії ", "Population", "Change (%)");
            //Console.WriteLine(header);
            writer.WriteLine(header);
            string output;

            StringBuilder sb = new StringBuilder();

            foreach (var city in cities)
            {
                writer.Write("{0,-12}{1,-8:yyyy}{2,-12:N0}{3,-8:yyyy}{4,-12:N0}{5,-14:P1}{6}",
                    city.Item1, city.Item2, city.Item3, city.Item4, city.Item5,
                    (city.Item5 - city.Item3)/city.Item3*1.0, Environment.NewLine);




            }
             writer.WriteLine(sb.ToString());
            writer.Close();
        }
    }
}
