using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZwierzakDomowy
{
    internal class ZwierzakDomowy

    {

        public string nazwa;

        public string gatunek;

        public DateTime data_urodzenia;


        public ZwierzakDomowy(string nazwa, string gatunek, DateTime data_urodzenia)

        {

            this.nazwa = nazwa;

            this.gatunek = gatunek;

            this.data_urodzenia = data_urodzenia;

        }


        public int ObliczWiek()

        {

            DateTime dzisiaj = DateTime.Now;

            int wiek = dzisiaj.Year - data_urodzenia.Year;


            if (data_urodzenia > dzisiaj || wiek > 25)

            {

                throw new Exception("Błąd: Twój zwierzak JESZCZE nie żyje.");

            }


            return wiek;

        }


        public override string ToString()

        {

            try

            {

                int wiek = ObliczWiek();

                return $"{nazwa} ({gatunek}), wiek: {wiek} lat";

            }

            catch (Exception e)

            {

                return $"{nazwa} ({gatunek}), błąd: {e.Message}";

            }

        }

    }
}
