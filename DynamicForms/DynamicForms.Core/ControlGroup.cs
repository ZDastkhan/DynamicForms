using System.Collections.Generic;

namespace DynamicForms.Core
{
    public class ControlGroup
    {
        public string Name { get; set; }
        public string Id { get; set; }
        public int OrderIndex { get; set; }
        public string DisplayName { get; set; }
        public bool IsVisible { get; set; }
        public bool IsResult { get; set; }
        public virtual List<NumericValueControl> ValueControls { get; set; }
        public virtual List<OptionControl> OptionControls { get; set; }

        public ControlGroup()
        {
            ValueControls = new List<NumericValueControl>();
            OptionControls = new List<OptionControl>();
            IsVisible = true;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
