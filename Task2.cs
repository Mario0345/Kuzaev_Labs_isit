using System;
using System.IO;


namespace Task_2
{

	public static class Task2_var3
	{
		private static string initial_path_Task2 = "Task2_initial.txt";
		private static string second_path_Task2 = "Task2_second.txt";

		public static void Randomgen(int Size)
		{
			using (var SW = new StreamWriter(initial_path_Task2))
			{
				var random = new Random();
				for (int i = 0; i < Size; i++)
				{
					SW.WriteLine(random.Next(0, 100));
				}
			}
		}


		public static void nXn()
		{

			string[] records = File.ReadAllLines(initial_path_Task2);
			int[] unsorted = Array.ConvertAll<string, int>(records, new Converter<string, int>(i => int.Parse(i)));
			while (true)
			{
				double root = Math.Sqrt(unsorted.Length);
				if ((root % 1 == 0) && root >= Int32.MinValue && root <= Int32.MaxValue )
				{
					System.Console.WriteLine("integer");
					break;
				}
				else
				{
					System.Console.WriteLine("real");
					Array.Resize(ref unsorted, unsorted.Length + 1); //увеличиваем массив на 1 если корень(root) нельзя конвертировать в целое число, пока root не станет конвертируемым 

				}
		
			}
			int root2 = Convert.ToInt32(Math.Sqrt(unsorted.Length));
			System.Console.WriteLine(root2);
			// int elems_inArr = root2 * root2;
			double[,] nxn_arr = new double[root2,root2];
			double[,] nxn_arr2 = new double[root2,root2];
			int counter = -1;
			for (int i = 0; i < root2; i++)
			{	
				System.Console.WriteLine();
				for (int h = 0; h < root2; h++)
				{
					counter++;
					nxn_arr[i,h] = unsorted[counter];
					System.Console.Write($"{nxn_arr[i,h]},");
				}
			}
			System.Console.WriteLine();
			System.Console.WriteLine("------------------------------------------");
			System.Console.WriteLine("Минимальный элемент в каждой строке: \n");
			int counter2 = -1;
			List<int> temp_list = new List<int>();
			
			for (int p = 0; p < root2; p++)
			{	
				System.Console.WriteLine();
				for (int u = 0; u < root2; u++)
				{
					counter2++;
					temp_list.Add(unsorted[counter2]);
					
				}
				int min = temp_list.Min();
				nxn_arr2[p,0] = min;
				temp_list.Clear();
				System.Console.Write($"{nxn_arr2[p,0]},");
			}

		}

		






	}














}