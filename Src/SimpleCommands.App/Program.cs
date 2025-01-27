﻿using SimpleCommands.Core.Command.Infrastructure;

namespace SimpleCommands.App
{
    class Program
    {
        static void Main(string[] args)
        {
            var consoleOutput = new ConsoleOutput();
            var consoleInput = new ConsoleInput();
            var commandHandler = new CommandHandler(consoleOutput);

            var commandStreamProcessor =
                new CommandStreamProcessor(consoleInput, consoleOutput, commandHandler);

            commandStreamProcessor.ProcessCommands();
        }
    }
}
