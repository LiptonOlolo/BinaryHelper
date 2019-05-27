﻿using BinaryHelper;
using System;

namespace Tests
{
    class Program
    {
        static void Main(string[] args)
        {
            var br = new BinaryReaderExtended("player.bin");

            var offset = br.FindPosition(new byte[] { 0x6D, 0x06F, 0x6E, 0x65, 0x79 }, resetPosition: false); //money
            if (offset)
                Console.WriteLine($"Money: {br.ReadInt32()}");

            offset = br.FindPosition(new byte[] { 0x68, 0x70 }, resetPosition: false); //hp
            if (offset)
                Console.WriteLine($"HP: {br.ReadByte()}");

            br.Dispose();
        }
    }
}
