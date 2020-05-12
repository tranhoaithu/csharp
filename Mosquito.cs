using System;

namespace Assignment9
{
    abstract class Mosquito
    {
        public bool isMale;
        public string food;
        public bool isAlive;
        public int reservedDay;

        public Mosquito(bool isMale, string food)
        {
            this.isMale = isMale;
            this.food = food;
            CalculateReservedDay(food);
        }

        public abstract void CalculateReservedDay(string food);

        public virtual void Display()
        {
            Console.WriteLine($"Type of mosquito is Male: {isMale} and Food: {food} and isAlive : {isAlive} and reservedDay : {reservedDay}");
        }

        public const string FOOD_BLOOD = "blood";
        public const string FOOD_RESIN = "resin";
        public const string FOOD_ANOTHER = "another";
    }
}
