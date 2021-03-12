using System;
using System.Collections.Generic;
using System.Text;

namespace Rejestr_osobowy
{
    public class Person
    {
        public const string UNDEFINED_STRING = "[Niezdefiniowano]";
        public int Id { get; set; }
        private string m_sName;
        private string m_sSurname;
        private int m_iAge;
        private string m_sGender;

        public Person()
        {

        }
        public int Age
        {
            get => m_iAge;
            set
            {
                if (value < 0 || value > 150)
                    throw new Exception("Pole <Wiek> musi zawierac sie w zakresie od 0 do 150");

                m_iAge = value;
            }
        }
        public string Name
        {
            get => m_sName;
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new Exception("Pole <Imie> nie może być puste");
                else if (value.Length > 30)
                    throw new Exception("Pole <Imie> nie może mieć wiecej niz 30 znakow");

                m_sName = value;
            }
        }
        public string Surname
        {
            get => m_sSurname;
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new Exception("Pole <Nazwisko> nie może być puste");
                else if (value.Length > 50)
                    throw new Exception("Pole <Nazwisko> nie może mieć wiecej niz 50 znakow");

                m_sSurname = value;
            }
        }
        public string Gender
        {
            get => m_sGender;
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new Exception("Pole <Plec> nie może być puste");
                else if (value.Length > 20)
                    throw new Exception("Pole <Plec> nie może mieć wiecej niz 20 znakow");

                m_sGender = value;
            }
        }
        public Person(int id, string name, string surname, int age, string gender)
        {
            Id = id;
            Name = name;
            Surname = surname;
            Age = age;
            Gender = gender;
        }
        




        public override string ToString()
        {
            return $"Imie:{Name} Nazwisko:{Surname} Wiek:{Age} Plec:{Gender}";
        }

        public void AssertObject()
        {

            if (Name == UNDEFINED_STRING)
                throw new Exception("Nie zainicjalizowano pola <Imie>!");
            if (Surname == UNDEFINED_STRING)
                throw new Exception("Nie zainicjalizowano pola <Nazwisko>!");
            if (Age == -1)
                throw new Exception("Nie zainicjalizowano pola <Wiek>!");
            if (Gender == UNDEFINED_STRING)
                throw new Exception("Nie zainicjalizowano pola <Plec>!");
        }
        public void ChangeName(string Name)
        {
            this.Name = Name;
        }
    }

    /*public class Adress : Person
    {
        private string m_sStreet;
        private string m_sNumber;
        private string m_sPostCode;
        private string m_sCity;
        private string m_sCountry;
        public string Street
        {
            get => m_sStreet;
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new Exception("Pole <Ulica> nie może być puste");
                else if (value.Length > 50)
                    throw new Exception("Pole <Ulica> nie może mieć wiecej niz 50 znakow");

                m_sStreet = value;
            }

        }
        public string Number
        {
            get => m_sNumber;
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new Exception("Pole <Numer> nie może być puste");
                else if (value.Length > 10)
                    throw new Exception("Pole <Numer> nie może mieć wiecej niz 10 znakow");

                m_sNumber = value;
            }

        }
        public string PostCode
        {
            get => m_sPostCode;
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new Exception("Pole <Kod pocztowy> nie może być puste");
                else if (value.Length > 10)
                    throw new Exception("Pole <Kod pocztowy> nie może mieć wiecej niz 10 znakow");

                m_sPostCode = value;
            }

        }
        public string City
        {
            get => m_sCity;
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new Exception("Pole <Kod pocztowy> nie może być puste");
                else if (value.Length > 100)
                    throw new Exception("Pole <Kod pocztowy> nie może mieć wiecej niz 100 znakow");

                m_sCity = value;
            }

        }
        public string Country
        {
            get => m_sCountry;
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new Exception("Pole <Kod pocztowy> nie może być puste");
                else if (value.Length > 50)
                    throw new Exception("Pole <Kod pocztowy> nie może mieć wiecej niz 50 znakow");

                m_sCountry = value;
            }

        }

    }*/
}

