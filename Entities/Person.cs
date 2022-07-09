using Exercise_1.Entities.Enums;
using System.Collections.Generic;

namespace Exercise_1.Entities {
    class Person {
        public int Age { get; set; }
        public double Weight { get; set; }
        public double Height { get; set; }
        public EyeColor EyeColor { get; set; }
        public HairColor HairColor { get; set; }
        public List<Person> p = new List<Person>();
        //public int C1 { get; set; }

        public Person(int age, double weight, double height, EyeColor eyeColor, HairColor hairColor) {
            Age = age;
            Weight = weight;
            Height = height;
            EyeColor = eyeColor;
            HairColor = hairColor;
        }

        /*public int Calc1(int age, double weight) {
            if (age > 50 && weight < 60.00) {
                n++;
            }
            return n;
        }

        public double Calc2(double Height) {
            double totalHeight = 0;
            double n = 0;
            double avg;
            if (Height < 1.50) {
                totalHeight += Height;
                n++;
            }
            avg = totalHeight / n;
            return avg;
        }*/


    }
}
