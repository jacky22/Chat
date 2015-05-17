using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatClient
{
    public class EncodingImage
    {
        public Bitmap EncodingImageForRecievedBuffer(byte[] buffer)
        {
            byte[] lengthOfRecievedBuffer = new byte[4];
            Buffer.BlockCopy(buffer, 0, lengthOfRecievedBuffer, 0, 4);
            int lengthOfRecievedBufferInt = BitConverter.ToInt32(lengthOfRecievedBuffer, 0);
            byte[] RecievedBuffer = new byte[lengthOfRecievedBufferInt];
            Buffer.BlockCopy(buffer, 4, RecievedBuffer, 0, RecievedBuffer.Length);
            TypeConverter tc = TypeDescriptor.GetConverter(typeof(Bitmap));
            Bitmap bitmap = (Bitmap)tc.ConvertFrom(RecievedBuffer);
            //bitmap.Save("C:\\image\\lol"+i+".bmp");
            return bitmap;
            //byte[] tempbuffer = new byte[1];
            //Array.Resize(ref tempbuffer, buffer);
            //Buffer.BlockCopy(buffer, 4, tempbuffer, 0, buffer.Length - 4);
            //TypeConverter tc2 = TypeDescriptor.GetConverter(typeof(Bitmap));
            //Bitmap bitmap = (Bitmap)tc.ConvertFrom(tempbuffer);
            //bitmap.Save("C:\\image\\lol.bmp");
        }
    }
}
