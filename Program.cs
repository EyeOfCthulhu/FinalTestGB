string[] firstArray = new string[3] {"-2", "Denmark", "123"};
string[] secondArray = new string[firstArray.Length];
void Function(string[] firstArray, string[] secondArray)
{
    int score = 0;
    for (int q = 0; q < firstArray.Length; q++)
    {
    if(firstArray[q].Length <= 3)
        {
        secondArray[score] = firstArray[q];
        score++;
        }
    }
}