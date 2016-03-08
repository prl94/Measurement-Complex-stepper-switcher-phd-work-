using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;

namespace StepMotorControllerUIPart.Model
{
    class WritingToFile
    {
        public void WriteDataToFile(String fileName, List<Dimention> dimentions)
        {
            string length = "Відстань: ";
            string averageValue = "Середнє значення: ";
            string standartDeviation = "Середньоквадратичне відхилення: ";

            foreach (Dimention dimention in dimentions)
            {
                length += dimention.GetSwitcherPosition().ToString(CultureInfo.InvariantCulture) + ", ";
                averageValue += dimention.AverageValue().ToString(CultureInfo.InvariantCulture) + ", ";
                standartDeviation += dimention.StandardDeviation().ToString(CultureInfo.InvariantCulture) + ", ";
            }
            string[] lines = { length, averageValue, standartDeviation };
            System.IO.File.WriteAllLines(fileName + DateTime.Now.ToString("MM/dd/yyyy HH-mm-ss"), lines);
        }
    }
}
