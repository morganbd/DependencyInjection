using Abstracts;

namespace Birds
{
    public class Chicken : AnimalAbs
    {

        #region " Constructors "

        public Chicken()
        {
            this.NumberOfLegs = 2;
        }

        public Chicken(int iID, string sName)
        {
            this.ID = iID;
            this.Name = sName;
            this.NumberOfLegs = 2;
        }

        #endregion

        #region " Overrides "

        public override string Speak()
        {

            string sVoice = "Cluck cluck cluck cluck cluck!";

            if (this.Gender == Enums.Gender.Male)
            {
                sVoice = "Cock-a-doodle-dooooo!";
            }

            return sVoice;
        }

        #endregion
    }
}
