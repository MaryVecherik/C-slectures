
/* //Двумерные массивы
//строка
string [,] table = new string [2, 5];
// String.Empty
// table [0, 0]  table [0, 1]  table [0, 2] ... table [0, 4]
// table [1, 0]  table [1, 1]  table [1, 2] ... table [1, 4]

table [1,2] = "слово";
for (int rows = 0; rows < 2; rows++)
{
    for (int columns = 0; columns < 5; columns++)
    {
        Console.WriteLine($"-{table[rows, columns]}-");
    }
}

// числа
void PrintArray (int[,] matr) //печать
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]} ");
        }
        Console.WriteLine();
    }
}
void FillArray (int[,] matr) //заполняет 
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
           matr[i, j] = new Random().Next(1, 10); // [1; 10)
        }
    }
}

int [,] matrix = new int [3, 4];
FillArray(matrix);
PrintArray(matrix); 
*/

void Pic() // Закрасить картинку 
{
    int[,] pic = new int[,]
{
 {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
 {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
 {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
 {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
 {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
 {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
 {0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
 {0, 0, 0, 0, 0, 0, 0, 1, 1, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
 {0, 0, 0, 0, 0, 1, 1, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
 {0, 0, 1, 1, 1, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 0, 0, 0, 0 },
 {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0 },
 {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0 },
 {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 0, 0, 0, 0 },
 {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0 },
 {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0 },
 {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 0, 0, 0, 0 },
 {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0 },
 {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0 },
 {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0 },
 {0, 0, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0 },
 {0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0 },
 {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0 },
 {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
};

void PrintImage (int[,] image) //печать
{
    for (int i = 0; i < image.GetLength(0); i++)
    {
        for (int j = 0; j < image.GetLength(1); j++)
        {
            if (image[i, j] == 0) Console.Write($" ");
            else Console.Write($"+");
        }
        Console.WriteLine();
    }
}
void FillImage (int row, int col) //закрашивает
{
    if (pic[row, col] == 0)
    {
        pic[row, col] = 1;
        FillImage(row-1, col);
        FillImage(row, col-1);
        FillImage(row+1, col);
        FillImage(row, col+1);
    }
}

Console.Clear();
PrintImage(pic);
FillImage(10, 13);
PrintImage(pic);

}

//Примеры использования Рекурсии
Console.Clear();

void Rec() //Факториал и Фибоначи
{
    Console.WriteLine("Введите число");
    int num = Convert.ToInt32(Console.ReadLine());

    //Факториал
    double Factorial(int num)
    {
        // 1! = 1
        // 0! = 1
        if (num == 1) return 1;
        else return num * Factorial(num - 1);
    }
    Console.WriteLine($"{num}! = {Factorial(num)}");

    /*
    for (int i = 1; i <= num; i++)
    {
      Console.WriteLine($"{i}! = {Factorial(i)}");
    } 
    */

    // Фибоначи
    // f(1) = 1
    // f(2) = 1
    // f(n) = f(n-1) + f(n-2)
    double Fibonacci(int num)
    {
        if (num == 1 || num == 2) return 1;
        else return Fibonacci(num - 1) + Fibonacci(num - 2);
    }

    Console.WriteLine($"f({num}) = {Fibonacci(num)}");

    /*
    for (int i = 1; i <= num; i++)
    {
       Console.WriteLine($"f({i}) = {Fibonacci(i)}");
    } 
    */
}

void Rec2() //Перебор слов
{
    /*В некотором машинном алфавите имеются четыре
    буквы «а», «и», «с» и «в». Покажите все слова,
    состоящие из T букв, которые можно построить из букв
    этого алфавита */
    int n = 1;
    void FindWords(string alphabet, char[] word, int length = 0)
    {
        if (length == word.Length)
        {
            Console.WriteLine($"{n++} {new String(word)}"); return;
        }
        for (int i = 0; i < alphabet.Length; i++)
        {
            word[length] = alphabet[i];
            FindWords(alphabet, word, length + 1);
        }
    }
    FindWords("аисв", new char[2]);
}

Rec();

