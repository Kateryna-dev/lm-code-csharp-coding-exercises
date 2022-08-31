using System;
using Exercises.Models;

namespace Exercises
{
    public class Exercise002
    {
        const string MANCHESTER = "Manchester";

        public bool IsFromManchester(Person person)
        {
            return person != null && person.City == MANCHESTER;
        }

        public bool CanWatchFilm(Person person, int ageLimit)
        {
            return person!= null && person.Age >= ageLimit;
        }
    }
}
