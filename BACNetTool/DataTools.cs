using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BACNetTool
{
    class DataTools
    {

        /// <summary>
        /// Takes a binary array and returns an decimal value
        /// </summary>
        /// <param name="bArray"></param>
        /// <returns></returns>
        public static int binToDec(int[] bArray)
        {
            int retVal = 0;

            for (int i = bArray.Length - 1; i >= 0; --i)
            {
                retVal += bArray[i] * (int)Math.Pow(2, bArray.Length - i - 1);
            }

            return retVal;
        }

        /// <summary>
        /// Takes a decimal value and returns an array in binary
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static int[] decToBin(int value)
        {
            int remainder;
            String result = String.Empty;

            while (value > 0)
            {
                remainder = value % 2;
                value /= 2;
                result = remainder.ToString() + result;
            }

            int[] bArray = new int[result.Length];

            for (int i = 0; i < bArray.Length; ++i)
            {
                bArray[i] = Convert.ToInt32(result[i].ToString());
            }

            foreach(int b in bArray)
            {
                Debug.Print(b.ToString());
            }

            return bArray;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static int[] hexToBin(String value)
        {
            int decVal = Convert.ToInt32("0x" + value, 16);
            Console.WriteLine("This is test: " + decVal);
            return decToBin(decVal);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="bArray"></param>
        /// <returns></returns>
        public static String binToHex(int bArray)
        {
            return "a";
        }

        /// <summary>
        /// Default method removes the first 4 bits from the passed array and returns the remainder
        /// </summary>
        /// <param name="bArray"></param>
        /// <returns></returns>
        public static int[] removeBits(int[] bArray)
        {
            return removeBits(bArray, 4);
        }

        /// <summary>
        /// Overloaded method removes the x numBits from the passed array and returns the remainder
        /// </summary>
        /// <param name="bArray"></param>
        /// <param name="numBits"></param>
        /// <returns></returns>
        public static int[] removeBits(int[] bArray, int numBits)
        {
            int[] retval = new int[bArray.Length - 4];

            for (int i = 0; i < retval.Length; ++i)
            {
                retval[i] = bArray[i + 4];
            }

            return retval;
        }

        public static int[] removeOctet(int[] data)
        {
            int[] retVal = new int[data.Length - 1];

            for (int i = 0; i < retVal.Length; ++i)
            {
                retVal[i] = data[i + 1];
            }

            return retVal;
        }

        public static int[] removeOctet(int[] data, int numOctets)
        {
            int[] retVal = new int[data.Length - numOctets];

            for (int i = 0; i < retVal.Length; ++i)
            {
                retVal[i] = data[i + numOctets];
            }

            return retVal;
        }

        public static int[] decimalToBinaryArrayInt(int value)
        {
            int remainder;
            String result = String.Empty;

            while (value > 0)
            {
                remainder = value % 2;
                value /= 2;
                result = remainder.ToString() + result;
            }

            while (result.Length != 8)
            {
                result = 0 + result;
            }

            int[] bArray = new int[result.Length];

            for (int i = 0; i < bArray.Length; ++i)
            {
                bArray[i] = Convert.ToInt32(result[i].ToString());
            }

            return bArray;
        }

        public static String decimalToBinaryArrayString(int value)
        {
            int remainder;
            String result = String.Empty;

            while (value > 0)
            {
                remainder = value % 2;
                value /= 2;
                result = remainder.ToString() + result;
            }

            while (result.Length != 8)
            {
                result = 0 + result;
            }

            return result;
        }

        public static String decimalArrayToHexString(int[] data, int length)
        {
            String retVal = "0x";
            for (int i = 0; i < length; ++i)
            {
                retVal += data[i].ToString("X");
            }

            return retVal;
        }

        public static String decimalArrayToHexString2(int[] data, int length)
        {
            String retVal = "";
            for (int i = 0; i < length; ++i)
            {
                if (data[i] < 10)
                {
                    retVal += "0";
                }

                retVal += data[i].ToString("X");
            }

            return retVal;
        }

        public static int[] hexStringToIntArray(String hexDump)
        {
            if (hexDump.Length % 2 != 0)
            {
                Console.WriteLine("Error, hexDump should be modulus 2!");
            }

            int[] retVal = new int[hexDump.Length / 2];

            for (int i = 0; i < hexDump.Length / 2; ++i)
            {
                String s = "0x" + hexDump.Substring(i * 2, 2);
                retVal[i] = Convert.ToInt32(s, 16);
            }

            return retVal;
        }

    }
}
