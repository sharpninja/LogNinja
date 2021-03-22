using System;
using Photino.Blazor;

namespace LogNinja.UI
{
    public static class Program
    {
        [STAThread]
        private static void Main(string[] _)
        {
            ComponentsDesktop.Run<Startup>("LogNinja"
                , "wwwroot/index.html"
                , x: 450
                , y: 100
                , width: 1000
                , height: 900);
        }
    }
}