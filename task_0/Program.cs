// Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
// длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, 
// либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, 
// лучше обойтись исключительно массивами.

using static System.Console;

Clear();
string[] array1 = new string[]{"Hello", "2", "world", ":-)"};
string[] array2 = new string[]{"1234", "5678", "information technology", "IT"}; 
string[] array3 = new string[]{"Москва", "Санк-Петербург", "Казань", "Уфа"};
string[] array4 = new string[]{"Я", "Ты", "Он", "Она", "Вместе", "Дружная", "Семья", "!"};
string[] arr = new string[]{};
int rndNum = new Random().Next(1,5);

switch (rndNum)
{
    case 1:
        arr = array1;
        break; 
    case 2:
        arr = array2;
        break; 
    case 3:
        arr = array3;
        break; 
    case 4:
        arr = array4;
        break;
}

static string[] newArr(string[] array)
{
    int newCount = 0;
    foreach (string item in array)
    {
        if (item.Length <= 3)
        {
            newCount++;
        }
    }

    string[] resultArr = new string[newCount];
    int ind = 0;
    foreach (string item in array)
    {
        if (item.Length <= 3)
        {
            resultArr[ind] = item;
            ind++;
        }
    }

    return resultArr;
}

string[] arrResult  = newArr(arr);
WriteLine(String.Join(" ", arrResult));