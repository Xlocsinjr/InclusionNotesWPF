using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;

namespace InclusionNotesWPF;

internal class Program
{
	// --------------------------------------------------------------------------------------------------------------------------------

	/// <summary>The main entry point for the application. Set this in project properties -> Application -> Startup Object.</summary>
	/// <param name="args">The command line arguments passed to the application.</param>
	[STAThread]
	private static void Main(string[] args)
	{


		App application = new App();
		application.InitializeComponent();
		application.Run();
	}

	// --------------------------------------------------------------------------------------------------------------------------------
}