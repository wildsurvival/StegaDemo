using System;
using System.Collections.Generic;
using System.IO;
using System.Drawing;
using System.Drawing.Imaging;

using StegaDemo;

namespace StegaDemo.SteganographyMethods
{
    public class LSBSteganography : Steganography
    {
        private const int BITMAP_HEADER_OFFSET = 54;

        public override Bitmap EncodeMessage(Bitmap img, string message)
        {
            // Add 8 trailing 0 bits for 
            message += "00000000";

            if (GetLinearSize(img) < message.Length)
                throw new MessageLengthException("The linear size of the image is smaller than the message length");

            Bitmap newImg;
            using (MemoryStream stream = new MemoryStream())
            {
                img.Save(stream, ImageFormat.Bmp);
                byte[] buffer = stream.GetBuffer();

                for (int i=0; i < buffer.Length; i++)
                {
                    byte currentChar = (byte)char.GetNumericValue(message[i / 8]);
                    int currentBit = i % 8;

                    bool bit = currentChar.GetBit(currentBit);
                    byte channelByte = buffer[BITMAP_HEADER_OFFSET + i];

                    if (bit == true)
                        buffer[BITMAP_HEADER_OFFSET + i] = (byte)(channelByte | 1);
                    else
                        buffer[BITMAP_HEADER_OFFSET + i] = (byte)(channelByte & ~1);
                }

                return newImg = new Bitmap(stream);
            }
        }

        public override string DecodeMessage(Bitmap img)
        {
            return "";
        }

        public override string ToString()
        {
            return "LSB";
        }
    }
}
