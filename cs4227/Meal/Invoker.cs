using System;

namespace cs4227.Meal
{
    class Invoker
    {
        private Command command;

        public Command Command
        {
            set { command = value; }
        }

        public void Invoke()
        {
            command.Execute();
        }
    }
}
