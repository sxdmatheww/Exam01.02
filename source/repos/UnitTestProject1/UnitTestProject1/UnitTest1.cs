using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace testStydencheskiy
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void GetStudNumber_ReturnsCorrectStudNumber()
        {
            StudNumberGenerator generator = new StudNumberGenerator();
            int year = 2022;
            int group = 1;
            string fio = "Иванов Иван Иванович";
            string expectedStudNumber = "2022.1.ИИИ";

            
            string actualStudNumber = generator.GetStudNumber(year, group, fio);

            
            Assert.AreEqual(expectedStudNumber, actualStudNumber);
        }

        [TestMethod]
        public void GetStudNumber_FIOStartsWithUppercase()
        {
            
            StudNumberGenerator generator = new StudNumberGenerator();
            int year = 2022;
            int group = 1;
            string fio = "Иванов Иван Иванович";

            
            string[] names = fio.Split(' ');
            foreach (string name in names)
            {
                char firstLetter = name[0];
                Assert.IsTrue(char.IsUpper(firstLetter)); // Проверка на заглавную букву
            }
        }
        [TestMethod]
        public void GetStudNumber_ReturnsCorrectStudNumber1()
        {
            StudNumberGenerator generator = new StudNumberGenerator();
            int year = 2020;
            int group = 2;
            string fio = "Чуйков Матвей Васильевич";
            string expectedStudNumber = "2020.2.ЧМВ";


            string actualStudNumber = generator.GetStudNumber(year, group, fio);


            Assert.AreEqual(expectedStudNumber, actualStudNumber);
        }

    }

    public class StudNumberGenerator
    {
        public string GetStudNumber(int year, int group, string fio)
        {
            string initials = GetInitials(fio);
            return $"{year}.{group}.{initials}";
        }

        private string GetInitials(string fio)
        {
            string[] names = fio.Split(' ');
            string initials = "";
            foreach (string name in names)
            {
                initials += name[0];
            }
            return initials.ToUpper();
        }
    }

}