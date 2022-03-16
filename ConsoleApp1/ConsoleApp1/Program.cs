using System;
using System.Text;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;
            #region BookorAuthor
            //Birinci kitab və müəllif barədə

            Authors authorCingiz = new Authors("Çingiz", "Abdullayev", 55);
            Book kitabQerb = new Book("Qərb Bürküsü", 15.90, 256,authorCingiz);            
            Book kitabQar = new Book("Qar və yağış", 9.99, 354, authorCingiz);

            //Ikinci kitab və müəllif barədə
            Authors authorDan = new Authors("Dan", "Brown", 61);
            Book kitabMelek = new Book("Mələklər və Şeytanlar", 23.50, 135,authorDan);
            Book kitabGoz = new Book ("Göz", 12.99, 345, authorDan);

            Book[] books = new Book[4];
            books[0] = kitabQerb;
            books[1] = kitabQar;
            books[2] = kitabMelek;
            books[3] = kitabGoz;
            Console.WriteLine("----------------Kitablar---------------");
            foreach (var item in books)
            {
                Console.WriteLine(item);
                Console.WriteLine("-----------------------------------");

            }            
            
            #endregion
            
        }

    }
}
