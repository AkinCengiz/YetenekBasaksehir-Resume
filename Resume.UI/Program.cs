using Autofac;
using Microsoft.Extensions.DependencyInjection;
using Resume.Business.Abstract;
using Resume.Business.DependencyInjection.AutoFac;

namespace Resume.UI;

internal static class Program
{
	/// <summary>
	///  The main entry point for the application.
	/// </summary>
	[STAThread]
	static void Main()
	{
		// To customize application configuration such as set high DPI settings or default font,
		// see https://aka.ms/applicationconfiguration.
		//var builder = new ContainerBuilder();
		//builder.RegisterModule(new AutofacBusinessModule());
		ApplicationConfiguration.Initialize();
		Application.Run(new MainForm());
	}
}