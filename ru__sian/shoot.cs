using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ru__sian
{
    class shoot
    {
        public int  loaded, Spined;
        public int Spin;
        public int Point;
        public static int r = 2;
        public static int Shoot = 0;
        Random rnd = new Random();
      

        public void try_again()
        {
            Shoot = 0;
        }
        public int Spin_Chamber()
        {
            Random rnd = new Random();
            Spin = rnd.Next(1, 7);
            return Spin;
        }



        public int shooterr(int load,int Spinm)
        {


            if (Shoot == 0 && load == Spin)
            {
                Shoot = 3;
                Point = 10;
            }
            else if (Shoot == 1 && load != Spin)
            {
                Point = 0;
            }

            else if (Shoot == 1 && load == Spin)
            {
                Shoot = 3;
                Point = 5;
            }

            else
            {
                Shoot++;

            }


           
            return Point;
        }
        

        }

    }

