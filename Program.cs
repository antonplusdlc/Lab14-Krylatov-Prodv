using System.IO;

Console.WriteLine("=== File.WriteAllText / ReadAllText ===");

File.WriteAllText("notes.txt", "Привет, файл!");
string content = File.ReadAllText("notes.txt");
Console.WriteLine($"Содержимое файла: {content}");