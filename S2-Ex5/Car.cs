using System;
using System.Collections.Generic;

namespace S2_Ex5
{
    public class Car
    {
        public string Color;
        public double EngineSize;
        public int FuelEconomy;
        public bool IsManualShift;

        public Car(string color, double engineSize, int fuelEconomy, bool isManualShift)
        {
            Color = color;
            EngineSize = engineSize;
            FuelEconomy = fuelEconomy;
            IsManualShift = isManualShift;
        }

        public override string ToString()
        {
            string txt = "";
            string IsManual = IsManualShift ? "Manual" : "Automatic";
            txt += $"A {Color}, {EngineSize:F1}l engine, {IsManual} that consumes {FuelEconomy:F}l/100km";
            return txt;
        }
    }
}