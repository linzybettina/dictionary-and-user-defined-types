using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace collections_dictionary
{
    class Program
    {
        static void Main()
        {
            Dictionary<string, object> dt = new Dictionary<string, object>();//to store the list in sequential order 
            dt.Add("Eid", "1234");
            dt.Add("Ename", "sajan");
            dt.Add("job", "software Developer");
            dt.Add("Salary", "4320");
            dt.Add("sdrid", "78");
            dt.Add("phone", "3434343");
            dt.Add("email", "vethakumarsajan@gmail.com");
            foreach (string k in dt.Keys)
            Console.WriteLine(k+":"+ dt[k]);
            Console.ReadLine();
        }
    }
}
