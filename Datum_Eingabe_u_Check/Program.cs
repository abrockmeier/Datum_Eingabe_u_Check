using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datum_Eingabe_u_Check
{
	class Program
	{
		static void Main(string[] args)
		{
			// -> String -> Integer "Tag, monat, jahr ;"
			// TODO:
		
			/*
			 *Prüfen von Gültigkeit:
			 * Tag, (1-31)
			 * Monat, (1-12)
			 * Jahr 1 <= Jahr < 9999
			 * Schaltjahr 
			 */
		
			//Var
			int tag = 0;
			int monat = 0;
			int jahr = 0;
			bool schalti = false;;
			bool loopBreak = false;
			bool validD = false;
			bool validM = false;
			bool validJ = false;
			

			while (loopBreak == false)

			{
				//E
				Console.WriteLine("Für die Eingabe des Tages bitte 'T' drücken: ");
				Console.WriteLine("Für die Eingabe des Monats bitte 'M' drücken: ");
				Console.WriteLine("Für die Eingabe des Jahres bitte 'J' drücken: ");
				ConsoleKeyInfo caseInput = Console.ReadKey(true);
				StringBuilder output = new StringBuilder(
				String.Format("Sie haben '{0}' gedrückt", caseInput.KeyChar));
				Console.WriteLine(output.ToString());

				switch (caseInput.Key)
				{
					case ConsoleKey.T:
						//Tag Überprüfung
						
						Console.WriteLine("Bitte den Tag eingeben:");
						tag = Convert.ToInt32(Console.ReadLine());
						if (((tag >= 1) || (tag <= 31)) == true)
						{
							// ?
						validD = true;
						loopBreak = true;
						}
						break;

					case ConsoleKey.M:
						//Monat Überprüfung
						
						Console.WriteLine("Bitte den Monat eingeben:");
						monat = Convert.ToInt32(Console.ReadLine());
						if (((monat >= 1) || (monat <= 12)) == true)
						{
							// ?
						validM = true;
						loopBreak = true;
						}
						break;

					case ConsoleKey.J:
						//Jahr Überprüfung
						
						Console.WriteLine("Bitte den Jahr eingeben:");
						jahr = Convert.ToInt32(Console.ReadLine());
						if (((jahr >= 1) || (jahr <= 9999)) == true)
						{
							// ?
						validJ = true;
						loopBreak = true;
						}
						break;
				}
				if (validD && validM && validJ)
				{
					//V
					if (jahr % 400 == 0 || !(jahr % 100 == 0) || jahr % 4 == 0 )
					{
					schalti = true;
					}

				}
				if ( !schalti && ( tag > 28))
					{
					Console.WriteLine("Der von ihnen eingegebene Tag ist nicht " +
					"vorhanden! (es ist kein Schaltjahr.))");
					}
				if (schalti)
				{
					
					// Korrektes Datum und Schaltjahr!
					Console.WriteLine("Das Datum {0}.{1}.{2} ist gültig und es ist" +
					" ein Schaltjahr!", tag, monat, jahr);
				}
				else
				{ 
					// Korrektes Datum (Kein Schaltjahr)!
					Console.WriteLine("Das Datum {0}.{1}.{2} ist gültig und es ist" +
					" kein Schaltjahr!", tag, monat, jahr);
				}
				

				//A
		
			}
			Console.Read();
			if (loopBreak == false)
			{
			Console.Clear();
			Console.WriteLine("\n");
			Console.WriteLine("Eingabe fehlerhaft. Bitte wiederholen! \n");
			}
		}
	}	
}
