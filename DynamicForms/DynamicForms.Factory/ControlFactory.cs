using DynamicForms.Core;
using System.Linq;

namespace DynamicForms.Factory
{
    public static class ControlFactory
    {
        public static NumericControl Create(QuantityType quantityType, string fullName, double? defaultValue = null, bool isReadonly = false)
        {
            return new NumericControl
            {
                FullName = fullName,
                InternalUnit = UnitsManager.GetUnits(quantityType).FirstOrDefault(),
                UserUnit = UnitsManager.GetUnits(quantityType).FirstOrDefault(),
                DefaultValue = defaultValue.HasValue ? defaultValue.Value : double.NaN,
                Units = UnitsManager.GetUnits(quantityType),
                IsReadonly = isReadonly
            };            
        }
    }
}
