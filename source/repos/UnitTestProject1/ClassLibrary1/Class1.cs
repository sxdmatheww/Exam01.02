using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stydensheskiy
{
    public class StudNumberGenerator
    {
        public string GetStudNumber(int year, int group, string fio)
        {
            string initials = GetInitials(fio);
            string formattedYear = GetFormattedYear(year);

            string studNumber = $"{formattedYear}.{group}.{initials}";

            return studNumber;
        }

        private string GetInitials(string fio)
        {
            string[] nameParts = fio.Split(' ');
            string initials = "";

            foreach (string part in nameParts)
            {
                initials += part[0];
            }

            return initials;
        }

        private string GetFormattedYear(int year)
        {
            return year.ToString("D4");
        }
    }
}