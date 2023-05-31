using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace SMP.BL
{
    public class Methods
    {
      public  MemoryStream ma = new MemoryStream();
        public byte[] by;
        public byte[] convertbyte()
        {
            return ma.ToArray();    
        }
        public MemoryStream convert_image()
        {
            ma =new MemoryStream(by);
            return ma;
        }

    }

}
