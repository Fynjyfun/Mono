//Лаба №5
//Дана квадратная матрица. Найти ее определитель

using System;

namespace First
{
	/// <summary>
	/// Main class - основной класс программы
	/// для вычисления определителя квадратной матрицы
	/// Элементы матрицы генерируются случайным образом
	/// Определитель матрицы вычисляется методом приведения ее к верхнему треугольному виду
	/// </summary>

	class MainClass
	{
		const int MAX_N = 5; //Константа для максимального размера матрицы

		/// <summary>
		/// Точка входа программы, основной метод.
		/// </summary>
		/// <param name="args">Аргументы для запуска в командной строке(терминале)</param>

		public static void Main (string[] args)
		{

			Console.WriteLine ("Hello World!");
			//Console.ReadKey ();

			#region Объявление переменных
			int i, j;		//Итераторы
			int N;			//Размер квадратной матрицы. Задается пользователем
			float[,] MatrixIn;	//Массив для хранения исходной матрицы 
			float[,] Matrix;	// Массив для преобразованной к треугольному виду матрицы
			Random rnd;		//Генератор случайных чисел	
			float Det = 1;		//Переменная для определителя

			#endregion


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
			MatrixIn = new float[N, N];
			rnd = new Random ();


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

					MatrixIn [i, j] = rnd.Next(0,100);

					Console.Write (MatrixIn [i, j] + "\t");

				}

				Console.WriteLine ();
				#endregion
			}

			Console.WriteLine ();
			#endregion


			#region Приведение матрицы к треугольному виду/эхо - печать
			//Приведение матрицы к треугольному виду (для упрощения вычисления определителя)

			//Добавить: анализ на налиие 0 элементов - выход из программы(?)

			// Динамическое выделение памяти под массив для преобразованной матрицы
			Matrix = new float[N, N];

			//Копируем значения элементов в матрицу для преобразования
			for (i = 0; i < N; i++)
			{
				for (j = 0; j < N; j++)
				{
					Matrix[i, j] = MatrixIn[i, j];
				}
			}

			bool DoOnce = false; //Переменная для отслеживания того, что мы запомнили элемент, на который нужно делить строку
			float Buf = Matrix[0, 0]; //Буферная переменная

			/*
			//Основной цикл (непосредственно для алгоритма приведения) (else закомментить)
			for (i = 0; i < N; i++)
			{
				DoOnce = false;
				for (j = 0; j < N; j++)
				{
					if (i == 0)
					{
						if (DoOnce == false)
						{
							DoOnce = true;
							Buf = Matrix[i, i];
							Det *= Buf;
						}

						Matrix [i, j] /= Buf;


						if (j != N-1)
						{
							//Matrix [j+1, i] -= Matrix[i, i]*Matrix[j+1, i];
							Matrix [i+(j+1), j+1] -= Matrix[j+1, i]*Matrix[i+1, j];
						}

					}
					else 
					{

						Matrix [i, j] -= Matrix[i-1, j]*Matrix[0, i];

						if (DoOnce == false)
						{
							DoOnce = true;
							Buf = Matrix[i, i];
							Det *= Buf;
						}


						Matrix [i, j] /= Buf;

					}
				}
			}
			*/

			// Основной цикл (попытка №2)
			for (i = 0; i < N; i++)
			{
				for (j = 0; j < N; j++)
				{

				}
			}

			//Вывод матрицы привеленной к треугольному виду
			for (i = 0; i < N; i++)
			{
				for (j = 0; j < N; j++)
				{
					Console.Write (Matrix [i, j] + "\t");

				}
				Console.WriteLine ();
			}

			#endregion

			#region Окончательное вычисление определителя/вывод
			// Окончательное вычисление определителя (домножение на произведение элементов на главной диагоналя для проверки равенства 0)
			for (i = 0; i < N; i++)
			{

				Det *= Matrix [i, i]; 

			}
				

			Console.WriteLine ("\nОпределитель матрицы равен " + Det);

			#endregion

			Console.ReadKey ();//(?) А оно надо?
		}
	}
}
