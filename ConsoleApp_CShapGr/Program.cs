// მოცემულია string, რომელშიც გვაქვს რიცხვები
// თითოეული რიცხვისთვის უნდა ვიპოვით მისი კვადრატი
// და უკუთანმიმდევრობით დავბეჭდოთ

string input = "34, 6, 12, 5, 8, 15, 4"; // Console.ReadLine();

string[] numbers = input.Split(", "); // "34" "6" "12" "5" "8"
double[] doubles = new double[numbers.Length];

for (int i = 0; i < doubles.Length; i++)
{
    doubles[i] = Convert.ToDouble(numbers[i]);
}

// დაბეჭდეთ
for (int i = doubles.Length - 1; i >= 0; i--)
{
    Console.WriteLine(Math.Pow(doubles[i], 2));
}


//for (int i = 0; i < doubles.Length; i++)
//{
//    Console.WriteLine(i);
//}
//for (int i = doubles.Length - 1; i >= 0; i--)
//{
//    Console.WriteLine(i);
//}
