using System.Collections.Generic;

namespace DynamicForms.Core
{
    public class FormModel
    {
        public string Name { get; set; }
        public bool IsSuccessfull { get; set; }
        public string Message { get; set; }
        public virtual List<ControlGroup> Groups { get; set; }

        public FormModel()
        {
            Groups = new List<ControlGroup>();
        }
        
    }
}
