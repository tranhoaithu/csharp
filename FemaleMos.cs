using System;

namespace Assignment9
{
    class FemaleMos : Mosquito
    {
        bool isPregnant;

        public FemaleMos(string food, bool isPregnant) : base(false, food)
        {
            this.isPregnant = isPregnant;
            //CalculateReservedDay(food);
        }
        public override void CalculateReservedDay(string food)
        {
            //1. Pregnant Mos: only eat Blood
            //2. Not pregnant Mos: 
            //2.1 eat blood: alive + have 1 reserved day
            //2.2. eat resin: alive + 0 day reserved
            //3. other cases: Mos dies
            if (isPregnant)
            {
                isAlive = (food == FOOD_BLOOD) ? true : false;
            }
            else
            {
                if (food == FOOD_BLOOD)
                {
                    isAlive = true;
                    reservedDay = 1;
                }
                else if (food == FOOD_RESIN)
                {
                    isAlive = true;
                }
                else
                {
                    if (reservedDay > 0)
                    {
                        isAlive = true;
                        reservedDay = 0;
                    }
                }
               
            } 
        }

        public override void Display()
        {
            Console.WriteLine("----isPregant:" + isPregnant);
            base.Display();
        }
    }
}
