Console.WriteLine("Впишите элементы массива разделяя их пробелом: ");
string[] firstArray = Console.ReadLine().Split(" ");
int Less = 0;
void Function (string[] firstArray)
{
    for (int q = 0; q < firstArray.Length; q++)
    {
        if(firstArray[q].Length <= 3)
        {
            Less++;
        }
    }
}
void Function2 (string [] ArrayQ)
{
    int ct = 0;
    for (int q = 0; q < firstArray.Length; q++)
    {
        if (firstArray[q].Length <= 3)
        {
            ArrayQ[ct] = firstArray[q];
            ct++;
        }
    }
}
void PrintArray (string [] ArrayW)
{
    for (int q = 0; q < ArrayW.Length; q++)
    {
        if (q==ArrayW.Length-1) Console.Write($"{ArrayW[q]}");
        else Console.Write($"{ArrayW[q]}, ");
    }
}
Function(firstArray);
string [] EndArray = new string [Less];
Function2(EndArray);
PrintArray(EndArray);