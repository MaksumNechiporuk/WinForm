using System;
using System.Collections.Generic;
using System.Text;
using System.Data.Sql;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Retrieve the enumerator instance and then the data.
            SqlDataSourceEnumerator instance =
              SqlDataSourceEnumerator.Instance;
            System.Data.DataTable table = instance.GetDataSources();

            // Display the contents of the table.
            DisplayData(table);

            Console.WriteLine("Press any key to continue.");
            Console.ReadKey();

        }

        private static void DisplayData(System.Data.DataTable table)
        {
            foreach (System.Data.DataRow row in table.Rows)
            {
                foreach (System.Data.DataColumn col in table.Columns)
                {
                    Console.WriteLine("{0} = {1}", col.ColumnName, row[col]);
                }
                Console.WriteLine("============================");
            }
        }
    }
}
