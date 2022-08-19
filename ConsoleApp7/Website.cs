using System;

namespace WebSite
{
    internal class Website
    {
        private string nazvanie;
        private string put;
        private string opisanie;
        private string ip;
        public string Nazvanie
        {
            get { return nazvanie; }
            set { nazvanie = value; }
        }
        public string Put
        {
            get { return put; }
            set { put = value; }
        }
        public string Opisanie
        {
            get { return opisanie; }
            set { opisanie = value; }
        }
        public string IP
        {
            get { return ip; }
            set { ip = value; }
        }
        public Website()
        {
            this.Nazvanie = String.Empty;
            this.Put = String.Empty;
            this.Opisanie = String.Empty;
            this.IP = String.Empty;
        }
        public Website(string nazvanie, string put, string opisanie, string ip)
        {
            this.Nazvanie = nazvanie;
            this.Put = put;
            this.Opisanie = opisanie;
            this.IP = ip;
        }
        public Website(Website website)
        {
            this.Nazvanie = website.Nazvanie;
            this.Put = website.Put;
            this.Opisanie = website.Opisanie;
            this.IP = website.IP;
        }
        public void Vvod()
        {
            Console.Write("Vvedite nazvanie saita: ");
            Nazvanie = Console.ReadLine();
            Console.Write("Vvedite put saita: ");
            Put = Console.ReadLine();
            Console.Write("Vvedite opisanie: ");
            Opisanie = Console.ReadLine();
            Console.Write("Vvedite ip saita: ");
            IP = Console.ReadLine();
        }
        public void Vivod()
        {
            Console.WriteLine($"Nazvanie saita: {Nazvanie}");
            Console.WriteLine($"Put saita: {Put}");
            Console.WriteLine($"Opisanie saita: {Opisanie}");
            Console.WriteLine($"IP saita: {IP}");
        }
    }
}