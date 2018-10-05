using CommonLibrary;
using System.Collections.Generic;

namespace Skeleton
{
    public class File : ITool
    {
        public File()
        {
            toolName = "File";
            subTools = new List<ITool>();
            subTools.Add(new Load());
            subTools.Add(new Save());
            subTools.Add(new SaveAs());
            subTools.Add(new Exit());
        }

        public override bool Action()
        {
            return true;
        }

    }

    public class Load : ITool
    {
        public Load()
        {
            toolName = "Load";
            subTools = new List<ITool>();
        }

        public override bool Action()
        {
            return true;
        }
    }
    public class Save: ITool
    {
        public Save()
        {
            toolName = "Save";
            subTools = new List<ITool>();
        }

        public override bool Action()
        {
            return true;
        }
    }
    public class SaveAs : ITool
    {
        public SaveAs()
        {
            toolName = "SaveAs";
            subTools = new List<ITool>();
        }

        public override bool Action()
        {
            return true;
        }
    }
    public class Exit : ITool
    {
        public Exit()
        {
            toolName = "Exit";
            subTools = new List<ITool>();
        }

        public override bool Action()
        {
            return true;
        }
    }
}
