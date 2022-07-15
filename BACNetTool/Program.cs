using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BACNetTool.BACNet;

namespace BACNetTool
{
    class Program
    {
        static void Main(string[] args)
        {
            //b.whoIs();
            //Console.WriteLine("TEST");
            //Console.WriteLine((int)BACnetAccessAuthenticationFactorDisable.DisabledDamaged);
            //Console.ReadLine();

            //int[] tag = { 1, 0, 1, 1 };
            //
            //int[] a = new int[36];
            //Random r = new Random();
            //String s = "";
            //
            //for (int i = 0; i < a.Length; ++i)
            //{
            //    if(i < 4)
            //    {
            //        a[i] = tag[i];
            //        s += a[i];
            //        continue;
            //    }
            //
            //    a[i] = r.Next(2);
            //    s += a[i];
            //}
            //
            //Debug.Print(s);
            //
            //Decoder d = new Decoder(a);
            //
            //int[] arr = DataTools.hexToBin("4e3f");
            //foreach (int z in arr)
            //{
            //    Console.Write(z);
            //}
            //
            //Console.WriteLine();
            //Console.WriteLine(DataTools.decToBin(20031)[0]);
            //
            //Console.ReadLine();

            //int[] TylerTest = { 0x75, 0x0b, 0x04, 0x00, 0x4e, 0x00, 0x41, 0x00, 0x45, 0x00, 0x2d, 0x00, 0x37, 0x3f };
            //BACnetTag b = new BACnetTag();

            //b.decode(TylerTest);


            //int[] testpacket = { 0x81, 0x0b, 0x00, 0x0c, 0x01, 0x26, 0xff, 0xff, 0x00, 0xff, 0x10, 0xc4 };
            //BACnetFrame frame = new BACnetFrame(testpacket);
            
            BACNetConnection b = new BACNetConnection();
            b.readProperty(3333);

            int x = 3000054;
            

            //Console.Read();

            
            Console.Read();

        }
    }
}
