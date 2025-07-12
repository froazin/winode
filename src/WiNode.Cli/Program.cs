using Spectre.Console.Cli;
using WiNode.Cli.Commands;

namespace WiNode.Cli;

public static class Program
{
  public static int Main(string[] args)
  {
    var app = new CommandApp();
    app.Configure(config =>
    {
      config.SetApplicationName("winode");
      config.ValidateExamples();
      config.AddExample("list", "--online");
      config.AddExample("install", "22");
      config.AddExample("use", "22", "--default");

      config.SetApplicationVersion(GitVersionInformation.FullSemVer);

      config.AddCommand<InstallCommand>("install");
      config.AddCommand<ListCommand>("list");
      config.AddCommand<UninstallCommand>("uninstall");
      config.AddCommand<UpdateCommand>("update");
      config.AddCommand<UseCommand>("use");
    });

    return app.Run(args);
  }
}
