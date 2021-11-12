using System.Collections.Generic;

namespace Tasklar1
{
    class Program
    {
        static void Main(string[] args)
        {
            #region task1
            //List<int> numbers = new List<int>() { 1,3,5};
            //numbers.ForEach(n => Console.Write(n + ", "));
            //Console.WriteLine();
            //numbers.ForEach(n => Console.Write(n*3 + ", "));
            #endregion

            #region task2
            //List<int> numbers = new List<int>() { 1, 3, 5 };
            //numbers.ForEach(n => Console.Write(n + ", "));
            //Console.WriteLine();
            //numbers.ForEach(n => Console.Write(n * n + ", "));
            #endregion

            #region task3
            //List<string> letters = new List<string>() { "A", "B", "C" };
            //letters.ForEach(l => Console.Write(l + ", "));
            //Console.WriteLine();
            //letters.ForEach(l => Console.Write("#" + l + "#" + ", "));
            #endregion

            #region task4
            Car obj1 = new Car()
            {
                Brand = "Pagani",
                Model = "Huayra BC",
                DoorCount = 2
            };
            Car obj2 = new Car()
            {
                Brand = "Ferrari",
                Model = "Pininfarina Sergio",
                DoorCount = 2
            };
            Car obj3 = new Car()
            {
                Brand = "Aston",
                Model = "Martin Valkyrie",
                DoorCount = 4
            };
            Car obj4 = new Car()
            {
                Brand = "Bugatti",
                Model = "Veyron by Masory Vivere",
                DoorCount = 4
            };
            Car obj5 = new Car()
            {
                Brand = "Lamborghini ",
                Model = "Veneno Roadster",
                DoorCount = 4
            };

            List<Car> cars = new List<Car>() { obj1, obj2, obj3, obj4, obj5 };
            //foreach (var item in cars)
            //{
            //    item.FullInfo();
            //}
            #endregion

            #region task5
            List<byte> list = new List<byte>();
            //add-lar
            list.Add(1);
            list.Add(2);
            list.Add(3);
            List<byte> elave = new List<byte>() { 4,5};
            list.AddRange(elave);
            //remove-lar
            list.Remove(1);
            list.RemoveAt(1);
            list.RemoveRange(2,1);
            list.RemoveAll(e=> e < 3);
            #endregion
        }

    }
}
