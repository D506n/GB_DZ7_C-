// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
int Constant = 9;//Переменная которая задаёт количество столбцов и строк в массиве, а так же указывает насколько большие числа сможет сгенерировать рандом, при необходимости эти три значения могли бы отличаться, но для удобства проверки всё будет завязано на одном значении
Random rnd = new Random();
void Print2DArrayAndFind(int[,] ArrayToPrint, int FindString, int FindColumn){
    Console.WriteLine("Таблица чисел: ");
    Console.Write("№ ст.:     ");
    for (int step = 1; step <= Constant; step++){
        if(step<9){ //без этой проверки таблица выглядит очень некрасиво, когда константа больше 9
            Console.Write($"{step}     ");
        }
        else{
            Console.Write($"{step}    ");
        }
    }
    Console.WriteLine();
    for (int stepstring = 0; stepstring < Constant; stepstring++){
        Console.Write($"Строка{stepstring+1}: ");
        for (int stepcolumn = 0; stepcolumn < Constant; stepcolumn++){
            if (stepcolumn == FindColumn && stepstring == FindString){
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write($"| {ArrayToPrint[stepstring, stepcolumn]} | ");
                Console.ResetColor();
            }
            else{
            Console.Write($"| {ArrayToPrint[stepstring, stepcolumn]} | ");
            }
        }
        Console.WriteLine();
    }
}
int ColStr(string ColStr){//метод для ввода строк и столбцов
    if (ColStr == "col"){
        Console.WriteLine("Введите столбец:");
        int ColStrInt = Convert.ToInt32(Console.ReadLine());
        return ColStrInt;
    }
    else{
        Console.WriteLine("Введите строку:");
        int ColStrInt = Convert.ToInt32(Console.ReadLine());
        return ColStrInt;
    }
}
int[,] NewArrayRnd(int strings, int columns, int RandNum){
    int [,] NewArrayRnd = new int[strings, columns];
    for (int stepstring = 0; stepstring < strings; stepstring++){//заполняю массив случайными числами от 0 до указанного
        for (int stepcolumn=0; stepcolumn < columns; stepcolumn++){
            NewArrayRnd[stepstring, stepcolumn] = rnd.Next(0, RandNum);
        }
    }
    return NewArrayRnd;
}
void CheckAndPrint(int[,]ArrayToCheck, int StringNumTC, int ColumnNumTC){
    if (ColumnNumTC <=Constant && StringNumTC <= Constant && ColumnNumTC >= 0 && StringNumTC >= 0){//а тут выполняется проверка, вписывается ли указанный пользователем элемент в рамки массива и в случае прохождения проверки выдаётся нужный элемент
        Console.WriteLine($"Элемент массива в столбце {ColumnNumTC+1} и строке {StringNumTC+1}: {ArrayToCheck[StringNumTC, ColumnNumTC]}");
    }
    else {
        Console.WriteLine("В таблице нет такого элемента.");
    }
}
Console.WriteLine($"Таблица содержит строки под номерами 1 - {Constant} и столбцы под номерами 1 - {Constant}. Для поиска элемента укажите столбец и строку.");
int СolumnNum = ColStr("col")-1;
int StringNum = ColStr("str")-1;
int[,] array = NewArrayRnd(Constant, Constant, 9);//в задаче не указано количество столбцов и строк в массиве, так что для удобства проверки решил ограничиться массивом 9 х 9 и числами от 0 до 9
Print2DArrayAndFind(array, StringNum, СolumnNum);//Оставлю тут для быстрой проверки
CheckAndPrint(array, StringNum, СolumnNum);