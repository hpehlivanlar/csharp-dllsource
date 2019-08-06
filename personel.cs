using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dll_kaynak
{
    public class Personel
    {

        private int no { get; set; }

        public int NO {
            get { return no; }
            set { no = value; }

        }

        public  string Ad { get; set; }
        protected string Soyad { get; set; }

    }

   public class Veri<TMesai, TSaat>
    {
        public  T Hesapla<T>(ref T a, ref T b)
        {
            T maas = (T)(object)0;

            if (typeof(T) == typeof(int))
            {

                maas = (T)(Object)((int)(Object)a * (int)(Object)b);
                return maas;

            }

            if (typeof(T) == typeof(double))
            {
                maas = (T)(Object)((double)(Object)a * (double)(Object)b);
                return maas;
            }

            return maas;

        }


    }

}
