/* поиск позиции нужного элемента 
Имеется одномерный массив array из n элементов, требуется
найти элемент массива, равный find
1. Установить счетчик index в позицию 0
2. Если array [index] = find, алгоритм завершил работу
успешно.
3. Увеличить index на 1
4. Если index < n, то перейти к шагу 2. В противном случае
алгоритм завершил работу безуспешно. */

void FillArray (int[] collection) //метод заполняет
{
   int length = collection.Length;
   int index = 0;
  
  while (index < length)
  {
    collection[index] = new Random().Next(1, 10);
    index++;
  }
}

void PrintArray (int[] col)    //метод печатает
{
   int count = col.Length;
   int index = 0;
  
  while (index < count)
  {
    Console.Write($" {col[index]}");
    index++;
  }
}

int Indexof (int[] collection, int find)  //метод поиска нужного элемента
{
   int count = collection.Length;
   int index = 0;
   int position = -1;  // если нет эл-та в массиве, то по умолчанию -1, а не 0

 while (index < count)
  {
     if(collection[index] == find)
    {
      position = index;  
      break;
    }
    index++;
  }
  
  return position;
}

int [] array = new int [10];
FillArray(array);
PrintArray(array);
Console.WriteLine();

int pos = Indexof(array, 4);
Console.WriteLine(pos);

