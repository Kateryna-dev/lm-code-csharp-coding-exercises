using System;
namespace Exercises
{
    public class Exercise003
    {
        public string[] IceCreamFlavours = { "Pistachio", "Raspberry Ripple", "Vanilla", "Mint Chocolate Chip", "Chocolate", "Mango Sorbet" };

        public int IceCreamCode(string iceCreamFlavour)
        {
            if (string.IsNullOrWhiteSpace(iceCreamFlavour))
            {
                throw new ArgumentException("Wrong flavour");
            }

            //The code of iceCreamFlavour will be the same as it's index in IceCreamFlavours
            int iceCreamCode = Array.IndexOf(IceCreamFlavours, iceCreamFlavour);
            if (iceCreamCode >= 0) 
            {
                return iceCreamCode;
            }

            throw new ArgumentException("Wrong flavour");

        }
    }
}
