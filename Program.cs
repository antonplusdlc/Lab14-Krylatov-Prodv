using System.IO;

Console.WriteLine("=== File.WriteAllText / ReadAllText ===");

File.WriteAllText("notes.txt", "Привет, файл!");
string content = File.ReadAllText("notes.txt");
Console.WriteLine($"Содержимое файла: {content}");

Console.WriteLine();
Console.WriteLine("=== File.AppendAllText ===");

File.AppendAllText("notes.txt", "\nВторая строка");
File.AppendAllText("notes.txt", "\nТретья строка");

string updatedContent = File.ReadAllText("notes.txt");
Console.WriteLine(updatedContent);

Console.WriteLine();
Console.WriteLine("=== File.Exists ===");

Console.WriteLine($"notes.txt существует: {File.Exists("notes.txt")}");
Console.WriteLine($"unknown.txt существует: {File.Exists("unknown.txt")}");