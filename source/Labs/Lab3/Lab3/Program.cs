//Лаба №3
//Является ли матрица произведением числа и единичной матрицы?

using System;

namespace Lab3
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			const int MAX_N = 10; //Константа для максимального размера матрицы
			 
			int i, j;
			int N;
			float Buf;
			float[,] matrix;
			Random rnd = new Random ();
			//bool[] error = new bool[3];

			#region Ввод размера матрицы
			Console.WriteLine ("\nВведите размер квадратной матрицы.");
			//Указать(вывести) пределы размера пользователю!!

			do 
			{
				//Добавить проверку на допустимые символы (только цифры)
				// А еще диалог о том, не хотите ли выйти из программы, если неверно указали размер матрицы
				N = int.Parse (Console.ReadLine());

				if (N <= 0 || N > MAX_N) 
				{
					Console.WriteLine ("Некорректное значение размера матрицы! Попробуйте ввести еще раз.");
				}

			}
			while (N <= 0 || N > MAX_N);

			Console.Write ("N = " + N + "\n\n");

			#endregion

			//Динамическое выделение памяти под исходную матрицу и генератор случайных чисел
			matrix = new float[N, N];


			#region Цикл для инициализации матрицы
			for (i = 0; i <  N; i++)
			{

				#region	Вывод шапки таблицы
				if (i == 0) 
				{

					for (j = 0; j < N; j++)
						Console.Write ("  " + (j + 1) + ")\t");

					Console.WriteLine ();
				} 

				Console.Write ((i +1) + ") ");
				#endregion

				#region Заполнение/эхо - печать первоначальной матрицы

				for (j = 0; j < N; j++)
				{

					matrix [i, j] = rnd.Next(0,100);

					Console.Write (matrix [i, j] + "\t");

				}

				Console.WriteLine ();
				#endregion
			}

			Console.WriteLine ();
			#endregion

			Buf = matrix [0, 0];

			for (i = 0; i < matrix.Length; i++)
			{
				for (j = 0; j < N; i++)
				{


					if (i == j)
					{
						if (matrix[i,j] != Buf)
					
						{
							Console.WriteLine("Матрица не является произведением единичной матрицы на число!");
							return;
						
						}
					}
					else 
					{
						if (matrix[i,j] != 0)
						{
							Console.WriteLine("Матрица не является произведением единичной матрицы на число!");
							return;
						}
					}
				}
			}


			Console.WriteLine("Alright!");

		}
	}
}
