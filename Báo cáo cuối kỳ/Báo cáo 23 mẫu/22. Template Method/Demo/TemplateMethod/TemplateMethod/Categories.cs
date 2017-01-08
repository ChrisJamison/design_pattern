using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod
{
    class Categories : DataAccessObject
    {
        public override void Select()
        {
            string sql = "select CategoryName from Categories";
            Console.WriteLine(sql);

        }

        public override void Process()
        {
            Console.WriteLine("processing result from table Categories");
        }
    }
}
