using Abstracts;

namespace Cats
{
    public class TabbyUpd : AnimalAbs
    {

        #region " Constructors "

        public TabbyUpd()
        {
            this.NumberOfLegs = 4;
        }

        public TabbyUpd(int iID, string sName)
        {
            this.ID = iID;
            this.Name = sName;
            this.NumberOfLegs = 4;
        }

        #endregion

        #region " Overrides "

        public override string Speak()
        {
            return "Pfft! Mrow!";
        }

        #endregion
    }
}
