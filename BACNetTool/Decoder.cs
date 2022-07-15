using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace BACNetTool
{
    public enum TagNumber
    {
        Null = 0,
        Boolean = 1,
        UnsignedInteger = 2,
        SignedInteger = 3,
        Real = 4,
        Double = 5,
        OctetString = 6,
        CharacterString = 7,
        BitString = 8,
        Enumerated = 9,
        Date = 10,
        Time = 11,
        BACnetObjectIdentifier = 12,
        Reserved1 = 13,
        Reserved2 = 14,
        Reserved3 = 15
    }

    public enum TagClass
    {
        ApplicationTag = 0,
        ContextTag = 1
    }

    public enum BACnetObjectType
    {
        AccessCredential = 32,
        AccessDoor = 30,
        AccessPoint = 33,
        AccessRights = 34,
        AccessUser = 35,
        AccessZone = 36,
        Accumulator = 23,
        AlertEnrollment = 52,
        AnalogInput = 0,
        AnalogOutput = 1,
        AnalogValue = 2,
        Averaging = 18,
        BinaryInput = 3,
        BinaryLightingOutput = 55,
        BinaryOutput = 4,
        BinaryValue = 5,
        BitstringValue = 39,
        Calendar = 6,
        Channel = 53,
        CharacterstringValue = 40,
        Command = 7,
        CredentialDataInput = 37,
        DatepatternValue = 41,
        DateValue = 42,
        DatetimepatternValue = 43,
        DatetimeValue = 44,
        Device = 8,
        ElevatorGroup = 57,
        Escalator = 58,
        EventEnrollment = 9,
        EventLog = 25,
        File = 10,
        GlobalGroup = 26,
        Group = 11,
        IntegerValue = 45,
        LargeAnalogValue = 46,
        LifeSafetyPoint = 21,
        LifeSafetyZone = 22,
        Lift = 59,
        LightingOutput = 54,
        LoadControl = 28,
        Loop = 12,
        MultiStateInput = 13,
        MultiStateOutput = 14,
        MultiStateValue = 19,
        NetworkPort = 56,
        NetworkSecurity = 38,
        NotificationClass = 15,
        NotificationForwarder = 51,
        OctetstringValue = 47,
        PositiveIntegerValue = 48,
        Program = 16,
        PulseConverter = 24,
        Schedule = 17,
        StructuredView = 29,
        TimepatternValue = 49,
        TimeValue = 50,
        Timer = 31,
        TrendLog = 20,
        TrendLogMultiple = 27
    }

    class BACnetObjectIdentifier
    {
        public BACnetObjectType objectType;
        public int instanceNumber;

        public BACnetObjectIdentifier(int[] data)
        {
            int[] newData = new int[data.Length * 8];
            int[] arr = new int[8];

            for (int i = 0; i < data.Length; ++i)
            {
                arr = DataTools.decimalToBinaryArrayInt(data[i]);
                for (int j = 0; j < arr.Length; ++j)
                {
                    newData[i * 8 + j] = arr[j];
                }
            }

            int[] type = new int[10];
            int[] num = new int[22];

            for (int i = 0; i < newData.Length; ++i)
            {
                if (i < 10)
                {
                    type[i] = newData[i];
                }
                else
                {
                    num[i - 10] = newData[i];
                }
            }

            instanceNumber = DataTools.binToDec(num);
            objectType = (BACnetObjectType)DataTools.binToDec(type);
        }

        public String ToString()
        {
            return ("objectType: " + objectType.ToString() + "\tinstanceNumber: " + instanceNumber);
        }
    }

    class Date
    {
        int year;
        public String date;

        public Date(int[] data)
        {
            date = String.Empty;

            year = 1900 + data[0];

            date += ((Month)data[1]).ToString() + " " + ((Day)data[2]).ToString() + ", ";

            if (data[0] == 255)
                date += "Unspecified; ";
            else
                date += year + "; ";

            date += ((DayOfWeek)data[3]).ToString();
        }
    }

    public enum Month
    {
        January = 1,
        February = 2,
        March = 3,
        April = 4,
        May = 5,
        June = 6,
        July = 7,
        August = 8,
        September = 9,
        October = 10,
        November = 11,
        December = 12,
        Odd_Months = 13,
        Even_Months = 14,
        Unspecified = 255
    }

    public enum Day
    {
        First = 1,
        Second = 2,
        Third = 3,
        Fourth = 4,
        Fifth = 5,
        Sixth = 6,
        Seventh = 7,
        Eighth = 8,
        Ninth = 9,
        Tenth = 10,
        Eleventh = 11,
        Twelfth = 12,
        Thirteenth = 13,
        Fourteenth = 14,
        Fifteenth = 15,
        Sixteenth = 16,
        Seventeenth = 17,
        Eighteenth = 18,
        Ninteenth = 19,
        Twentieth = 20,
        Twenty_First = 21,
        Twenty_Second = 22,
        Twenty_Third = 23,
        Twenty_Fourth = 24,
        Twenty_Fifth = 25,
        Twenty_Sixth = 26,
        Twenty_Seventh = 27,
        Twenty_Eighth = 28,
        Twenty_Ninth = 29,
        Thirtieth = 30,
        Thirty_First = 31,
        Last_Day_Of_Month = 32,
        Odd_Days = 33,
        Even_Days = 34,
        Unspecified = 255
    }

    public enum DayOfWeek
    {
        Monday = 1,
        Tuesday = 2,
        Wednesday = 3,
        Thursday = 4,
        Friday = 5,
        Saturday = 6,
        Sunday = 7,
        Unspecified = 255
    }

    class Decoder
    {
        public TagNumber tagNumber;
        public TagClass tagClass;
        public int length;
        public int[] newData;

        public Decoder(int[] data)
        {
            int[] BACnetTag = DataTools.decimalToBinaryArrayInt(data[0]);
            for (int i = 0; i < BACnetTag.Length; ++i)
                Console.WriteLine("BacnetTag[" + i + "]: " + BACnetTag[i]);

            int[] tagNo = { BACnetTag[0], BACnetTag[1], BACnetTag[2], BACnetTag[3] };
            int tagC = BACnetTag[4];
            int[] tagLen = { BACnetTag[5], BACnetTag[6], BACnetTag[7] };

            tagNumber = (TagNumber)DataTools.binToDec(tagNo);
            tagClass = (TagClass)tagC;
            length = DataTools.binToDec(tagLen);

            Console.WriteLine("Tag Number: " + tagNumber + "\nTag Class: " + tagClass + "\nLength: " + length);

            // Context Tag
            if (tagClass != 0)
            {

            }
            // Application Tag
            else
            {
                newData = DataTools.removeOctet(data);

                // if length is 5 then check the next octet for the extension on how many octects the data length is
                if (length == 5)
                {
                    if (newData[0] < 254)
                    {
                        length = newData[0];
                        newData = DataTools.removeOctet(newData);
                    }
                    // if length is 254, then check the next two octets for the extension
                    else if (newData[0] == 254)
                    {
                        length = (256 * newData[1]) + newData[2];
                        newData = DataTools.removeOctet(newData, 3);
                    }
                    // if length is 255, the check the next four octets for the extension
                    else if (newData[0] == 255)
                    {
                        length = (256 * 256 * 256 * newData[1]) + (256 * 256 * newData[2]) + (256 * newData[3]) + newData[4];
                        newData = DataTools.removeOctet(newData, 5);
                    }
                }

                switch (tagNumber)
                {
                    case TagNumber.Null:
                        decodeNull();
                        break;
                    case TagNumber.Boolean:
                        decodeBoolean(length);
                        break;
                    case TagNumber.UnsignedInteger:
                        decodeUnsignedInt(newData);
                        break;
                    case TagNumber.SignedInteger:
                        decodeSignedInt(newData);
                        break;
                    case TagNumber.Real:
                        decodeRealNumber(newData);
                        break;
                    case TagNumber.Double:
                        decodeDouble(newData);
                        break;
                    case TagNumber.OctetString:
                        decodeOctetString(newData);
                        break;
                    case TagNumber.CharacterString:
                        decodeCharacterString(newData);
                        break;
                    case TagNumber.BitString:
                        decodeBitString(newData);
                        break;
                    case TagNumber.Enumerated:
                        decodeEnumerated(newData);
                        break;
                    case TagNumber.Date:
                        decodeDate(newData);
                        break;
                    case TagNumber.Time:
                        decodeTime(newData);
                        break;
                    case TagNumber.BACnetObjectIdentifier:
                        decodeBACnetObjectIdentifier(newData);
                        break;
                    default:
                        break;
                }
            }
        }

        public int[] decodeNull()
        {
            Console.WriteLine("Null");
            return newData;
        }

        // tag is 0 // Joshua Call
        public string decodeNull(int[] data)
        {
            //Question: How should we return the null? Seems to me we could even catch this 
            //in the previous step without needing a function. For now, I'm just returning a 
            //string "Null"
            return "NULL";
        }

        // tag is 1 // Joshua Call
        // TODO: review decodeBoolean
        public int[] decodeBoolean(int value)
        {
            Console.Write("decodeBoolean: ");

            if (value == 1)
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("false");
            }

            return newData;
        }

        // TODO: review decodeUnsignedInt
        public uint decodeUnsignedInt(int[] data)
        {
            int[] binaryData = new int[8 * length];
            int[] octetData = new int[8];

            for (int i = 0; i < length; ++i)
            {
                octetData = DataTools.decimalToBinaryArrayInt(data[i]);

                for (int j = 0; j < 8; ++j)
                {
                    binaryData[(8 * i) + j] = octetData[j];
                }
            }

            uint retVal = (uint)DataTools.binToDec(binaryData);
            Console.WriteLine("decodeUnsignedInt: " + retVal);

            return retVal;
        }

        // overloaded method for decoding other tags in BACnetTags.cs
        public uint decodeUnsignedInt(int[] data, int length)
        {
            int[] binaryData = new int[8 * length];
            int[] octetData = new int[8];

            for (int i = 0; i < length; ++i)
            {
                octetData = DataTools.decimalToBinaryArrayInt(data[i]);

                for (int j = 0; j < 8; ++j)
                {
                    binaryData[(8 * i) + j] = octetData[j];
                }
            }

            uint retVal = (uint)DataTools.binToDec(binaryData);
            Console.WriteLine("decodeUnsignedInt: " + retVal);

            return retVal;
        }

        // TODO: review decodeSignedInt
        public int decodeSignedInt(int[] data)
        {
            int[] binaryData = new int[8 * length];
            int[] octetData = new int[8];

            for (int i = 0; i < length; ++i)
            {
                octetData = DataTools.decimalToBinaryArrayInt(data[i]);

                for (int j = 0; j < 8; ++j)
                {
                    binaryData[(8 * i) + j] = octetData[j];
                }
            }

            int retVal = (int)DataTools.binToDec(binaryData);
            Console.WriteLine("decodeSignedInt: " + retVal);

            return retVal;
        }

        // TODO: review decodeRealNumber
        public double decodeRealNumber(int[] data)
        {
            int[] realNum = new int[8];
            int[] binNums = new int[32];

            for (int i = 0; i < length; ++i)
            {
                realNum = DataTools.decimalToBinaryArrayInt(data[i]);

                for (int j = 0; j < realNum.Length; ++j)
                {
                    binNums[realNum.Length * i + j] = realNum[j];
                }
            }

            int sign = 0;
            if (binNums[0] == 0)
                sign = 1;
            else
                sign = -1;

            int[] binExpo = new int[8];
            int[] binField = new int[23];

            for (int i = 0; i < binExpo.Length; ++i)
            {
                binExpo[i] = binNums[i + 1];
            }
            for (int i = 0; i < binField.Length; ++i)
            {
                binField[i] = binNums[binNums.Length - i - 1];
            }

            int expo = DataTools.binToDec(binExpo);
            int field = 2 * DataTools.binToDec(binField);

            double retVal = sign * Math.Pow(2, expo - 127) * (1 + (1 / (double)field));
            Console.WriteLine("decodeRealNumber: " + retVal);

            return retVal;
        }

        // TODO: review decodeDouble
        public double decodeDouble(int[] data)
        {
            int[] realNum = new int[8];
            int[] binNums = new int[64];

            for (int i = 0; i < length; ++i)
            {
                realNum = DataTools.decimalToBinaryArrayInt(data[i]);

                for (int j = 0; j < realNum.Length; ++j)
                {
                    binNums[realNum.Length * i + j] = realNum[j];
                }
            }

            int sign = 0;
            if (binNums[0] == 0)
                sign = 1;
            else
                sign = -1;

            int[] binExpo = new int[11];
            int[] binField = new int[52];

            for (int i = 0; i < binExpo.Length; ++i)
            {
                binExpo[i] = binNums[i + 1];
            }
            for (int i = 0; i < binField.Length; ++i)
            {
                binField[i] = binNums[binNums.Length - i - 1];
            }

            int expo = DataTools.binToDec(binExpo);
            int field = 2 * DataTools.binToDec(binField);

            double retVal = sign * Math.Pow(2, expo - 1023) * (1 + (1 / (double)field));
            Console.WriteLine("decodeDouble: " + retVal);

            return retVal;
        }

        // TODO: review decodeOctetString
        public String decodeOctetString(int[] data)
        {
            String retVal = DataTools.decimalArrayToHexString(data, length);
            Console.WriteLine(retVal);

            return retVal;
        }

        // TODO: review decodeCharacterString
        public String decodeCharacterString(int[] data)
        {
            CharacterStringEncoding encoding = (CharacterStringEncoding)data[0];
            Console.WriteLine(encoding);

            String charString = String.Empty;

            switch (encoding)
            {
                case CharacterStringEncoding.ISO10646UTF8:
                    charString = decodeUTF8(newData);
                    break;
                case CharacterStringEncoding.IBMMicrosoftDBCS:
                    charString = decodeMicrosoft(newData);
                    break;
                case CharacterStringEncoding.JISX0208:
                    charString = decodeJIS(newData);
                    break;
                case CharacterStringEncoding.ISO10646UCS4:
                    charString = decodeUCS4(newData);
                    break;
                case CharacterStringEncoding.ISO10646UCS2:
                    charString = decodeUCS2(newData);
                    break;
                case CharacterStringEncoding.ISO88591:
                    charString = decodeISO8859(newData);
                    break;
            }

            Console.WriteLine(charString);

            return charString;
        }

        #region CharacterString Specific decoding methods & enums

        enum CharacterStringEncoding
        {
            [Description("ISO 10646 (UTF-8)")]
            ISO10646UTF8 = 0,
            [Description("IBM Microsoft DBCS")]
            IBMMicrosoftDBCS = 1,
            [Description("JIS X 0208")]
            JISX0208 = 2,
            [Description("ISO 10646 (UCS-4)")]
            ISO10646UCS4 = 3,
            [Description("ISO 10646 (UCS-2)")]
            ISO10646UCS2 = 4,
            [Description("ISO 8859-1")]
            ISO88591 = 5
        }

        public String decodeUTF8(int[] data)
        {
            String retVal = String.Empty;

            for (int i = 1; i < length; ++i)
            {
                retVal += (char)data[i];
            }

            return retVal;
        }

        public String decodeMicrosoft(int[] data)
        {
            String retVal = String.Empty;

            int[] codePage = { data[1], data[2] };

            for (int i = 3; i < length; ++i)
            {
                retVal += (char)data[i];
            }

            retVal += "\tCode Page: " + decodeUnsignedInt(codePage, 2).ToString();

            return retVal;
        }

        public String decodeJIS(int[] data)
        {
            return "need to complete this decoding";
        }

        public String decodeUCS4(int[] data)
        {
            return "need to complete this decoding";
        }

        public String decodeUCS2(int[] data)
        {
            return "need to complete this decoding";
        }

        public String decodeISO8859(int[] data)
        {
            return "need to complete this decoding";
        }

        #endregion

        // TODO: review decodeBitString
        public String decodeBitString(int[] data)
        {
            String s = String.Empty;
            String retVal = String.Empty;

            int unusedBits = (int)decodeUnsignedInt(data, 1);

            for (int i = 1; i < length; ++i)
            {
                s += DataTools.decimalToBinaryArrayString(data[i]);
            }

            retVal = s.Substring(0, s.Length - unusedBits);
            Console.WriteLine(retVal);

            return retVal;
        }

        // TODO: decodeEnumerated
        public String decodeEnumerated(int[] data)
        {
            String retVal = String.Empty;

            for (int i = 0; i < length; ++i)
            {
                retVal += ((BACnetObjectType)data[i]).ToString() + "\n";
                Console.WriteLine("data[" + i + "]: " + ((BACnetObjectType)data[i]).ToString());
            }

            return retVal;
        }

        // TODO: review decodeDate
        public String decodeDate(int[] data)
        {
            if (length != 4)
            {
                return "bad value";
            }

            int[] dateData = new int[length];

            for (int i = 0; i < length; ++i)
            {
                dateData[i] = data[i];
            }

            Console.WriteLine("Date: " + new Date(dateData).date);

            return new Date(dateData).date;
        }

        // TODO: review decodeTime
        public String decodeTime(int[] data)
        {
            if (length != 4)
            {
                return "bad value";
            }

            String retVal = String.Empty;

            for (int i = 0; i < length; ++i)
            {
                if (data[i] == 0xff)
                    retVal += "Any";
                else
                    retVal += data[i];

                if (i == 2)
                { retVal += "."; }
                else if (i == 3)
                {
                    if (data[0] < 11)
                    { retVal += " AM"; }
                    else
                    { retVal += " PM"; }
                }
                else
                { retVal += ":"; }
            }

            Console.WriteLine("Time: " + retVal);

            return retVal;
        }

        // TODO: review decodeBacnetObjectIdentifier
        public String decodeBACnetObjectIdentifier(int[] data)
        {
            if (length != 4)
            {
                return "bad length value: " + length;
            }

            int[] newData = new int[] { data[0], data[1], data[2], data[3] };

            Console.WriteLine("BACnetObjectIdentifier: " + new BACnetObjectIdentifier(newData).ToString());

            return new BACnetObjectIdentifier(newData).ToString();
        }

        // tag is 13, 14, or 15
        public void decodeASHRAE(int[] data)
        {

        }

    }
}
