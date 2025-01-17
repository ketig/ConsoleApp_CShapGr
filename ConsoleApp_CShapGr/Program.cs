// კლავიატურა
// ყურსასმენები
// ვიდეოკარტები
using ConsoleApp_CShapGr;

Cellphone cellphone = new Cellphone();
Computer computer = new Computer();

Cellphone cellphoneNika = new Cellphone(8, "Redmi", 256);
Cellphone cellphoneRati = new Cellphone(8, "Redmi", 128);
Cellphone cellphoneLasha = new Cellphone(8, "Samsung", 256);

Console.WriteLine("Ratis phone: ");
Console.WriteLine(cellphoneRati.Brand);
Console.WriteLine(cellphoneRati.Storage);
Console.WriteLine(cellphoneRati.ra);

// Mouse - brand, dpi, bluetooth, wireless, color
Mouse mouse = new Mouse("hp", 3600, true, true, "white");

Console.WriteLine(mouse._brand);
Console.WriteLine(mouse._dpi);
Console.WriteLine(mouse._bluetooth);
Console.WriteLine(mouse._wireless);
Console.WriteLine(mouse._color);

//List<string> names = new List<string>();
//Dictionary<string, int> gameObjects = new Dictionary<string, int>();
//gameObjects.Add("Coins", 20);
//gameObjects.Add("Sword", 2);
//gameObjects.Add("Guard", 7);
//gameObjects.Add("Gun", 2);
//gameObjects.Add("Gun", 1); key-ების გამეორება იწვევს Runtime Exception