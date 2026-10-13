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

Console.WriteLine();
Console.WriteLine("=== WriteAllLines / ReadAllLines ===");

string[] students = { "Иванов", "Петрова", "Сидоров" };
File.WriteAllLines("students.txt", students);

string[] readStudents = File.ReadAllLines("students.txt");
Console.WriteLine($"Прочитано строк: {readStudents.Length}");
foreach (string student in readStudents)
{
    Console.WriteLine($"- {student}");
}

Console.WriteLine();
Console.WriteLine("=== StreamWriter ===");

using (StreamWriter writer = new StreamWriter("log.txt"))
{
    writer.WriteLine("Программа запущена");
    writer.WriteLine($"Дата: {DateTime.Now:dd.MM.yyyy HH:mm}");
    writer.WriteLine("Операция выполнена успешно");
}

Console.WriteLine("Файл log.txt записан");

Console.WriteLine();
Console.WriteLine("=== StreamReader ===");

using (StreamReader reader = new StreamReader("log.txt"))
{
    string line;
    int lineNumber = 1;
    while ((line = reader.ReadLine()) != null)
    {
        Console.WriteLine($"Строка {lineNumber}: {line}");
        lineNumber++;
    }
}

Console.WriteLine();
Console.WriteLine("=== Обработка ошибок ===");

try
{
    string contentt = File.ReadAllText("несуществующий_файл.txt");
    Console.WriteLine(contentt);
}
catch (FileNotFoundException ex)
{
    Console.WriteLine($"Файл не найден: {ex.Message}");
}

Console.WriteLine();
Console.WriteLine("=== Path.Combine ===");

string folderPath = "data";
Directory.CreateDirectory(folderPath);

string filePath = Path.Combine(folderPath, "report.txt");
File.WriteAllText(filePath, "Отчёт находится в подпапке data");

Console.WriteLine($"Путь к файлу: {filePath}");
Console.WriteLine(File.ReadAllText(filePath));