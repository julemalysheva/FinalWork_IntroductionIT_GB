//Первый вариант, когда все выделяем в отдельные методы: задаем массив, ищем кол-во строк/размер 
//нового массива по заданным условиям длины строки, формируем массив из строк соответствующей длины

string[] InputArray(int num)
{
    string[] arr = new string[num];
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write("Вводим строку в элемент массива: ");
        arr[i] = Console.ReadLine();
    }
    return arr;
}


int CountOfRowsUpToLength(string[] arr, int lengthRow)
{
    int countOfRow = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        countOfRow += (arr[i].Length <= lengthRow) ? 1 : 0;
    }
    return countOfRow;
}

string[] ResultArrayByRowsUpToLength(string[] arr, int newSize, int strLength)
{
    string[] newStrArr = new string[newSize];
    int j = 0;
    foreach (string item in arr)
    {
        if (item.Length <= strLength)
        {
            newStrArr[j] = item;
            j++;
        }
    }
    return newStrArr;
}

Console.Write("Размер первоначального маcсива = ");
int sizeArr = int.Parse(Console.ReadLine());
string[] myArray = InputArray(sizeArr);//задаем массив
Console.WriteLine($"Задан массив [{String.Join(", ", myArray)}]");

Console.Write("Введите ограничение длины строк для нового массива = ");
int strLength = int.Parse(Console.ReadLine());
string[] newArrStr = ResultArrayByRowsUpToLength(myArray, CountOfRowsUpToLength(myArray, strLength), strLength);
Console.WriteLine($"Получен массив [{String.Join(", ", newArrStr)}]");