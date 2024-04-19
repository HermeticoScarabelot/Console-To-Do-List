using System.Collections.Generic;
public class Program
{
	
	enum UserChoice
	{
		addtask = 1,
		deletetask,	
		Exit
	}
	static void Main(string[] args)
	{
		List<string> toDoList = new List<string>();
		
		while(true)
		{
			if(toDoList.Count > 0)
			{
				Console.WriteLine("To-Do List: ");
				for(int i = 0; i < toDoList.Count; i++)
				{
					Console.WriteLine("- " + toDoList[i]);
				}
				Console.WriteLine("");
			} else
			{
				Console.WriteLine("You have no Task in your To-Do List");
				Console.WriteLine("");
			}
			
			
			//----------------------------
			
			Console.WriteLine("1. Add task");
			Console.WriteLine("2. Delete Task");
			Console.WriteLine("3. Exit");
			
			int choice = int.Parse(Console.ReadLine());
			if(choice == (int)UserChoice.addtask)
			{
				Console.WriteLine("Enter Task: ");
				string task = Console.ReadLine();
				toDoList.Add(task);
				Console.Clear();
				Console.WriteLine("Task was Added");
			} else if(choice ==(int)UserChoice.deletetask)
			{
				if(toDoList.Count > 0)
				{
					Console.WriteLine("Enter the number of the Task you would like to Delete");
					for (int i = 0; i < toDoList.Count; i++)
					{
						Console.WriteLine("(" + (i + 1) + ") " + toDoList[i]);
					}
					
					int taskNum = int.Parse(Console.ReadLine());
					taskNum--;
					
					if(taskNum > 0 && taskNum < toDoList.Count)
					{
						toDoList.RemoveAt(taskNum);
						Console.Clear();
						Console.WriteLine("Task was Deleted");
						Console.WriteLine("");
					} else
					{
						Console.Clear();
						Console.WriteLine("Invalid Task Number");
						Console.WriteLine("");
					}
				}
			} else if(choice == (int)UserChoice.Exit)
			{
				break;
			}
		}
	}
	
}