using System;

namespace CC_Class_Lesson4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Memory Project Helper
            int size = int.Parse(Console.ReadLine());
            int[,] myMatrix = new int[size, size];
            int rowNum = new Random().Next(0, 5);//2
            int colNum = new Random().Next(0, 5);//3
            for (int i = 0; i < length; i++)
            {
                while (true)
                {
                    if (myMatrix[rowNum, colNum] == 0)
                    {
                        myMatrix[rowNum, colNum] = i;
                        break;
                    }
                }
                while (true)
                {
                    if (myMatrix[rowNum, colNum] == 0)
                    {
                        myMatrix[rowNum, colNum] = i;
                        break;
                    }
                }
            }
            //X X X X
            //X X X X
            //X X X X 
            //X X X X 

            //+ + + +
            //+ + + +
            //+ + + +
            //+ + + +

            //user1: row 2 col 3 = 2
            //user1: row 4 col 1 = 4

            //user2: row 2 col 3 = 2
            //user2: row 1 col 3 = 2

            //user2: row 2 col 3 = 2
            //user2: row 1 col 3 = 2
#endregion

            Car c1 = new Car();
            c1._type = "private";
            c1._carNumber = 1827361872;
            c1._model = "mazda x5";
            c1._color = "black";
            c1._neededRepair = true;
            c1.Drive();
            bool isC1NeededRepair = c1._neededRepair;

            Car c2 = new Car();
            c2._type = "bus";
            c2._carNumber = 987249123;
            c2._model = "suzuki";
            c2._color = "gray";
            c2._neededRepair = true;
            bool isC2NeededRepair = c2._neededRepair;
            Console.WriteLine($"c2 color = {c2._color}.");
            c2.Drive();

            //object initiler;
            Car c3 = new Car
            {
                _type = "minibus",
                _carNumber = 25343523,
                _model = "toyota",
                _color = "yellow",
                _neededRepair = true,
            };
            //c3._type = "minibus";
            //c3._carNumber = 25343523;
            //c3._model = "toyota";
            //c3._color = "yellow";
            //c3._neededRepair = true;
            bool isC3NeededRepair = c3._neededRepair;
            Console.WriteLine($"c3 model = {c3._model}.");
            c3.Drive();

            Garage g1 = new Garage();
            g1.allCars = new Car[3] { c1, c2, c3 };


            Car c4 = new Car();
            c4._type = "private";
            c4._carNumber = 35234234;
            c4._model = "124 x5";
            c4._color = "bl4124ack";
            c4._neededRepair = true;

            Garage g2 = new Garage();
            g2.allCars = new Car[1] { c4 };
        }
    }

    class Garage
    {
        public Car[] allCars;

        public void AddCar()
        {
            Console.WriteLine("add car");
        }

        public void OutCar()
        {
            Console.WriteLine("out car");
        }

        public void RepairCar()
        {
            Console.WriteLine("repair car");
        }

        //class CarsSorter //Nested Class
        //{
        //    //SortByCarNumber
        //    //SortByColor
        //    //SortByModel
        //}
    }

    class Car
    {
        //Fields
        public string _type;
        public int _carNumber;
        public string _color;
        public string _model;
        public bool _neededRepair;

        //Methods
        public void Drive()
        {
            Console.WriteLine($"car: {_carNumber} with color: {_color} is driving...");
        }

    }
}
