using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    public class pelmeshka
    {
        double dolya_myasa;
        double kg;
        public double getKg()
        {
            return this.kg;
        }
        public void setKg(double kgU)
        {
            if(kgU < 0)
            {
            
            }
            else
            {
                this.kg = kgU;
            }
        }
        string name;
        public pelmeshka(double dolya_myasa, double kg, string name)
        {
            this.dolya_myasa = dolya_myasa;
            this.kg = kg;
            this.name = name;
        }
        public void Plus(pelmeshka Arg)
        {
            this.kg += Arg.kg;
            this.dolya_myasa += Arg.dolya_myasa;
            this.name += Arg.name;
        }
        public string Print()
        {
            return this.name + " " + this.kg + " " + this.dolya_myasa;
        }
    }
}
