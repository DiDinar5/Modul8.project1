using System;
using System.IO;
using System.Reflection;

class Task2
{
    public static void Main()
    {
        string InputPath = Console.ReadLine();
        DirectoryInfo dirInfo = new DirectoryInfo(InputPath);

        try
        {
            if (dirInfo.Exists)
            {
                TimeSpan span1 = TimeSpan.FromMinutes(30);

                foreach (var f in dirInfo.GetFiles())
                    if (f.LastAccessTime < DateTime.Now - span1)
                    {
                        f.Delete();
                        Console.WriteLine("Удален файл, который не использовался более 30 минут {0}", f.Name);
                    }
            }
            else
            {
                Console.WriteLine("Файл не удален");
            }



        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}

//TimeSpan span1 = TimeSpan.FromHours(0.78787);
////TimeSpan.FromMinutes(30)

////try
////{
////    DirectoryInfo dirInfo = new DirectoryInfo(@"/Users/luft/SkillFactory");
////    dirInfo.Delete(true); // Удаление со всем содержимым
////    Console.WriteLine("Каталог удален");
////}
////catch (Exception ex)
////{
////    Console.WriteLine(ex.Message);
////}



////if (Directory.Exists(dirName))
////{
////    Console.WriteLine("Папки:");
////    string[] dirs = Directory.GetDirectories(dirName);  // Получим все директории корневого каталога

////    foreach (string d in dirs) // Выведем их все
////        Console.WriteLine(d);

////    Console.WriteLine();
////    Console.WriteLine("Файлы:");
////    string[] files = Directory.GetFiles(dirName);// Получим все файлы корневого каталога

////    foreach (string s in files)   // Выведем их все
////        Console.WriteLine(s);
////}
///

//C: \Users\dinar\OneDrive\Рабочий стол\forDelete