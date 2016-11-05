using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Protection_Proxy
{
    //Proxy Class.
    public class ProxyImage : Image
    {
        RealImage realImage;
        string url;

        public ProxyImage(string url)
        {
            this.url = url;
            string message = string.Format("{0}: {1}",
                DateTime.Now.ToString("yyyy/MM/dd hh:mm:ss.fff"),
                "Hinh anh chua duoc load");

            Console.WriteLine(message);
        }

        public void ShowImage()
        {
            if (this.realImage == null)
            {
                this.realImage = new RealImage(this.url);
            }
            else if (this.realImage != null)
            {
                string message = string.Format("{0}: {1}",
                    DateTime.Now.ToString("yyyy/MM/dd hh:mm:ss.fff"),
                    "Hinh anh da duoc load, chi can lay ra va su dung");

                Console.WriteLine(message);
            }
        }

        public void ShowImages()
        {
            if (this.realImage == null)
            {
                this.realImage = new RealImage(this.url);
            }
            else if (this.realImage != null)
            {
                string message = string.Format("{0}: {1}",
                    DateTime.Now.ToString("yyyy/MM/dd hh:mm:ss.fff"),
                    "Hinh anh da duoc load, chi can lay ra va su dung");

                Console.WriteLine(message);
            }
        }
    }

    // Real Class
    public class RealImage : Image
    {
        string url;
        
        public RealImage(string url)
        {
            string message = string.Format("{0}: Hinh anh {1} vua duoc khoi tao",
                DateTime.Now.ToString("yyyy/MM/dd hh:mm:ss.fff"), url);
            Console.WriteLine(message);

            this.url = url;
        }

        public void ShowImages()
        {
            string message = string.Format("{0}: Hinh anh {1} duoc load thanh cong",
                DateTime.Now.ToString("yyyy/MM/dd hh:mm:ss.fff"), url);
            Console.WriteLine(message);
        }
    }

    public interface Image
    {
        void ShowImages();
    }
    
    class Client
    {
        static void Main(string[] args)
        {
            // Khởi tạo Proxy, Lúc này image chưa được load
            ProxyImage image = new ProxyImage("C:\\Hinh_anh.jpg");

            // Khi cần show image, lúc này hình ảnh mới thật sự được load
            image.ShowImages();

            // Khi ta sử lần tiếp theo, image không cần load lại nữa, 
            // chỉ lấy image được cache trong proxy ra sử dụng
            image.ShowImages();

            Console.ReadLine();
        }
    }
}
