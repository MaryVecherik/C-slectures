Console.Clear();
//Console.Set.CursorPosition(10, 4);
//Console.WriteLine("+");

int xa = 1, ya = 1,
    xb = 1, yb = 10,
    xd = 30, yd = 10;

Console.SetCursorPosition(xa, ya);
Console.WriteLine("+");

Console.SetCursorPosition(xb, yb);
Console.WriteLine("+");

Console.SetCursorPosition(xd, yd);
Console.WriteLine("+");

int x = xa, y = xb;
int count = 0;

while(count < 1000)
{
 int want = new Random().Next(0,3); // [0; 3) 0 1 2 
  if (want == 0)
  { 
      x = (x + xa) / 2;
      y = (y + ya) / 2;
  }

 if (want == 1)
  { 
      x = (x + xb) / 2;
      y = (y + yb) / 2;
  }

 if (want == 2)
  { 
      x = (x + xd) / 2;
      y = (y + yd) / 2;
  }

Console.SetCursorPosition(x, y);
Console.WriteLine("+");

count = count + 1;
} 
