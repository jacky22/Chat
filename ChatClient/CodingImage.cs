using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatClient
{
    public class CodingImage
    {
        public byte[] CodingImages(Bitmap img)
        {
            TypeConverter tc = TypeDescriptor.GetConverter(typeof(Bitmap));
            byte[] MassOfPicture = (byte[])tc.ConvertTo(img, typeof(byte[]));
            int sizeOfPictureMass = MassOfPicture.Length;
            byte[] buffer = BitConverter.GetBytes(sizeOfPictureMass);
            Array.Resize(ref buffer, MassOfPicture.Length + 4);
            Buffer.BlockCopy(MassOfPicture, 0, buffer, 4, MassOfPicture.Length);
            return buffer;



            /*
            Bitmap image = new Bitmap(path);
            TypeConverter tc = TypeDescriptor.GetConverter(typeof(Bitmap));
            byte[] MassOfPicture = (byte[])tc.ConvertTo(image, typeof(byte[]));
            //byte lastindex = MassOfPicture[437453];
            return MassOfPicture;*/
        }
    }
}
