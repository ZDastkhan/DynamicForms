using System.Collections.Generic;

namespace DynamicForms.Core
{
    public class OptionControl
    {
        public string Id { get; set; }
        public int OrderIndex { get; set; }
        public string FullName { get; set; }
        public string ShortName { get; set; }
        public string Tooltip { get; set; }
        public string SelectedIndex { get; set; }
        public string SelectedValue { get; set; }
        public int DefaultSelectedIndex { get; set; }
        public bool IsReadOnly { get; set; }
        public virtual List<string> Options { get; set; }

        public OptionControl()
        {
            Options = new List<string>();
        }

        public override string ToString()
        {
            return FullName;
        }
    }
}
