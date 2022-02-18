using DynamicForms.Core;
using System.Collections.Generic;

namespace DynamicForms.Factory.Calculations
{
    public class RectangeAreaCalculation : CalculationBase
    {
        public RectangeAreaCalculation()
        {
            CalculationType = CalculationType.CalculateRectangleArea;
            var lengthCtrl = ControlFactory.Create(QuantityType.Length, "Length", 10);
            var widthCtrl = ControlFactory.Create(QuantityType.Length, "Width", 8);
            var areaCtrl = ControlFactory.Create(QuantityType.Area, "Area", isReadonly: true);
            var inputGroup = new ControlGroup { Name = "Input", ValueControls = new List<NumericControl> { lengthCtrl, widthCtrl } };
            var outputGroup = new ControlGroup { Name = "Output", ValueControls = new List<NumericControl> { areaCtrl } };
            Groups = new List<ControlGroup> { inputGroup, outputGroup };
        }

        public override bool Calculate()
        {
            var lengthCtrl = GetNumericControl("Length");
            var widthCtrl = GetNumericControl("Width");
            var areaCtrl = GetNumericControl("Area");
            areaCtrl.Value = lengthCtrl.Value * widthCtrl.Value;
            IsSuccessfull = true;
            return true;
        }
    }
}
