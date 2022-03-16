using System;

namespace ConsoleApp1
{
    public class Authors
    {
        #region Construction
        public Authors()
        {

        }
        public Authors(string name, string surName, byte age) : this()
        {
            this.name = name;
            this.surName = surName;
            this.age = age;

        }
        #endregion


        #region Fields
        string name;
        string surName;
        byte age;
        #endregion

        #region Property
        public byte Age
        {
            get { return age; }
            set
            {
            L1:
                if (value < 0)
                {
                    Console.WriteLine("");
                    goto L1;
                }
                else
                {
                    age = value;
                }
            }
        }
        public string Name
        {
            get { return name; }
        }
        public string SurName
        {
            get { return surName; }
        }
        #endregion

        //method
        public string FullName(string name, string surname)
        {
            return name + " " + surname;
        }
        public override string ToString()
        {
            return $"Müəllifin adı və soyadı: {FullName(name, surName)}\n" +
                $"Müəllifin yaşı: {age}";
        }


    }
}
