using System;
using System.Collections.Generic;
using System.IO;

namespace Lesson7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            try
            {
                
                Console.WriteLine("הכנס נתיב קובץ מקור:");
                string sourcePath = Console.ReadLine();

                Console.WriteLine("הכנס סוג קובץ מקור (json / xml):");
                string sourceType = Console.ReadLine().ToLower(); 
                List<Person> myData = new List<Person>();

                
                Console.WriteLine("קורא נתונים...");
                if (sourceType == "json")
                {
                    myData = JsonHandler.Load(sourcePath);
                }
                else if (sourceType == "xml")
                {
                    myData = XmlHandler.Load(sourcePath);
                }
                else
                {
                    Console.WriteLine("סוג קובץ לא נתמך!");
                   
                }

                Console.WriteLine($"\nנקראו {myData.Count} פריטים בהצלחה.");
                foreach (var p in myData) Console.WriteLine(p);

               
                Console.WriteLine("\nהכנס נתיב קובץ יעד לשמירה:");
                string targetPath = Console.ReadLine();

                Console.WriteLine("הכנס סוג קובץ יעד (json / xml):");
                string targetType = Console.ReadLine().ToLower();

                
                if (targetType == "json")
                {
                    JsonHandler.Save(targetPath, myData);
                }
                else if (targetType == "xml")
                {
                    XmlHandler.Save(targetPath, myData);
                }
                else
                {
                    Console.WriteLine("סוג קובץ יעד לא נתמך, הנתונים לא נשמרו.");
                    return;
                }

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\nהפעולה הושלמה בהצלחה!");
            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"\nשגיאה: {ex.Message}");
            }
            finally
            {
                Console.ReadLine();
            }
        }
    }
}