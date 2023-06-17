int a = Convert.ToInt32(System.Console.ReadLine());
int [] arr = new int [5];

for (int i=0 ; i<a;i++)
{
    arr[i] = Convert.ToInt32(System.Console.ReadLine());
}
int minimum = Convert.ToInt32(System.Console.ReadLine());
minimum=arr[0];
for (int i=0 ; i<a ;i ++)
{
    if (minimum>arr[i])
    {
        minimum=arr[i];
    }
}
int maximum = Convert.ToInt32(System.Console.ReadLine());
maximum=arr[0];
for (int i=0; i<a;i++)
{
    if(maximum<arr[i])
    {
        maximum=arr[i];
    }
}

for (int i=0;i<a;i++)
{
    
}