﻿using System;
using System.Globalization;
using System.IO;

namespace DbfReader
{
    public class DbfValueDate : DbfValue<DateTime?>
    {
        public override void Read(BinaryReader binaryReader)
        {
            var value = new string(binaryReader.ReadChars(8));
            value = value.TrimEnd((char)0);

            Console.WriteLine($"DbfValueDate: {value}");

            if (string.IsNullOrWhiteSpace(value))
            {
                Value = null;
            }
            else
            {
                Value = DateTime.ParseExact(value, "yyyyMMdd", null, DateTimeStyles.AllowLeadingWhite | DateTimeStyles.AllowTrailingWhite);
            }
        }
    }
}