using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecHexBin

{
    static class Conversor
    {   
        public static string decimalToBinary(ulong n)
        {
            string bin = "";
            if (n == 0)

            {
                return "0";
            }

            while (n != 1)

            {
                bin += Convert.ToString(n % 2);
                n = n / 2;
            }

            bin += "1";

            char[] binario = new char[bin.Length];

            binario = bin.ToCharArray();

            Array.Reverse(binario);

            return new string(binario);
        }

        public static string decimalToHexadecimal(ulong n)
        {

            int[] hexadecimal = new int[(int)Math.Floor(Math.Log(n, 16)) + 1];
            string hexad = "";
            while (n > 0)

            {
                for (int i = 0; i < hexadecimal.Length; i++)
                {
                    if (hexadecimal[i] == 16)
                    {
                        hexadecimal[i + 1]++;
                        hexadecimal[i] = 0;
                    }
                }
                hexadecimal[0]++;
                n--;
            }
            for (int i = 0; i < hexadecimal.Length; i++)
            {
                if (hexadecimal[i] == 16)
                {
                    hexadecimal[i + 1]++;
                    hexadecimal[i] = 0;
                }
            }
            Array.Reverse(hexadecimal);

            foreach (int i in hexadecimal)

            {
                switch (i)
                {
                    case 15:
                        hexad += "F";
                        break;
                    case 14:
                        hexad += "E";
                        break;
                    case 13:
                        hexad += "D";
                        break;
                    case 12:
                        hexad += "C";
                        break;
                    case 11:
                        hexad += "B";
                        break;
                    case 10:
                        hexad += "A";
                        break;
                    default:
                        hexad += Convert.ToString(i);
                        break;
                }
            }
            return hexad;
        }

        public static ulong binaryToDecimal(string bin)
        {
            ulong dec = 0;
            char[] binario = bin.ToCharArray();

            for (int i = 0; i < binario.Length; i++)
            {
                if (binario[i] == Convert.ToChar("1"))
                {
                    binario[i] = Convert.ToChar("0");
                    dec += (ulong)Convert.ToInt32(Math.Pow(2, binario.Length - (i + 1)));
                }
            }
            return dec;
        }

        public static ulong hexadecimalToDecimal(string hexadecimal)
        {
            ulong[] hexad = new ulong[hexadecimal.Length];
            ulong dec = 0;
            for (int i = 0; i < hexad.Length; i++)
            {
                if (hexadecimal[i] == Convert.ToChar("F"))
                {
                    hexad[i] = 15;
                }
                else if (hexadecimal[i] == Convert.ToChar("E"))
                {
                    hexad[i] = 14;
                }
                else if (hexadecimal[i] == Convert.ToChar("D"))
                {
                    hexad[i] = 13;
                }
                else if (hexadecimal[i] == Convert.ToChar("C"))
                {
                    hexad[i] = 12;
                }
                else if (hexadecimal[i] == Convert.ToChar("B"))
                {
                    hexad[i] = 11;
                }
                else if (hexadecimal[i] == Convert.ToChar("A"))
                {
                    hexad[i] = 10;
                }
                else
                {
                    hexad[i] = Convert.ToUInt32(Convert.ToString(hexadecimal[i]));
                }
            }
            Array.Reverse(hexad);
            for (int i = 0; i < hexad.Length; i++)
            {
                Console.WriteLine(hexad[i]);
                if (i == 0)
                {
                    dec += hexad[i];
                }
                else
                {
                    dec += hexad[i] * Convert.ToUInt32(Math.Pow(16, i));
                }
            }
            return dec;
        }
    }
}
