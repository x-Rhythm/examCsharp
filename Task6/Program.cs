int q = Convert.ToInt32(Console.ReadLine()); 
double b = 0; 
for (int i = 0; i < q; i++) 
{ 
    double a; 
    a = Math.Pow(2,i); 
    b += a; 
} 
System.Console.WriteLine(b);