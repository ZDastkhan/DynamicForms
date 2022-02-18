using DynamicForms.Core;
using System;
using System.Collections.Generic;

namespace DynamicForms.Factory
{
    public class CircleAreaCalculation : CalculationBase
    {       
        public CircleAreaCalculation()
        {
            CalculationType = CalculationType.CalculateCircleArea;
            var radiusCtrl = ControlFactory.Create(QuantityType.Length, "Radius", 10);
            var areaCtrl = ControlFactory.Create(QuantityType.Area, "Area", isReadonly:true);
            var inputGroup = new ControlGroup { Name = "Input", ValueControls = new List<NumericControl> { radiusCtrl } };
            var outputGroup = new ControlGroup { Name = "Output", ValueControls = new List<NumericControl> { areaCtrl } };
            Groups = new List<ControlGroup> { inputGroup, outputGroup };
        }

        public override bool Calculate()
        {
            var radiusCtrl = GetNumericControl("Radius");
            var areaCtrl = GetNumericControl("Area");
            areaCtrl.Value = Math.PI * radiusCtrl.Value * radiusCtrl.Value;
            IsSuccessfull = true;
            return true;
        }
    }
}
