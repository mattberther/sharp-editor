using System.Collections;

namespace SharpEd
{
	class CommandManager
	{
		private Stack commandStack = new Stack();

		public void ExecuteCommand(Command cmd)
		{
			cmd.Execute();
			if (cmd is UndoableCommand)
			{
				commandStack.Push(cmd);
			}
		}

		public void Undo()
		{
			if (commandStack.Count > 0)
			{
				UndoableCommand cmd = (UndoableCommand)commandStack.Pop();
				cmd.Undo();
			}
		}
	}
}
