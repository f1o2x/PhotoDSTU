using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace CommonLibrary
{
    public abstract class ITool
    {
        protected string toolName { get; set; }

        public string ToolName
        {
            get { return toolName; }
        }

        protected List<ITool> subTools;
        public List<ITool> SubTools { get; }

        public abstract bool Action();
    }
}
