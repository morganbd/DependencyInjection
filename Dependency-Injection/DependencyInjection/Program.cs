using System;
using System.Collections.Generic;

using Abstracts;

namespace DependencyInjection
{
    class Program
    {
        //Brendon Morgan - 07/31/2018

        /*The purpose of this is to demonstrate the capabilities of Dependency Injection.
          
          Animals were used as classes because they had enough in common to create an Abstract.
          
          This process will work largely the same with an Interface, but an Abstract has more
          functionality for this purpose.
          
          Theoretically the Birds, Cats, and Dogs projects can all have very different references. By
          referencing them through their Abstract instead of directly, the Project using them does not
          need to have references for the entire collective, and those references will instead be 
          loaded only as needed.
          
          An added benefit of this programming style is the ability to create new versions of
          these classes, and because a large majority of the program will actually be referencing
          them through their Abstract, it reduces the number of places your code must be changed to 
          implement the new versions of the classes.*/

        public static void Main(string[] args)
        {
            try
            {
                List<AnimalAbs> lAnimals;
                Data.CreateAnimals ca = new Data.CreateAnimals();

                lAnimals = LoadDemoData();

                foreach (AnimalAbs an in lAnimals)
                {
                    Console.WriteLine(an.Name + " | Number of Legs: " + an.NumberOfLegs.ToString() + " | " + an.Speak());
                }

                Console.ReadLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                Console.ReadLine();
                return;
            }
        }

        #region " Load Demo Data "

        /*In a real project, something like this would be handled by communication to a database, whether
          that be through Entities or a custom data class.*/
        public static List<AnimalAbs> LoadDemoData()
        {
            List<AnimalAbs> lDemoData = new List<AnimalAbs>();

            Data.CreateAnimals ca = new Data.CreateAnimals();

            //Birds
            AnimalAbs rooster = ca.GetNewChickenRooster();
            rooster.Name = "Hansel";
            lDemoData.Add(rooster);

            AnimalAbs hen = ca.GetNewChickenHen();
            hen.Name = "Gretel";
            lDemoData.Add(hen);

            //Cats - Cats get a factory for versioning demonstration. See CatFactory.cs for explanation/details.
            Data.CatFactory cf = new Data.CatFactory();

            AnimalAbs tabby1 = cf.CreateCat(1, "Panda", Enums.Gender.Female);
            lDemoData.Add(tabby1);

            AnimalAbs tabby2 = cf.CreateCat(2, "Derek", Enums.Gender.Male);
            lDemoData.Add(tabby2);

            AnimalAbs tabby3 = cf.CreateCat(0, "Cheddar", Enums.Gender.Male);
            lDemoData.Add(tabby3);

            #region Code used before newer TabbyUpd class was created

            //AnimalAbs tabby1 = ca.MockExistingTabby(1, "Panda", Enums.Gender.Female);
            //lAnimals.Add(tabby1);

            //AnimalAbs tabby2 = ca.MockExistingTabby(2, "Derek", Enums.Gender.Male);
            //lAnimals.Add(tabby2);

            //AnimalAbs tabby3 = ca.GetNewTabby();
            //tabby3.Name = "Cheddar";
            //tabby3.Gender = Enums.Gender.Male;
            //lAnimals.Add(tabby3);

            #endregion

            //Dogs
            AnimalAbs germanShepherd = ca.GetNewGermanShepherd();
            germanShepherd.Name = "Zippy";
            germanShepherd.Gender = Enums.Gender.Male;
            germanShepherd.NumberOfLegs = 3; //Accident prone
            lDemoData.Add(germanShepherd);

            return lDemoData;
        }

        #endregion
    }
}
