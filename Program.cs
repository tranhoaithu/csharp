using System;

namespace Assignment9
{
    class Program
    {
        static void Main(string[] args)
        {
            Mosquito[] mosquitoList = new Mosquito[3];
            //Day 1
            mosquitoList[0] = new MaleMos(Mosquito.FOOD_RESIN);
            mosquitoList[1] = new FemaleMos(Mosquito.FOOD_BLOOD, false);
            mosquitoList[2] = new FemaleMos(Mosquito.FOOD_BLOOD, true);

            string[] mosquitoFood = new string[] { Mosquito.FOOD_BLOOD, Mosquito.FOOD_RESIN, Mosquito.FOOD_ANOTHER, Mosquito.FOOD_BLOOD };

            for (int i = 0; i < mosquitoList.Length; i++)
            {
                Console.WriteLine("-------------");
                for (int j = 0; j < mosquitoFood.Length; j++)
                {
                    Console.WriteLine("In line:" + i);
                    Console.WriteLine("mosquitoFood:" + mosquitoFood[j]);
                    mosquitoList[i].CalculateReservedDay(mosquitoFood[j]);
                    mosquitoList[i].Display();
                    if (!mosquitoList[i].isAlive)break;
                }
            }

        }
    }
}
