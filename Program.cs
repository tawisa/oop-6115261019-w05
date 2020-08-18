using System;

namespace oop_6115261019_w05
{
    class Program
    {
        static void Main(string[] args)
        {
            Building b1 = new Building("111", "Building 1", "11111", "22222");
            Room r412 = new Room("412", "Room 412", "4", "4", "Computer", b1);
            Subject S = new Subject("222222", "Ced", "2.1", "2", "2");
            Lecturer Tawisa = new Lecturer("Tawisa", "Heem", "lecturer");
            Section ced = new Section("15", "13.00", "17.00", r412, S, Tawisa);
            Console.WriteLine(r412.ToString());
            Console.WriteLine(ced.ToString());
        }
    }
}