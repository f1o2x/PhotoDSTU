using System.Collections.Generic;
using CommonLibrary;
using Skeleton;

namespace Base
{
    class ToolsetController: ITool
    {
        public ToolsetController()
        {
            toolName = "Base Tools";
            subTools = new List<ITool>();
        }

        public bool Register()
        {
            Unregister();

            subTools.Add(new Brightness());
            subTools.Add(new Gray());
            subTools.Add(new Mirror());
            subTools.Add(new Philters());
            subTools.Add(new Resize());
            subTools.Add(new Rotate());
            subTools.Add(new SwitchChannels());

            MainController.Application.RegisterTool(this);
            return true;
        }

        public bool Unregister()
        {
            MainController.Application.UnregisterTool(this);
            return true;
        }
    }
}
