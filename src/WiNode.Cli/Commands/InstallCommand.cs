using System.ComponentModel;
using Spectre.Console.Cli;

namespace WiNode.Cli.Commands;

[Description("Install a specific version of Node.js")]
public class InstallCommand : Command<InstallCommand.Settings>
{
  public class Settings : CommandSettings
  {
    [CommandArgument(0, "<VERSION>")]
    [Description("The version of Node.js to install. This must be a full or partial version number (e.g., '22', '20.1', '22.1.0').")]
    public string? Version { get; set; }

    [CommandOption("-d|--default")]
    [Description("Install the specified version as the default version.")]
    public bool? Default { get; set; }

    [CommandOption("-f|--force")]
    [Description("Force the installation, even if the version is already installed. Use with caution.")]
    public bool? Force { get; set; }
  }

  public override int Execute(CommandContext context, Settings settings)
  {
    throw new NotImplementedException("This command is not yet implemented.");
  }
}
