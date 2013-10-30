using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.GamerServices;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;


namespace FluxOfSouls
{
    public class Soul
    {
        public int soulNumber;
        public string soulName;
        public int age;
        public int maxAge;
        //public int lawLevel;
        public int goodLevel;
        
    }

    public class Souls
    {
        public static List<Soul> souls = new List<Soul>();
        Random random = new Random();
        public int soul = 0;
        public int turn = 0;

        public void createSoul ()
        {
            soul++;
            souls.Add(new Soul
            {
                soulNumber = soul,
                soulName = "alive",
                age = 0,
                maxAge = random.Next(30, 140),
                //lawLevel = random.Next(-25, 25),
                goodLevel = random.Next(-25, 25)
            });
        }
        public string returnSouls(int test)
        {
            int returned;
            if (test == 0)
            {
                returned = souls[0].lawLevel;
            }
            else
                returned = souls[0].goodLevel;

            return returned.ToString();
        }
        public string endOfTurn(int multiple)
        {
            foreach (var soul in souls)
            {
                if (soulName = "alive")
                {
                    age = age + (1 * multiple);
                    if (age >= maxAge)
                    {
                        soulName = "dead";
                    }
                    else
                    {
                        //lawLevel = lawLevel + (random.Next(-3, 3));
                        goodLevel = goodLevel + needCalculation();
                    }
                }
            }
            turn++;
            resourceManagement();
        }
        public string needCalculation()
        { 

            //Population: Most common field for the first 4 turns only this field is active; its level is the tiles population divided by the max population multiply by 100  (CP/TP *100). If the amount is above 100 then the number is decreased by 100 and changed to a negative.
            //Food: Second field active at turn 4
            //Entertainment:  active after turn 4 
            //Fresh Water:  Third field active at turn 4 
            //Security:  active after turn 8
            //Education:  active after turn 8
            //Economy: active after turn 8

        }
        public string resourceMangement()
        { 
        }
    }
}