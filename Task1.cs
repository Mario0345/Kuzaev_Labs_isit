using System;
using System.IO;



namespace Task_1
{

	public static class Task_1_var3
	{
		private static string initial_path_Task1 = "Task1_initial.txt";
		private static string second_path_Task1 = "Task1_second.txt";
		public static void Randomgen(int Size)// заполняем файл случайными числами от 0 до 99 
		{																			// количество задается аргументом Size
			using (var SW = new StreamWriter(initial_path_Task1))
			{ // using
				var random = new Random();
				for (int i = 0; i < Size; i++)
				{
					SW.WriteLine(random.Next(0, 100));
				}
			}
		}


	public static void mn_Divisible(double m, double n)
			{
			
				string[] records = File.ReadAllLines(initial_path_Task1);
				int[] unsorted = Array.ConvertAll<string, int>(records, new Converter<string, int>(i => int.Parse(i)));
				//выше конвертируем числа в инт формат и помещаем их в массив интов из файла
				List<int> filtered = new List<int>();
				foreach (var item in unsorted)
				{
					if(item % m == 0 && item % n !=0){
						filtered.Add(item);
					}
				}

				using (var SR = new StreamWriter(second_path_Task1))
			{
				foreach (var item in filtered)
				{
					SR.Write($"{item},"); //записываем отфильтрованные числа в новый файл
				}
			}

				// string str =string.Join(", ",filtered);
				// System.Console.WriteLine(str);
				
			}






	}





}