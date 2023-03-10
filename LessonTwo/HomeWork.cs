using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace LessonTwo
{
    class WebSite
    {
        public string SiteName { get; set; } = "Example.com";
        public string PathToSite { get; set; } = "https://www.example.com";
        public string DescriptionOfSite { get; set; } = "about everything";
        public string IPAddress { get; set; } = "195.19.255.1";
        public void Print()
        {
            WriteLine($"\tСайт: {SiteName}\n\tПуть: {PathToSite}\n\tОписание сайта: {DescriptionOfSite}\n\tIP адрес сайта: {IPAddress}\n");
        }
    }
    class Journal
    {
        public string JournalName { get; set; } = "Example name";
        public int Year { get; set; } = 1990;
        public string Email { get; set; } = "Example@mail.ru";
        public void Print()
        {
            WriteLine($"\tНазвание журнала: {JournalName}\n\tГод основания: {Year}\n\tEmail для связи: {Email}");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            WebSite site1 = new WebSite
            {
                SiteName = "Dogs",
                PathToSite = "https://www.dogs-are-my-friends.com",
                DescriptionOfSite = "Here is information about dogs",
                IPAddress = "172.16.255.2",
            };
            site1.Print();
            Journal murzilka = new Journal
            {
                JournalName = "Мурзилка",
                Year = 1924,
                Email = "Murzilka@mail.ru"
            };
            murzilka.Print();
        }
    }
}
