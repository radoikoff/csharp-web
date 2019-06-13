using SIS.MvcFramework;

namespace MyPanda.Web
{
    public static class Program
    {
        static void Main()
        {
            WebHost.Start(new Startup());
        }
    }
}
