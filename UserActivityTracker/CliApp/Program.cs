using Microsoft.Extensions.DependencyInjection;
using UserActivityTracker.Application.DependencyInjection;
using UserActivityTracker.Application.Services;
using UserActivityTracker.CliApp.Commands;
using UserActivityTracker.Infrastructure.DependencyInjection;

var services = new ServiceCollection();

//Adding infrastructure
services.AddInfrastructure();

//Adding services
services.AddApplication();

//Adding commands
services.AddTransient<GetUserEventsCommand>();

var provider = services.BuildServiceProvider();

var command = provider.GetRequiredService<GetUserEventsCommand>();

bool isRunning = true;

while (isRunning)
{
    Console.Write("Command: ");
    var input = Console.ReadLine();
    var argument = input.Split(" ");
    if (string.IsNullOrWhiteSpace(input) || argument[0] != "github-activity")
    {
        PrintHelp();
    }
    await command.ExecuteAsync(argument[1]);
}

static void PrintHelp()
{
    Console.WriteLine("Usage: UserActivityTrackerCli <command> [options]");
    Console.WriteLine("Commands:");
    Console.WriteLine("  github-activity <username> - Get user events from GitHub.");
    Console.WriteLine("Options:");
    Console.WriteLine("  <username> - GitHub username to fetch events for.");    
}


