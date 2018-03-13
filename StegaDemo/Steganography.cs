using System;
using System.Drawing;

namespace StegaDemo
{
    public class MessageLengthException : Exception
    {
        public MessageLengthException() : base() { }
        public MessageLengthException(string message) : base(message) { }
    }

    abstract class Steganography
    {
        public static long GetLinearSize(Bitmap img) { return img.Width * img.Height; }

        public abstract void EncodeMessage(ref Bitmap img, string message);
        public abstract string DecodeMessage(Bitmap img);
    }
}
