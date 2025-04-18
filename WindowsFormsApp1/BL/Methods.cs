using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.BL
{
    public class Methods
    {
     public MemoryStream ma = new MemoryStream();
     public byte[] by;


    public byte[] Convert_byte()
        { return ma.ToArray(); }


     public MemoryStream Convert_image() {
            
            ma = new MemoryStream(by);
            return ma;
        
        }


    }
}
