/*Вариант 2: Массив изначально задавать не через функцию, т.к. она может вернуть только одно значение - 
сам массив, а длину нового массива с учетом длины каждой строки мы не увидим извне. 
В глобальной области сразу задаем массив и тут же через условие определяем размер нового массива.
Передаем в функцию только формирование нового массива по вводным данным.*/

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

Console.Write("Размер первоначального маcсива/число строк = ");
int sizeArr = int.Parse(Console.ReadLine());
Console.Write("Введите ограничение длины строк для нового массива = ");
int maxStrLength = int.Parse(Console.ReadLine());

string[] arrStr = new string[sizeArr];
int newSize = 0;

for (int i = 0; i < arrStr.Length; i++)
{
    Console.Write("Вводим строку в элемент массива: ");
    arrStr[i] = Console.ReadLine();
    if (arrStr[i].Length <= maxStrLength)
    {
        newSize++;
    }
}
Console.WriteLine();
Console.WriteLine($"Задан массив [{String.Join(", ", arrStr)}]");
string[] newArrStr = ResultArrayByRowsUpToLength(arrStr, newSize, maxStrLength);
Console.WriteLine($"Сформирован массив [{String.Join(", ", newArrStr)}]"); 
Console.WriteLine($"из строк, длина которых меньше либо равна {maxStrLength}");