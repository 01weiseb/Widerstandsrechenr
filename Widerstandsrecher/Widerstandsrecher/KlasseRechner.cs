using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Widerstandsrecher
{
    class KlasseRechner
    {
        private double r1;
        private double r2;
        private double rg;
        private bool pORs;

        public void rechneR()
        {
            if (this.pORs == false)
                this.rg = this.r1 + this.r2;
            else if (this.pORs == true)
            {
                this.rg = (this.r1 * this.r2) / (this.r1 + this.r2);
            }
        }
        public void setR1(double uebergabe)
        {
            this.r1 = uebergabe;
        }
        public void setR2(double uebergabe)
        {
            this.r2 = uebergabe;
        }
        public void setSorP(bool uebergabe)
        {
            this.pORs = uebergabe;
        }
        public double getRg()
        {
            return(this.rg);
        }
        
    }
}
