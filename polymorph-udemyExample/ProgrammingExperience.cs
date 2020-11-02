using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polymorph_udemyExample
{
    class ProgrammingExperience
    {
        private string pl;
        private int nowYr;
        private DateTime now;

        public string ProgrammingLanguage
        {
            get { return pl; }
            set { pl = value; }
        }
        public int YrStarted { get; set; }
        public int YrEnded { get; set; }

        public int YearsExperience
        {
            get
            {
                if (this.YrEnded * this.YrStarted > 0)
                    return this.YrEnded - this.YrStarted;
                else if (this.YrEnded == 0)
                {
                    now = DateTime.Now;
                    nowYr = now.Year;
                    return nowYr - this.YrStarted;
                }
                else
                {
                    return 0;
                }
            }
        }

    }
}
