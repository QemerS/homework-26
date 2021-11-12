using System;
using System.Collections.Generic;
using System.Text;

namespace Tasklar1
{
    public class Car
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public int DoorCount { get; set; }
        public void FullInfo()
        {
            this.Brand = Brand;
            this.Model = Model;
            this.DoorCount = DoorCount;
            Console.WriteLine( $"The brand is {Brand}, model is {Model}, door count is {DoorCount}");
        }
    }
}
