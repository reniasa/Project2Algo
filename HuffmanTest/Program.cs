using System;
using System.Collections;

namespace HuffmanTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Give a word to encode and decode: ");
            var input = Console.ReadLine();
            Tree huffmanTree = new Tree();

            huffmanTree.Build(input);

            BitArray encoded = huffmanTree.Encode(input);

            Console.Write("Encoded: ");
            foreach (bool bit in encoded)
            {
                Console.Write((bit ? 1 : 0) + "");
            }
            Console.WriteLine();

            string decoded = huffmanTree.Decode(encoded);

            Console.WriteLine("Decoded: " + decoded);

            Console.ReadLine();
        }
    }
}
