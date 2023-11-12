//using System;

//class MainClass
//{
//   public static void Main(string[] args)
//    {
//        string input = Console.ReadLine();
//        string output = "";

//        if (IsBinary(input))
//        {
//            output = EncodeData(input);
//        }
//        else
//        {
//            output = DecodeData(input);
//        }

//        Console.WriteLine(output);
//    }

//    static bool IsBinary(string input)
//    {
//        foreach (char c in input)
//        {
//            if (c != '0' && c != '1')
//            {
//                return false;
//            }
//        }
//        return true;
//    }

//    static string EncodeData(string binaryData)
//    {
//        string encodedData = "DDDD";

//        char prevBit = '0';
//        foreach (char bit in binaryData)
//        {
//            if (bit == '1')
//            {
//                if (prevBit == '0')
//                {
//                    encodedData += "GD";
//                }
//                else
//                {
//                    encodedData += "DG";
//                }
//            }
//            else
//            {
//                encodedData += prevBit.ToString() + prevBit.ToString();
//            }

//            prevBit = bit;
//        }

//        return encodedData;
//    }

//    static string DecodeData(string encodedData)
//    {
//        string binaryData = "";

//        char prevBit = '0';
//        for (int i = 4; i < encodedData.Length; i += 2)
//        {
//            char currentBit = (encodedData[i] == 'G') ? '1' : '0';

//            if (currentBit != prevBit)
//            {
//                binaryData += '1';
//            }
//            else
//            {
//                binaryData += '0';
//            }

//            prevBit = currentBit;
//        }
//        return binaryData;
////    }
//}

