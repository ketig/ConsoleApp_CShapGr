//runtime exception

string[] names = new string[4];

try
{
    names[0] = "giorgi";
    names[1] = "rati";
    names[2] = "nika1";
    names[3] = "nika2";
} // block
catch (IndexOutOfRangeException ex)
{
    Console.WriteLine("Index out of range!");
}
catch (Exception ex)
{
    Console.WriteLine("Oops, something went wrong!");
}
finally
{
    Console.WriteLine("Values inserted in array!");
}


for (int i = 0; i < names.Length; i++)
{
    Console.WriteLine($"is this you {names[i]}");
}
