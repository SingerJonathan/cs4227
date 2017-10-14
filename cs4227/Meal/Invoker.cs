using System;

namespace cs4227.Meal
{
    class Invoker
    {
        Command command;

        public void setCommand(Command command)
        {
            this.command = command;
        }

        public void Invoke()
        {
            command.Execute();
        }
    }
}
