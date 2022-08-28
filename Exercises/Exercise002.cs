using System;
using Exercises.Models;

namespace Exercises
{
    public class Exercise002
    {
        const string MANCHESTER = "Manchester";

        public bool IsFromManchester(Person person)
        {
            if (person == null) 
            {   
                return false;
            }

            // Will retun true if person is from Manchester. Otherwise false
            return person.City == MANCHESTER;
        }

        public bool CanWatchFilm(Person person, int ageLimit)
        {
            if (person == null) 
            {
                return false;
            }

            // Will retun true if age of person is equal or bigger than limit. Otherwise false
            return person.Age >= ageLimit;
        }
    }
}
