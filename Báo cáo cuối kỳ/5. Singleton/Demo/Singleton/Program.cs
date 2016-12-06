using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            Table.Instance.Show();

            // Ta không thể tạo một thể hiện mới như thông thường
            // Tất cả phải sử dụng thông qua một thể hiện Instance được cung cấp từ lớp Singleton
            // Table table = new Table();

            Console.ReadLine();
        }
    }
}
