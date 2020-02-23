using Abstracts;

namespace Cats
{
    public class Tabby : AnimalAbs
    {

        #region " Constructors "

        public Tabby()
        {
            this.NumberOfLegs = 4;
        }

        public Tabby(int iID, string sName)
        {
            this.ID = iID;
            this.Name = sName;
            this.NumberOfLegs = 4;
        }

        #endregion

        #region " Overrides "

        public override string Speak()
        {
            return "Meow!";
        }

        #endregion

    }
}
