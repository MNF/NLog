using System;
using System.IO;
using System.Text;

namespace NLog.UnitTests.Common
{
    public class TextWriterThrowingOutOfMemoryException : TextWriter
    {
        public override void Write(char value)
        {
            throw new OutOfMemoryException();
        }
        public override Encoding Encoding
        {
            get { throw new OutOfMemoryException(); }
        }
    }
}