using Abstracts;
using Cats;

namespace Data
{
    public class CatFactory
    {
        /*For demonstration purposes, we pretend a new version of Tabby was 
          created. This factory will determine which class should be used. 
          The rule here is all existing items coming from the pretend datasource 
          use the old object, and anything added later will use the new one. 
          This rule doesn't really translate well in the real world, but we're
          using the power of imagination.*/

        public AnimalAbs CreateCat(int iID, string sName, Enums.Gender eGender)
        {
            /*An ID greater than 0 is used to indicate the item came from the database.
              Anything else is used to mimic an item being addded to a list by a user.*/
            if(iID > 0)
            {
                Tabby tb = new Tabby(iID, sName);
                tb.Gender = eGender;
                return tb;
            }
            else
            {
                TabbyUpd tb = new TabbyUpd();
                tb.Name = sName;
                tb.Gender = eGender;
                return tb;
            }
        }


    }
}
