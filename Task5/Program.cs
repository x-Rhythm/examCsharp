int n = Convert.ToInt32(Console.ReadLine()); 
var arr = new int[n]; 
for (int i = 0; i < n; i++) 
{ 
    arr[i] = Convert.ToInt32(Console.ReadLine()); 
} 
int minimum = arr[0]; 
int tuf = 0; 
for (int i = 0; i < n; i++) 
{ 
    if (arr[i] < minimum) 
    { 
        minimum = arr[i]; 
        tuf = i; 
    } 
} 
int maximum = arr[0]; 
int ul = 0; 
for (int i = 0; i < n; i++) 
{ 
    if (arr[i] > maximum) 
    { 
        maximum = arr[i]; 
        ul = i; 
    } 
}
System.Console.WriteLine(maximum); 
System.Console.WriteLine(minimum); 
if (tuf < ul) 
{ 
    for (int i = tuf; i < ul; i++) 
    { 
        System.Console.WriteLine(arr[i]); 
    } 
} 
else  
{ 
    for (int i = ul; i < tuf; i++) 
    { 
        System.Console.WriteLine(arr[i]); 
    } 
}