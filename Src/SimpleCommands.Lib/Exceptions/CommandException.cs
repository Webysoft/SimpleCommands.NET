﻿namespace SimpleCommands.Core.Exceptions
{
    public class CommandException : CoreException
    {
        public CommandException(string message = null) : base(message)
        {

        }
    }
}