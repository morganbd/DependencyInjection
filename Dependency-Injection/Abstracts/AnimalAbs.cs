using System;

namespace Abstracts
{
    public abstract class AnimalAbs
    {

        #region " Properties "

        public int ID { get; set; }
        public string Name { get; set; }
        public Enums.Gender Gender { get; set; }
        public int NumberOfLegs { get; set; }

        #endregion

        #region " Abstract Methods/Functions "

        public abstract string Speak();

        #endregion

        #region " Overrides "

        public override string ToString()
        {
            //return base.ToString();
            return this.Name;
        }

        #endregion
    }
}
