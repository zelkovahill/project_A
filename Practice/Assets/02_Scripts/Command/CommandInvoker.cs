using System.Collections.Generic;

namespace Command
{
    public class CommandInvoker
    {
        private static Stack<Command> s_UndoStack = new Stack<Command>();
        private static Stack<Command> s_RedoStack = new Stack<Command>();

        public static void ExecuteCommand(Command command)
        {
            command.Execute();
            s_UndoStack.Push(command);

            s_RedoStack.Clear();
        }

        public static void UndoCommand()
        {
            if (s_UndoStack.Count > 0)
            {
                Command activeCommand = s_UndoStack.Pop();
                s_RedoStack.Push(activeCommand);
                activeCommand.Undo();
            }
        }

        public static void RedoCommand()
        {
            if (s_RedoStack.Count > 0)
            {
                Command activeCommand = s_RedoStack.Pop();
                s_UndoStack.Push(activeCommand);
                activeCommand.Execute();
            }
        }
    }
}