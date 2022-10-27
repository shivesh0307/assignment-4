using System;

namespace TempService
{
    public  class Temp
    {
        public  double CTF(double temp)
        {
            double ftemp = temp * 9.0 / 5.0;
            ftemp += 32;
            return ftemp;
        }
        public double FTD(double temp)
        {
            double ctemp = (temp - 32) * 5.0 / 9.0;
           
            return ctemp;
        }
    }
}
