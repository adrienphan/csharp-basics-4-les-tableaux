using System;
					
public class Program
{
	public static void Main()
	{
		//Determiner un nouveau nombre entre 1 et 50
		var randomNumber = new Random().Next(1,50);
		int hiddenNumber = randomNumber; 
		Console.WriteLine("Tentez de trouver le nombre caché !");
		int attempt = Convert.ToInt32(Console.ReadLine());
		//Déterminer le resultat de la tentative
		while (attempt != hiddenNumber)
		{
			if (attempt > hiddenNumber)
			{
				Console.WriteLine("trop haut ! essaye encore");
			} else 
			{
				Console.WriteLine("trop bas ! essaye encore");
			}
			attempt = Convert.ToInt32(Console.ReadLine());
		}
		Console.WriteLine("Bravo !!");
		
	}
}