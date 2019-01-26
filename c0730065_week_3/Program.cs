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
                Alst.villageName = "Alst";
                Mealand = new village();
                Mealand.villageName = "Mealand";
                Mealand.isAstrildeHere = true;
                Schening = new village();
                Schening.villageName = "Schening";

                Alst.Nextvillage = Mealand;
                Mealand.Nextvillage = Schening;
                Schening.Nextvillage = Alst;


            }
            public void FindAstrilde()
            {
                
                    village CurrentVillage = this.Mealand;
                    if (CurrentVillage.isAstrildeHere)
                    {
                        Console.WriteLine("Hugi found Astrilde !!! Celebrations");

                    }
                    village NextVillage;

                    NextVillage = CurrentVillage.Nextvillage;

                }
            

            class village

            {

                

                public village Previousvillage;
                public village Nextvillage;
                public String villageName;
                public bool isAstrildeHere = false;
               

                public village() { }
             


            }
        }
    }
}


