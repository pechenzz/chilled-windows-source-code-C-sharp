// Decompiled with JetBrains decompiler
// Type: ChilledWindows.App
// Assembly: ChilledWindows, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 03DD8084-1A47-4020-BB07-7BF62B11EC5F
// Assembly location: C:\Users\nuk\Desktop\ChilledWindows.exe

using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Windows;

namespace ChilledWindows
{
  public class App : Application
  {
    [DebuggerNonUserCode]
    [GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
    public void InitializeComponent()
    {
      this.StartupUri = new Uri("MainWindow.xaml", UriKind.Relative);
    }

    [STAThread]
    [DebuggerNonUserCode]
    [GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
    public static void Main()
    {
      App app = new App();
      app.InitializeComponent();
      app.Run();
    }
  }
}
