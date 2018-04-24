using System;
using System.Drawing;

namespace StegaDemo
{
    public static class SteganExtensions
    {
        public static bool GetBit(this byte b, int bitNumber)
        {
            return (b & (1 << bitNumber)) != 0;
        }
    }

    public class MessageLengthException : Exception
    {
        public MessageLengthException() : base() { }
        public MessageLengthException(string message) : base(message) { }
    }

    public abstract class Steganography
    {
        public static long GetLinearSize(Bitmap img) { return img.Width * img.Height; }

        public abstract Bitmap EncodeMessage(Bitmap img, string message);
        public abstract string DecodeMessage(Bitmap img);
    }
}
