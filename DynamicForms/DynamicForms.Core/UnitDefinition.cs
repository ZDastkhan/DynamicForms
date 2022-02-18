namespace DynamicForms.Core
{
    public class UnitDefinition
    {
        public long Id { get; set; }
        public QuantityType QuantityType { get; set; }
        public string ShortName { get; } //m , ft
        public string LongName { get; } //meter, foot
        public double A { get; }
        public double B { get; }        
                
        public UnitDefinition(string longName, string shortName, QuantityType quantityType, double a, double b)
        {
            QuantityType = quantityType;
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
