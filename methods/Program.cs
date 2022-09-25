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
string Method4 (int count, string text)
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
string res = Method4 (10, "z");
Console.WriteLine(res);

