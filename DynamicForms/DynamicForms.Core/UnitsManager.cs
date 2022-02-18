using System.Collections.Generic;

namespace DynamicForms.Core
{
    public static class UnitsManager
    {
        private static Dictionary<string, UnitDefinition> _unitsDicto = new Dictionary<string, UnitDefinition>();

        private static void InitializeUnits()
        {
            var meterUnit = new UnitDefinition("meter", "m", QuantityType.Length, 1, 0);
            var cmUnit = new UnitDefinition("centimeter", "cm", QuantityType.Length, 0.01, 0);
            var mmUnit = new UnitDefinition("millimeter", "mm", QuantityType.Length, 0.001, 0);
            var inchUnit = new UnitDefinition("inch", "in", QuantityType.Area, 0.0254, 0);
            var meter2Unit = new UnitDefinition("meter squared", "m2", QuantityType.Area, 1, 0);
            var cm2Unit = new UnitDefinition("centimeter squared", "cm2", QuantityType.Area, 0.0001, 0);
            var mm2Unit = new UnitDefinition("millimeter squared", "mm2", QuantityType.Area, 1e-6, 0);
            var inch2Unit = new UnitDefinition("inch squared", "in2", QuantityType.Area, 0.00064516, 0);

            _unitsDicto.Add("m", meterUnit);
            _unitsDicto.Add("cm", cmUnit);
            _unitsDicto.Add("mm", mmUnit);
            _unitsDicto.Add("in", inchUnit);
            _unitsDicto.Add("m2", meter2Unit);
            _unitsDicto.Add("cm2", cm2Unit);
            _unitsDicto.Add("mm2", mm2Unit);
            _unitsDicto.Add("in2", inch2Unit);
        }

        public static UnitDefinition GetUnit(string shortName)
        {
            if (_unitsDicto == null || _unitsDicto.Count == 0)
                InitializeUnits();

            UnitDefinition result = null;
            if (_unitsDicto.ContainsKey(shortName))
                _unitsDicto.TryGetValue(shortName, out result);

            return result;
        }

        public static List<UnitDefinition> GetUnits(QuantityType quantityType)
        {
            var units = new List<UnitDefinition>();
            foreach (var entry in _unitsDicto)
            {
                if (entry.Value.QuantityType == quantityType)
                    units.Add(entry.Value);
            }

            return units;
        }
    }
}
