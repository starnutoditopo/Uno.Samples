﻿using GLib;
using System;
using Uno.UI.Runtime.Skia;

namespace DualScreenSample.Skia.Gtk
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ExceptionManager.UnhandledException += delegate (UnhandledExceptionArgs expArgs)
            {
                Console.WriteLine("GLIB UNHANDLED EXCEPTION" + expArgs.ExceptionObject.ToString());
                expArgs.ExitApplication = true;
            };

            var host = new GtkHost(() => new App());

            host.Run();
        }
    }
}
