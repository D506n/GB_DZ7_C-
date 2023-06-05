// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
int Constant = 9;//Переменная которая задаёт количество столбцов и строк в массиве, а так же указывает насколько большие числа сможет сгенерировать рандом, при необходимости эти три значения могли бы отличаться, но для удобства проверки всё будет завязано на одном значении
Random rnd = new Random();
void Print2DArrayAndAverage(int[,] ArrayToPrint){
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
    double Average = 0;
    Console.WriteLine();
    for (int stepstring = 0; stepstring < Constant; stepstring++){
        Console.Write($"Строка{stepstring+1}: ");
        for (int stepcolumn = 0; stepcolumn < Constant; stepcolumn++){
            Console.Write($"| {ArrayToPrint[stepstring, stepcolumn]} | ");
            Average = Average + ArrayToPrint[stepstring, stepcolumn];
        }
        Average = Average / Constant;
        Average = Math.Round(Average, 1);
        Console.Write($"Среднее: {Average}");
        Average = 0;
        Console.WriteLine();
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
int[,] array = NewArrayRnd(Constant, Constant, 9);//в задаче не указано количество столбцов и строк в массиве, так что для удобства проверки решил ограничиться массивом 9 х 9 и числами от 0 до 9
Print2DArrayAndAverage(array);