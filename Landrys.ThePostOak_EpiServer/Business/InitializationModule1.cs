using EPiServer.Framework;
using EPiServer.Framework.Initialization;
using System.Web;

namespace Landrys.ThePostOak_EpiServer.Business
{
    [InitializableModule]
    [ModuleDependency(typeof(EPiServer.Web.InitializationModule))]
    public class InitializationModule1 : IInitializableHttpModule
    {
        public void Initialize(InitializationEngine context)
        {
            //Add initialization logic, this method is called once after CMS has been initialized
        }

        public void Uninitialize(InitializationEngine context)
        {
            //Add uninitialization logic
        }

        public void InitializeHttpEvents(HttpApplication application)
        {
            //Add logic to listen to HTTP events, this method is called multiple times so don't add initialization
            //logic in this method.

            //application.BeginRequest += MyHandler;
        }

        //private static void MyHandler(object o, EventArgs e)
        //{

        //}
    }
}