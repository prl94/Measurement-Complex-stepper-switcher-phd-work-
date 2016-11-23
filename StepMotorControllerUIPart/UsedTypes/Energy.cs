﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StepMotorControllerUIPart.UsedTypes
{
    public class Energy
    {
        public string Formula;
        public double Value;

        public Energy(string formula, double value)
        {
            Formula = formula;
            Value = value;
        }
    }
}
