//Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
Random rnd = new Random();
int ColStr(string ColStr){//метод для ввода строк и столбцов
    if (ColStr == "col"){
        Console.WriteLine("Введите количество столбцов:");
        int ColStrInt = Convert.ToInt32(Console.ReadLine());
        return ColStrInt;
    }
    else{
        Console.WriteLine("Введите количество строк:");
        int ColStrInt = Convert.ToInt32(Console.ReadLine());
        return ColStrInt;
    }
}
double[,] RandomArray(int StrA, int ColA){//метод создания нового массива указанного размера и заполнения его случайными вещественными числами
        double[,] RandArray = new double[StrA, ColA];
        for (int stepstring = 0; stepstring < StrA; stepstring++){//заполняю массив случайными натуральными числами от -99 до 99
            for (int stepcolumn = 0; stepcolumn < ColA; stepcolumn++){
                RandArray[stepstring, stepcolumn] = rnd.Next(-999, 999);
                RandArray[stepstring, stepcolumn] = RandArray[stepstring, stepcolumn] / 10;//на 10 делю чтобы у генерируемых чисел было что либо после запятой
            }
        }
    return RandArray;
    }
void PrintArray(double[,] ArrayToPrint){//метод который выводит указанный массив
    Console.WriteLine("Таблица чисел: ");//вывожу полученный массив
    for (int stepstring = 0; stepstring < ArrayToPrint.GetLength(0); stepstring++){
        Console.Write($"Строка{stepstring+1}: ");
        for (int stepcolumn = 0; stepcolumn < ArrayToPrint.GetLength(1); stepcolumn++){
            Console.Write($"| {ArrayToPrint[stepstring, stepcolumn]} | ");
        }
    Console.WriteLine();
    }
}
int columns = ColStr("col");//пользователь вводит количество столбцов
int strings = ColStr("str");//пользователь вводит количество строк
double[,] array = RandomArray(strings, columns);//создаю массив указанного размера
PrintArray(array);//программа выводит указанный массив