using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InternKPIEcreo.DatabasePopulation;
using InternKPIEcreo.EntityFramework;

namespace InternKPIEcreo
{
    class Program
    {
        static void Main(string[] args)
        {
            var _loginToken = TeamworkLoginToken.LoginToken("wine982pizza");

            var test = CompanyPopulation.CompanyUpdateList(_loginToken);
            foreach (var vartest in test)
            {
                Console.WriteLine(vartest);
            }
            ProjectPopulation.ProjectUpdateList(_loginToken);

        }
    }
}
