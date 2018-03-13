using System;
using System.Collections.Generic;
using System.Drawing;

namespace StegaDemo.SteganographyMethods
{
    class LSBSteganography : Steganography
    {
        public override void EncodeMessage(ref Bitmap img, string message)
        {
            if (GetLinearSize(img) < message.Length)
                throw new MessageLengthException("The linear size of the image is smaller than the message length");



        }

        public override string DecodeMessage(Bitmap img)
        {
            return "";
        }
    }
}
