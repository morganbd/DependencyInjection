using Abstracts;
using Birds;
using Cats;
using Dogs;

namespace Data
{
    public class CreateAnimals
    {

        #region " Cats "

        public AnimalAbs GetNewTabby()
        {
            Tabby tb = new Tabby();
            return tb;
        }

        public AnimalAbs MockExistingTabby(int iID, string sName, Enums.Gender eGender)
        {
            Tabby tb = new Tabby(iID, sName);
            tb.Gender = eGender;
            return tb;
        }

        #endregion

        #region " Dogs "

        public AnimalAbs GetNewGermanShepherd()
        {
            GermanShepherd gs = new GermanShepherd();
            return gs;
        }

        public AnimalAbs MockExistingGermanShepherd(int iID, string sName, Enums.Gender eGender)
        {
            GermanShepherd gs = new GermanShepherd(iID, sName);
            gs.Gender = eGender;
            return gs;
        }

        #endregion

        #region " Birds "

        public AnimalAbs GetNewChickenRooster()
        {
            Chicken cr = new Chicken();
            cr.Gender = Enums.Gender.Male;
            return cr;
        }

        public AnimalAbs GetNewChickenHen()
        {
            Chicken cr = new Chicken();
            cr.Gender = Enums.Gender.Female;
            return cr;
        }

        #endregion

    }
}
