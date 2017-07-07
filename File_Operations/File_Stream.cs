using System;
using System.IO;

namespace File_Operations
{
    class File_Stream
    {
        public static void Example()
        {

            FileStream fs = new FileStream("test.dat", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            for (int i = 0; i < 20; i++)
            {
                fs.WriteByte((byte)i);
            }
            fs.Position = 0;
            for (int i = 0; i < 20; i++)
            {
                Console.Write(fs.ReadByte() + " ");
            }
            fs.Close();
        }
    }
}
