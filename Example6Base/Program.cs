int a = 3;
int b = 7;
int c = 2;
int d = 8;
int e = 3;

int max = a;

if (b > max) max = b;
if (c > max) max = c;
if (d > max) max = d;
if (e > max) max = e;

Console.Write("max = ");
Console.Write(max);