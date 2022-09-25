// функции/методы
/*
// 1
void Method1 ()
{
   Console.WriteLine("Hello, World!");
}
//Method1();



// 2
void Method2 (string msg)
{
   Console.WriteLine(msg);
}
//Method2("какой-то текст");

void Method21 (string msg, int count)
{
    int i = 0;
    while (i < count)
    {
      Console.WriteLine(msg);
      i++;
    }
}
//Method21(msg: "какой-то текст", count: 4); // or Method21(count: 4, msg: "какой-то текст");



// 3
int Method3 ()
{
   return DateTime.Now.Year;
}
int year = Method3();
//Console.WriteLine(year);



//4
string Method4 (int count, string text)  // с помощью цикла while
{
    int i = 0;
    string result = "";   // or string result = String.Empty;
    while (i < count)
    {
       result = result + text;
       i++; 
    }
    return result;
}

string Method4 (int count, string text)  // с помощью цикла for 
{
    string result = "";   // or string result = String.Empty;
    for (int i = 0; i < count; i++)
    {
      result = result + text;
    }
    return result;
}
string res = Method4 (10, "z");
Console.WriteLine(res); 



// таблица умножения 
for (int i = 2; i <= 10; i++)
{
    for (int j = 2; j <= 10; j++)
    {
      Console.WriteLine($"{i} * {j} = {i*j}");
    }
    Console.WriteLine();
}



// работа с текстом 
// Дан текст. В тексте нужно все пробелы заменить чёрточками,
// маленькие буквы “к” заменить большими “К”,
// а большие “С” маленькими “с”.
// Ясна ли задача?

string text = "— Я думаю, — сказал князь, улыбаясь, — что, "
+ "ежели бы вас послали вместо нашего милого Винценгероде, "
+ "вы бы взяли приступом согласие прусского короля. "
+ "Вы так красноречивы. Вы дадите мне чаю?";

// string s = “qwerty”
//             012345
// s [3]; // r

string Replace (string text, char oldValue, char newValue)
{
    string result = String.Empty;

    for (int i = 0; i<text.Length; i++)
    {
        if (text[i] == oldValue)
        {
            result = result + $"{newValue}";
        }
        else 
        {
            result = result + $"{text[i]}";
        }
      }

    return result;
}

string newtext = Replace (text, ' ', '_');
Console.WriteLine(newtext);
Console.WriteLine();
newtext = Replace (newtext, 'к', 'К');
Console.WriteLine(newtext);
Console.WriteLine();
newtext = Replace (newtext, 'в', 'В');
Console.WriteLine(newtext);
Console.WriteLine();
*/


//упорядочить массив
/*
1.Найти позицию минимального элемента в неотсортированной части массива
2.Произвести обмен этого значения со значением первой неотсортированной позиции
3.Повторять пока есть не отсортированные элементы 
*/
Console.Clear();
int [] arr = { 6, 8, 3, 2, 1, 4, 5, 7, 2 };

void PrintArray (int[] array) //выводит на экран массив
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

void SelectionSort (int[] array) // сортировка //от минимального
{
  for (int i = 0; i < array.Length-1; i++)
  {
    int minPosition = i;

    for (int j = i+1; j < array.Length; j++)
    {
        if (array[j] < array[minPosition])
        {
            minPosition = j;
        }
    }
    int temporary = array[i];
    array[i] = array[minPosition];
    array[minPosition] = temporary;
  }
}

void SelectionSortMax (int[] array) // сортировка //от максимального
{
  for (int i = 0; i < array.Length-1; i++)
  {
    int maxPosition = i;

    for (int j = i+1; j < array.Length; j++)
    {
        if (array[j] > array[maxPosition])
        {
            maxPosition = j;
        }
    }
    int temporary = array[i];
    array[i] = array[maxPosition];
    array[maxPosition] = temporary;
  }
}


PrintArray(arr);

SelectionSort(arr);
PrintArray(arr);

SelectionSortMax(arr);
PrintArray(arr);