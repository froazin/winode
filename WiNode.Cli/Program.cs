using Spectre.Console.Cli;

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
    });

    return app.Run(args);
  }
}
