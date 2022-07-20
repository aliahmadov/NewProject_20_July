using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyekt
{
    class Helper
    {
        public static Vacancies GetVacanciesByID(Employer employer, int id)
        {
            for (int i = 0; i < employer.Vacancie.Count; i++)
            {
                if (employer.Vacancie[i].Id == id)
                {
                    return employer.Vacancie[i];
                }
            }
            return null;
        }

        public static Cv GetCVByID(Worker worker, int id)
        {
            for (int i = 0; i < worker.cv.Count; i++)
            {
                if (worker.cv[i].Id == id)
                {
                    return worker.cv[i];
                }
            }
            return null;
        }

        public static Employer GetEmployer(List<Human> humans, int vacancy_id)
        {
            foreach (var human in humans)
            {
                if (human is Employer)
                {
                    Employer employer = (Employer)human;
                    for (int i = 0; i < employer.Vacancie.Count; i++)
                    {
                        if (employer.Vacancie[i].Id == vacancy_id)
                        {
                            return employer;
                        }
                    }
                }
            }
            return null;
        }
    }
}
