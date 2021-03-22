using PhotinoNET;
using System;
using System.Drawing;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using Photino.Blazor;

namespace LogNinja.UI
{
    public static class Program
    {
        [STAThread]
        private static void Main(string[] args)
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