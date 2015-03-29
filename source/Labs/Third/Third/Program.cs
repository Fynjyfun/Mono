//Лаба №7
//Найти минимальный из максимальных элементов строк двумерного массива

using System;

namespace Third
{
	/// <summary>
	/// Main class - основной класс программы
	/// для поиска минимального из максимальных
	/// элементов строк двумерного массива
	/// </summary>

	class MainClass
	{
		/// <summary>
		/// Точка входа программы, основной метод.
		/// </summary>
		/// <param name="args">Аргументы для запуска в командной строке(терминале)</param>

		public static void Main (string[] args)
		{
			//Константы
			const int MAX_StrCount = 10; //Максимальное количество строк
			const int MAX_ColumnCount = 10;	//Максимальное количество столбцов

			//Объявление переменных
			int StrCount, ColumnCount;	//Количество строк и столбцов
			int i, j;	//Счетчики итераций циклов
			Random rnd = new Random ();	//Генератор случайных чисел
			int MinMax;	//Минимальный из максимумов по строкам

			#region Ввод размера матрицы
			Console.WriteLine ("\nВведите количество строк матрицы. (не больше " + MAX_StrCount + ")");

			do 
			{
				//Добавить проверку на допустимые символы (только цифры)
				// А еще диалог о том, не хотите ли выйти из программы, если неверно указали размер матрицы
				StrCount = int.Parse (Console.ReadLine());

				if (StrCount <= 0 || StrCount > MAX_StrCount) 
				{
					Console.WriteLine ("Некорректное значение размера матрицы! Попробуйте ввести еще раз.");
				}

			}
			while (StrCount <= 0 || StrCount > MAX_StrCount);

			//Эхо-печать введенного количества строк
			Console.Write ("StrCount = " + StrCount + "\n\n");


			Console.WriteLine ("\nВведите количество столбцов матрицы. (не больше " + MAX_ColumnCount + ")");

			do 
			{
				//Добавить проверку на допустимые символы (только цифры)
				// А еще диалог о том, не хотите ли выйти из программы, если неверно указали размер матрицы
				ColumnCount = int.Parse (Console.ReadLine());

				if (ColumnCount <= 0 || ColumnCount > MAX_ColumnCount) 
				{
					Console.WriteLine ("Некорректное значение размера матрицы! Попробуйте ввести еще раз.");
				}

			}
			while (ColumnCount <= 0 || ColumnCount > MAX_ColumnCount);

			//Эхо-печать введенного количества столбцов
			Console.Write ("ColumnCount = " + ColumnCount + "\n\n");


			#endregion

			//Динамическое выделение памяти под исходный массив
			int[,] Array = new int[StrCount, ColumnCount];

			Console.WriteLine ("Исходный массив:");

			#region Генерация элементов массива и эхо - печать
			for (i = 0; i < StrCount; i++)
			{
				for (j = 0; j < ColumnCount; j++) 
				{
					Array[i, j] = rnd.Next(1, 100);
					Console.Write (Array [i, j] + " ");
				}
				Console.WriteLine ();
			}
			#endregion

			int[] ArrayMinMax = new int[StrCount];	//Массив для запоминания максимумов по строкам для дальнейшего поиска минимума


			#region Min_Max по строкам

			//Поиск максимумов по строкам
			for (i = 0; i < StrCount; i++)
			{
				ArrayMinMax [i] = Array [i, 0];

				for (j = 0; j < ColumnCount; j++) 
				{
					if (Array[i, j] >= ArrayMinMax[i])
					{
						ArrayMinMax [i] = Array [i, j];
					}
				}
			}

			MinMax = ArrayMinMax[0];

			//Поиск минимального из максимумов по строкам
			for (i = 0; i < StrCount; i++)
			{
				if (ArrayMinMax[i] <= MinMax)
				{
					MinMax = ArrayMinMax[i];
				}
			}
				
			#endregion

			//Вывод минимального из максимумов по строкам двумерного массива
			Console.WriteLine ("\nMinMax = " + MinMax);

		}
	}
}
