using DynamicForms.Core;
using System;
using System.Collections.Generic;

namespace DynamicForms.Factory
{
    public static class FormFactory
    {
        public static FormModel CreateFormModel(CalculationType calculationType)
        {
            
            //temp solution
            if (calculationType == CalculationType.CalculateCircleArea)
            {
                var radiusControl = new NumericValueControl
                {
                    ShortName = "R",
                    FullName = "Radius",
                    InternalUnit = UnitsManager.GetUnit("m"),
                    UserUnit = UnitsManager.GetUnit("cm"),
                    DefaultValue = 10,
                    Units = new List<UnitDefinition> { UnitsManager.GetUnit("m"), UnitsManager.GetUnit("cm"), UnitsManager.GetUnit("in"), UnitsManager.GetUnit("mm") }
                };

                var areaControl = new NumericValueControl
                {
                    ShortName = "A",
                    FullName = "Area",
                    InternalUnit = UnitsManager.GetUnit("m2"),
                    UserUnit = UnitsManager.GetUnit("cm2"),
                    IsReadonly = true,
                    Units = new List<UnitDefinition> { UnitsManager.GetUnit("m2"), UnitsManager.GetUnit("cm2"), UnitsManager.GetUnit("in2"), UnitsManager.GetUnit("mm2") }
                };

                var inG = new ControlGroup { Name="Input", ValueControls = new List<NumericValueControl> { radiusControl} };
                var outG = new ControlGroup { Name = "Output", ValueControls = new List<NumericValueControl> { areaControl } };

                var fc = new FormModel();
                fc.Groups = new List<ControlGroup> { inG, outG };
                return fc;
            }

            return null;
        }
    }
}
