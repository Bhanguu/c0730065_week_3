using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c0730065_week_3
{
    class program
    {
        static void Main(string[] args)
        { }


        class countryside

        {
            village Alst;
            village Mealand;
            village Schening;
            public void IntializationMap()
            {

                Alst = new village();
                Mealand = new village();
                Mealand.isAstrildeHere = true;
                Schening = new village();

                Alst.Nextvillage = Mealand;
                Mealand.Nextvillage = Schening;
                Schening.Nextvillage = Alst;


            }
            public void WalkAround()
            {
                village InitialVillage = this.Mealand;
            }


            class village

            {

                public void IntializationMap() { }

                public village Previousvillage;
                public village Nextvillage;
                public String villageName;
                public bool isAstrildeHere = false;
                public bool isSchmingHere = false;

                public village() { }
             


            }
        }
    }
}


