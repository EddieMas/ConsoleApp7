using System;

namespace Magazin
{
    internal class Shop
    {
        private string nazvanie;
        private string adress;
        private string opisanie;
        private string telefon;
        private string email;

        public string Nazvanie
        {
            get { return nazvanie; }
            set { nazvanie = value; }
        }
        public string Adress
        {
            get { return adress; }
            set { adress = value; }
        }
        public string Opisanie
        {
            get { return opisanie; }
            set { opisanie = value; }
        }
        public string Telefon
        {
            get { return telefon; }
            set { telefon = value; }
        }
        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public Shop()
        {
            this.Nazvanie = String.Empty;
            this.Adress = String.Empty;
            this.Opisanie = String.Empty;
            this.Telefon = String.Empty;
            this.Email = String.Empty;
        }
        public Shop(string nazvanie, string adress, string opisanie, string telefon, string email)
        {
            this.Nazvanie = nazvanie;
            this.Adress = adress;
            this.Opisanie = opisanie;
            this.Telefon = telefon;
            this.Email = email;
        }
        public Shop(Shop magazine)
        {
            this.Nazvanie = magazine.Nazvanie;
            this.Adress = magazine.Adress;
            this.Opisanie = magazine.Opisanie;
            this.Telefon = magazine.Telefon;
            this.Email = magazine.Email;
        }
        public void Vvod()
        {
            Console.Write("Vvedite nazvanie magazina: ");
            Nazvanie = Console.ReadLine();
            Console.Write("Vvedite adress magazina: ");
            Adress = Console.ReadLine();
            Console.Write("Vvedite opisanie magazina: ");
            Opisanie = Console.ReadLine();
            Console.Write("Vvedite nomer telefona magazina: ");
            Telefon = Console.ReadLine();
            Console.Write("Vvedite email magazina: ");
            Email = Console.ReadLine();
        }
        public void Vivod()
        {
            Console.WriteLine($"Nazvanie magazina: {Nazvanie}");
            Console.WriteLine($"Adress magazina: {Adress}");
            Console.WriteLine($"Opisanie magazina: {Opisanie}");
            Console.WriteLine($"Nomer telefona magazina: {Telefon}");
            Console.WriteLine($"Email magazina: {Email}");
        }
    }
}