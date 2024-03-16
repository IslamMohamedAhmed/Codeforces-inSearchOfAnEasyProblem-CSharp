using static System.Console;
using static System.Convert;
using static System.Math;



int n, counter = 0; ;
int[] arr1 = new int[101];

n = ToInt32(ReadLine());
string str = ReadLine();
var arr2 = str.Split(" ");
for(int i = 0; i < n; i++)
{
    if (ToInt32(arr2[i]) >= 1)
    {
        counter += ToInt32(arr2[i]);
        break;
    }
}

if(counter > 0)
{
    WriteLine("HARD");
}
else
{
    WriteLine("EASY");
}