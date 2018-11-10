using System.Collections.Generic;
using waHaylliCore.DataAccess;
using waHaylliCore.EntityModel;

namespace waHaylliCore.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            DOUbigeo ubigeo = new DOUbigeo();
            List<Ubigeo> result=  ubigeo.SelectAll();

            foreach (var item in result)
            {
                System.Console.WriteLine(item.ToString());
            }

            System.Console.ReadLine();
            

        }
    }
}
