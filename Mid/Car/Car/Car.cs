using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car
{
    [Serializable]
    class Car
    {
        static int XDim, YDim;
        static int body;
        public object car;
        public int cnt = 1;
     
        //  static Car() { }
        static Car()
        {
            List<car> list = new List<car>;
            Car car = new Car();

        }

        public void CollisionWithWall()
        {
            if (car[XDim] == Console.WindowWidth)
                cnt++;

        }

        public void Draw()
        {
            car.Draw();
            Console.WriteLine("00" +
                "*******" +
                "00");
        }      
    }
}
