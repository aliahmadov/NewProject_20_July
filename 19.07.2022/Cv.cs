using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyekt
{
    public class Cv
    {
        public int Id { get; set; }

        public static int Cv_Id { get; set; }
        public string Qualification { get; set; }
        public string School { get; set; }
        public double Uniscore { get; set; }
        public List<string> Skills { get; set; }
        public List<Companies> companies { get; set; }


        public Cv()
        {
            Id = ++Cv_Id;
        }
        public void Show()
        {
            Console.WriteLine($@"---------------------------
ID:         {Id}
Ixtisas :   {Qualification}
School  :   {School}
UniScore :  {Uniscore}
Skills:
");
            foreach (string skill in Skills)
            {
                Console.WriteLine(skill);
            }
            Console.WriteLine("Companies");
            foreach (Companies companies in companies)
            {
                Console.WriteLine(companies);
                companies.Show();
            }

        }


    }
}
