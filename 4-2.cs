using System;
using System.Collections.Generic; 
					
public class Program
{
	public static void Main()
	{
		List<string> languages = new List<string>{"HTML", "CSS", "Javascrit", "jQuery", "PHP", "BOOTSTRAP", "Java"};
		foreach(string a in languages) 
		{
			Console.WriteLine(a);
		}
		Console.WriteLine(languages[3]);
		Console.WriteLine(languages[4]);
		languages.Remove("BOOTSTRAP");
		languages[2] = "Javascript";
		foreach(string a in languages) 
		{
			Console.WriteLine(a);
		}
		
	}
}