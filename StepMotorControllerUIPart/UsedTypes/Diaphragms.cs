using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StepMotorControllerUIPart.UsedTypes
{
    public class Diaphragms
    {
        public readonly float d1;
        public readonly float d2;
        public readonly float d3;
        public readonly float d4;
        public readonly float d5;
        public readonly float d6;
        public readonly float d7;
        public readonly float d8;
        public readonly float d9;
        public readonly float d10;
        public readonly float d11;
        public readonly float d12;
        public readonly float d13;
        public readonly float d14;
        public readonly float d15;
        public readonly float d16;
        public readonly float d17;
        public readonly float d18;
        public readonly float d19;
        public readonly float d20;


        public Diaphragms(Dictionary<string, float> diaphragms)
        {
            this.d1 = diaphragms[Constans.d1];
            this.d2 = diaphragms[Constans.d2];
            this.d3 = diaphragms[Constans.d3];
            this.d4 = diaphragms[Constans.d4];
            this.d5 = diaphragms[Constans.d5];
            this.d6 = diaphragms[Constans.d6];
            this.d7 = diaphragms[Constans.d7];
            this.d8 = diaphragms[Constans.d8];
            this.d9 = diaphragms[Constans.d9];
            this.d10 = diaphragms[Constans.d10];
            this.d11 = diaphragms[Constans.d11];
            this.d12 = diaphragms[Constans.d12];
            this.d13 = diaphragms[Constans.d13];
            this.d14 = diaphragms[Constans.d14];
            this.d15 = diaphragms[Constans.d15];
            this.d16 = diaphragms[Constans.d16];
            this.d17 = diaphragms[Constans.d17];
            this.d18 = diaphragms[Constans.d18];
            this.d19 = diaphragms[Constans.d19];
            this.d20 = diaphragms[Constans.d20];
        }
    }
}
