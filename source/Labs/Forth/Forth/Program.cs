//Лаба №4
//Найдите количество появлений каждого символа из имеющихся в строке

using System;

namespace Forth
{
	/// <summary>
	/// Main class - основной класс программы
	/// для вычисления количества появлений каждого символа из имеющихся в строке
	/// Строка вводится пользователем с клавиатуры
	/// </summary>

	class MainClass
	{
		/// <summary>
		/// Точка входа программы, основной метод.
		/// </summary>
		/// <param name="args">Аргументы для запуска в командной строке(терминале)</param>

		public static void Main (string[] args)
		{
			int i, j;		//Счетчики итераций циклов
			bool[] Flag;	//Массив флагов, чтобы не рассматривать уже учтенные виды символов
			string Input;	//Строка для пользовательского ввода
			int[] CountTypes;	//Массив для записи кол-ва символов всех видов

	    	//Ввод строки с клавиатуры и ее эхо-печать
			Console.Write ("Введите произвольную строку: ");
			Input = Console.ReadLine();
			Console.WriteLine ("Вы ввели строку: " + Input);

			//Если введена пустая строка - завершить программу (с выводом сообщения)
			//Учитывать пробел и табуляцию(?)
			if (Input.Length == 0) 
			{
				Console.WriteLine ("ОШИБКА! Введена пустая строка. Программа завершает свою работу.");
				return;
			}

			//Выделяем память для массива флагов
			Flag = new bool[Input.Length]; //По дефолту все элементы FALSE (проверено)
			//Выделяем память для массива, в который записываем количество символов каждого вида
			CountTypes = new int[Input.Length];

			for (i = 0; i < Input.Length; i++)
			{
				for (j = 0; j < Input.Length; j++)
				{
					if ((Input [i] == Input [j]) && (Flag [j] == false)) 
					{
						CountTypes [i]++;
						Flag [j] = true;
					}
				}
			}
		
			for (i = 0; i < Input.Length; i++) 
			{
				if (CountTypes [i] != 0) 
				{
					Console.WriteLine ("Символ " + Input [i] + " встречается " + CountTypes [i] + " раз");
				}
			}

		}
	}
}
