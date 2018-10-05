using CommonLibrary;
using System.Collections.Generic;

namespace Skeleton
{
    public class MainController
    {
        private MainWindow mainWindow;
        private static MainController application;
        public static MainController Application
        {
            get
            {
                if (application == null)
                    application = new MainController();
                return application;
            }
        }

        public bool Initialize(MainWindow window)
        {
            mainWindow = window;
            RegisterTool(new File());

            return true;
        }

        public bool RegisterTool(ITool command)
        {

            //call some mainwindow funcs to add menu
            
            return true;
        }

        public bool UnregisterTool(ITool command)
        {
            return true;
        }
    }
}
