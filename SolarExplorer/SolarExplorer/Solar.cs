using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SolarExplorer
{
    class Solar
    {
        //Image Property
        internal virtual Image ObjectImg { get; set; }

        //Object Name Property
        internal virtual string ObjectName { get; set; }

    }

    class Sun : Solar
    {
        internal override Image ObjectImg { get; set; }
        internal override string ObjectName { get; set; }

        public Sun()
        {
            ObjectImg = Properties.Resources.Sun;
            ObjectName = "Sun";

            
        }
    }
}
