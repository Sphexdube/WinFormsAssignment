using System;
using System.Collections.Generic;
using System.Windows.Forms;
using WinFormsAssignment.Models;

namespace WinFormsAssignment
{
  static class Program
  {
    //Global Variables
    public static List<Destination> listBoxItems;
    public static bool taxiSelected;

    /// <summary>
    /// The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main()
    {
      Application.EnableVisualStyles();
      Application.SetCompatibleTextRenderingDefault(false);
      Application.Run(new Form1());
    }
  }
}
