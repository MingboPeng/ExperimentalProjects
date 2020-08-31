using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Windows;
using System.Windows.Controls;
using Microsoft.Web.WebView2.Wpf;
using Rhino;
using Rhino.Commands;
using Rhino.Geometry;
using Rhino.Input;
using Rhino.Input.Custom;
using Rhino.UI;
using RhinoWindows;

namespace RhinoWebView2
{

    public class RhinoWebView2Command : Command
    {
        public RhinoWebView2Command()
        {
            Instance = this;
        }

        ///<summary>The only instance of this command.</summary>
        public static RhinoWebView2Command Instance { get; private set; }

        public override string EnglishName => "RhinoWebView2Command";

        protected override Result RunCommand(RhinoDoc doc, RunMode mode)
        {
            var dialog = new SampleCsWpf.Views.SampleCsWpfDialog();
            dialog.ShowSemiModal(RhinoApp.MainWindowHandle());

            return Result.Success;
        }
    }

   
}
