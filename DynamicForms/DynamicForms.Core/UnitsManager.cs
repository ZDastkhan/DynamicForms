using System.Collections.Generic;

namespace DynamicForms.Core
{
    public static class UnitsManager
    {
        private static Dictionary<string, UnitDefinition> _units = new Dictionary<string, UnitDefinition>();

        private static void InitializeUnits()
        {
            var meterUnit = new UnitDefinition("meter", "m", 1, 0);
            var cmUnit = new UnitDefinition("centimeter", "cm", 0.01, 0);
            var mmUnit = new UnitDefinition("millimeter", "mm", 0.001, 0);
            var inchUnit = new UnitDefinition("inch", "in", 0.0254, 0);
            var meter2Unit = new UnitDefinition("meter squared", "m2", 1, 0);
            var cm2Unit = new UnitDefinition("centimeter squared", "cm2", 0.0001, 0);
            var mm2Unit = new UnitDefinition("millimeter squared", "mm2", 1e-6, 0);
            var inch2Unit = new UnitDefinition("inch squared", "in2", 0.00064516, 0);

            _units.Add("m", meterUnit);
            _units.Add("cm", cmUnit);
            _units.Add("mm", mmUnit);
            _units.Add("in", inchUnit);
            _units.Add("m2", meter2Unit);
            _units.Add("cm2", cm2Unit);
            _units.Add("mm2", mm2Unit);
            _units.Add("in2", inch2Unit);
        }

        public static UnitDefinition GetUnit(string shortName)
        {
            if (_units == null || _units.Count == 0)
                InitializeUnits();

            UnitDefinition result = null;
            if (_units.ContainsKey(shortName))
                _units.TryGetValue(shortName, out result);

            return result;
        }
    }
}
