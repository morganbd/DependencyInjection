using Abstracts;

namespace Dogs
{
    public class GermanShepherd : AnimalAbs
    {

        #region " Constructors "

        public GermanShepherd()
        {
            this.NumberOfLegs = 4;
        }

        public GermanShepherd(int iID, string sName)
        {
            this.ID = iID;
            this.Name = sName;
            this.NumberOfLegs = 4;
        }

        #endregion

        #region " Overrides "

        public override string Speak()
        {
            return "Woof woof!";
        }

        #endregion
    }
}
