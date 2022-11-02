
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

void FillPic() // Закрасить картинку 
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

    void PrintImage(int[,] image) //печать
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
    void FillImage(int row, int col) //закрашивает
    {
        if (pic[row, col] == 0)
        {
            pic[row, col] = 1;
            FillImage(row - 1, col);
            FillImage(row, col - 1);
            FillImage(row + 1, col);
            FillImage(row, col + 1);
        }
    }

    Console.Clear();
    PrintImage(pic);
    FillImage(10, 13);
    PrintImage(pic);

}

//Примеры использования Рекурсии
Console.Clear();

void UseRec() //Факториал и Фибоначи
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

    /* use цикл
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

    /* use цикл
    for (int i = 1; i <= num; i++)
    {
       Console.WriteLine($"f({i}) = {Fibonacci(i)}");
    } 
    */
}

void Perebor() //Перебор слов
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

void DirectoryInfo() //Как посмотреть содержимое папки?
{
    string path = "C:/Users/Мария/Desktop/Учеба/1 четверть/4. Знакомство с C#/Лекции/Examples/recursion_algorithm";
    DirectoryInfo di = new DirectoryInfo(path);
    Console.WriteLine(di.CreationTime); //дата создания папки
    FileInfo[] fi = di.GetFiles(); // какие файлы содержит папка
    for (int i = 0; i < fi.Length; i++)
    {
        Console.WriteLine(fi[i].Name);
    }
}

void DirectoryInfoRec() // посмотреть содержимое папки use рекурсию
{
    void CatalogInfo(string path, string indent = "")
    {
        DirectoryInfo catalogs = new DirectoryInfo(path);
        foreach (var currentCatalog in catalogs.GetDirectories())
        {
            Console.WriteLine($"{indent}{currentCatalog.Name}");
            CatalogInfo(currentCatalog.FullName, indent + " ");
        }
        foreach (var item in catalogs.GetFiles())
        {
            Console.WriteLine($"{indent}{item.Name}");
        }
    }
    string path = @"/Users/Мария/Desktop/Учеба/1 четверть/4. Знакомство с C#/Лекции/Examples";
    CatalogInfo(path);
}

//Игра в пирамидки
void Towers(string with = "1", string on = "3", string some = "2", int count = 5)
{
    if (count > 1) Towers(with, some, on, count - 1);
    Console.WriteLine($"{with} >> {on}");
    if (count > 1) Towers(some, on, with, count - 1);
}

// Обход разных структур - в нашем случае есть прямой, центрированный и обратный обход
// ((4 - 2) * (1 + 3)) / 10
void MathExpress() 
{
    string emp = String.Empty;
    string[] tree = { emp, "/", "*", "10", "-", "+", emp, emp, "4", "2", "1", "3" };
    //                 0    1    2     3    4    5    6    7    8    9    10   11
    void InOrderTraversal(int pos = 1)
    {
        if (pos < tree.Length)
        {
            int left = 2 * pos;
            int right = 2 * pos + 1;
            if (left < tree.Length && !String.IsNullOrEmpty(tree[left])) InOrderTraversal(left);
            Console.WriteLine(tree[pos]);
            if (right < tree.Length && !String.IsNullOrEmpty(tree[right])) InOrderTraversal(right);
        }
    }
    InOrderTraversal();
}

MathExpress();

