using System;
namespace baseClass;

public class ProgramBase
{
	public ProgramBase()
	{
		//the class constructor
	}

	//a method that can be derived from to print strings to the console
	public virtual void Print(String message) 
	{
		Console.WriteLine(message);
	}
	public virtual void Print() 
	{
        Console.WriteLine("message");
    }
}
