string[] initialArray = { "Hello", "-2", "world", ":-)", "124", "Denmark", "Moscow", "+" };
int count = 0;
int findLength = 3;

for (int index = 0; index < initialArray.Length; index++)
{
  if (initialArray[index].Length <= findLength)
  {
    count++;
  }
}

if (count != 0)
{
  string[] finalArray = new string[count];
  int j = 0;
  for (int index = 0; index < initialArray.Length; index++)
  {
    if (initialArray[index].Length <= findLength)
    {
      finalArray[j] = initialArray[index];
      j++;
    }
  }

  for (int index = 0; index < count; index++)
  {
    if (count == 1)
    {
      Console.WriteLine($"[{finalArray[index]}]");
    }
    else if (index == 0)
    {
      Console.Write($"[{finalArray[index]}, ");
    }
    else if (index == count - 1)
    {
      Console.WriteLine($"{finalArray[index]}]");
    }
    else
    {
      Console.Write($"{finalArray[index]}, ");
    }
  }
  
}
else
{
  Console.WriteLine("[  ]");
}
