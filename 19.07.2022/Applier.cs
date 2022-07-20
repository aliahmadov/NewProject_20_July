using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyekt
{
    public class Applier
    {
        public int Id { get; set; }

        public static int App_Id { get; set; } = 0;

        public Worker worker { get; set; }
        public Cv Cv { get; set; }

        public Applier()
        {
            Id = ++App_Id;
        }

        public void Show()
        {
            Console.WriteLine($@"
Muraciet ID:      {Id}
Worker:  {worker.Name} {worker.Surname} - Worker ID : {worker.Id}
CV: 
==============================================
");
            Cv.Show();
        }
    }
}
