using System;

namespace Assignment9
{
    class MaleMos : Mosquito
    {
        public MaleMos(string food) : base(true, food)
        {
            //CalculateReservedDay(food);
        }
        
        public override void CalculateReservedDay(string food)
        {
            //Male mos: eat only blood, it live + 1 reserved day
            // Other cases: it dies
            if (food == FOOD_RESIN)
            {
                reservedDay = 1;
                isAlive = true;
            }
            else 
            {
                if (reservedDay > 0)
                {
                    reservedDay = 0;
                }
                else 
                {
                    isAlive = false;
                }
            }
        }
    }
}
