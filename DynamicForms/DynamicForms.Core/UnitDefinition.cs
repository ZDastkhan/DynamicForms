﻿namespace DynamicForms.Core
{
    public class UnitDefinition
    {
        public long Id { get; set; }
        public string ShortName { get; } //m , ft
        public string LongName { get; } //meter, foot
        public double A { get; }
        public double B { get; }        
                
        public UnitDefinition(string longName, string shortName, double a, double b)
        {
            LongName = longName;
            ShortName = shortName;
            A = a;
            B = b;
        }

        public override string ToString()
        {
            return LongName;
        }
    }
}
