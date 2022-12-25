/* Задача: написать программу, которая из имеющегося массива строк формирует массив из строк, 
длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, 
либо задать на старте выполнения алгоритма.
При решении не рекомендуется пользоваться коллекциями.*/


//получение числа с консоли, для того, чтобы задать размерность массива
int GetNumberFromConsole(string message)
{
    bool isCorrect = false;
    int result = 0;

    while(!isCorrect)
    {
        Console.WriteLine(message);

        if(int.TryParse(Console.ReadLine(), out result))
        {
            isCorrect = true;
        }
        else
        {
            Console.WriteLine("Ввели не число. Введите число");
        }
    }
    return result;
}

//метод, получает массив путем ввода его элементов пользователем
string[] InitArray(int dimension)
{
    string[] array = new string[dimension];

    for (int i = 0; i < dimension; i++)
    {
        Console.WriteLine($"Введите {i}-тый элемент массива ");
        array[i] = Console.ReadLine() ?? "";
    }
    return array;
}

//метод, создающий новый массив из элементов, длина которых 3 и меньше символов
string[] GetShortWordArray(string[] array)
{
    string[] result = new string[array.Length];
    int count = 0;
    foreach (string item in array)      
    {
        if (item.Length <=3)
        {
            result[count] = item;
            count ++;
        }
    }
    
    return result;
}

//метод, который будет печатать массив
void PrintArray(string[] array)
{
    for (int i = 0; i <array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

int dimension = GetNumberFromConsole("Введите количество элементов массива");
Console.WriteLine();
string[] startArray = InitArray(dimension);
Console.WriteLine();
PrintArray(startArray);
Console.WriteLine();
string[] finalArray = GetShortWordArray(startArray);
PrintArray(finalArray);
Console.WriteLine();