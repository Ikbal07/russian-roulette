using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iqbal_Russian_Roullete
{
    class chamber
    {
        public int spinnerchamber(int spinbullete)
        {
            if (spinbullete == 6)
            {
                spinbullete = 1;

            }
            else
            {
                spinbullete++;
            }

            return spinbullete;
        }
    }
}
