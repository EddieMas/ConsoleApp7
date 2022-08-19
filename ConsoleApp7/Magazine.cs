using System;

namespace gazeta
{
    internal class Gazeta
    {
        private string nazvanie;
        private short god_osnavania;
        private string opisanie;
        private string telefon;
        private string email;
        public string Nazvanie
        {
            get { return nazvanie; }
            set { nazvanie = value; }
        }
        public short God_osnavania
        {
            get { return god_osnavania; }
            set { god_osnavania = value; }
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
        public Gazeta()
        {
            this.Nazvanie = String.Empty;
            this.God_osnavania = 0;
            this.Opisanie = String.Empty;
            this.Telefon = String.Empty;
            this.Email = String.Empty;
        }
        public Gazeta(string nazvanie, short god_osnavania, string opisanie, string telefon, string email)
        {
            this.Nazvanie = nazvanie;
            this.God_osnavania = god_osnavania;
            this.Opisanie = opisanie;
            this.Telefon = telefon;
            this.Email = email;
        }
        public Gazeta(Gazeta gazeta)
        {
            this.Nazvanie = gazeta.Nazvanie;
            this.God_osnavania = gazeta.God_osnavania;
            this.Opisanie = gazeta.Opisanie;
            this.Telefon = gazeta.Telefon;
            this.Email = gazeta.Email;
        }
        public void Vvod()
        {
            Console.Write("Vvedite nazvanie gazeti: ");
            Nazvanie = Console.ReadLine();
            Console.Write("Vvedite god osnavania gazeti: ");
            God_osnavania = short.Parse(Console.ReadLine());
            Console.Write("Vvedite opisanie gazeti: ");
            Opisanie = Console.ReadLine();
            Console.Write("Vvedite nomer telefona gazeti: ");
            Telefon = Console.ReadLine();
            Console.Write("Vvedite email gazeti: ");
            Email = Console.ReadLine();
        }
        public void Vivod()
        {
            Console.WriteLine($"Nazvanie gazeti: {Nazvanie}");
            Console.WriteLine($"God osnavania gazeti: {God_osnavania}");
            Console.WriteLine($"Opisanie gazeti: {Opisanie}");
            Console.WriteLine($"Nomer telefona gazeti: {Telefon}");
            Console.WriteLine($"Email gazeti: {Email}");
        }
    }
}