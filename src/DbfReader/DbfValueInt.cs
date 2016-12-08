﻿using System.IO;

namespace DbfReader
{
    public class DbfValueInt : DbfValue<int?>
    {
        public override void Read(BinaryReader binaryReader)
        {
            if (binaryReader.PeekChar() == '\0')
            {
                binaryReader.ReadBytes(2);
                Value = null;
            }
            else
            {
                Value = binaryReader.ReadInt16();
            }
        }
    }
}