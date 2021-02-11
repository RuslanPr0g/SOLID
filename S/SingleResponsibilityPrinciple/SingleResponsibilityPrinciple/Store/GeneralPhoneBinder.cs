using System;

namespace SingleResponsibilityPrinciple
{
    class GeneralPhoneBinder : IPhoneBinder
    {
        public Phone CreatePhone(string[] data)
        {
            if (data.Length >= 2)
            {
                if (Int32.TryParse(data[1], out int price))
                {
                    return new Phone { Model = data[0], Price = price };
                }
                else
                {
                    throw new Exception("Phone error. Incorrect: Price.");
                }
            }
            else
            {
                throw new Exception("Phone error. Not enough data.");
            }
        }
    }
}
