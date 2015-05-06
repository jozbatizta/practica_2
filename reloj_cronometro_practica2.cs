using System;
using System.Timers;
using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;
//using System.Text;
using System.Text;
using System.Threading;
 




namespace Practica2_RelojYCronometro
{
	class MainClass
	{
		
		static void Cronometro(){
					ConsoleKeyInfo cki;
					int min;
					int seg;
					int hor;
					int mili;
					Console.WriteLine("\t\tCronometro\t");
			do{
					cki = Console.ReadKey();
				for(hor=0;hor < 24; hor++){
					for (min=0;min<60;min++) {
						for (seg=0; seg<60; seg++){
								for(mili =0;mili<100;mili++){
									//Console.SetCursorPosition(5,50);
								Console.Clear();
								Console.WriteLine(""+hor+":"+min+":"+seg+":"+mili);
								Thread.Sleep(10);
								
								}
								
						}
					}
		
				}
			} while (cki.Key != ConsoleKey.Enter);
		}
		
		static void Reloj(){
					
					int min;
					int seg;
					int hor;
					
					DateTime reloj = DateTime.Now ;
					for(hor=reloj.Hour;hor < 24; hor++){
						for (min=reloj.Minute;min<60;min++) {
							for (seg = reloj.Second ; seg<60; seg++){
								
								Console.Clear();
								Console.WriteLine(""+hor+":"+min+":"+seg);
								Thread.Sleep(1000);
								
								
								
						}
					}
		
				}
			
		}
		
		public static void Main (string[] args)
		{
			int menu;
				Console.WriteLine ("\nIngresa La Opcion Segun Deses\n");
				Console.WriteLine("\n\t1.-Cronometro\n\t2.-Reloj\n\t3.-Salir");

				menu=int.Parse(Console.ReadLine());
				switch (menu) {
			case 1 :
						Cronometro();
				




					break;

				case 2 :
					Reloj();
					
					
					break;
				}

			

		}
	}
}