using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StepMotorControllerUIPart.UsedTypes
{
    class Resistors
    {
        public readonly float R1;
        public readonly float R2;
        public readonly float R3;
        public readonly float R4;
        public readonly float R5;
        public readonly float R6;
        public readonly float R7;
        public readonly float R8;
        public readonly float R9;
        public readonly float R10;
        public readonly float R11;
        public readonly float R12;
        public readonly float R13;
        public readonly float R14;
        public readonly float R15;
        public readonly float R16;
        public readonly float R17;
        public readonly float R18;
        public readonly float R19;
        public readonly float R20;

        public Resistors(Dictionary<string, float> resistors )
        {
            R1 = resistors[Constans.R1];
            R2 = resistors[Constans.R2]; 
            R3 = resistors[Constans.R3];
            R4 = resistors[Constans.R4];
            R5 = resistors[Constans.R5];
            R6 = resistors[Constans.R6];
            R7 = resistors[Constans.R7];
            R8 = resistors[Constans.R8];
            R9 = resistors[Constans.R9];
            R10 = resistors[Constans.R10];
            R11 = resistors[Constans.R11];
            R12 = resistors[Constans.R12];
            R13 = resistors[Constans.R13];
            R14 = resistors[Constans.R14];
            R15 = resistors[Constans.R15];
            R16 = resistors[Constans.R16];
            R17 = resistors[Constans.R17];
            R18 = resistors[Constans.R18];
            R19 = resistors[Constans.R19];
            R20 = resistors[Constans.R20];
        }
    }
}
