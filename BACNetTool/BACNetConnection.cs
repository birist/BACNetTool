using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using System.Diagnostics;
using BACNetTool.BACNet;

namespace BACNetTool
{
    class BACNetConnection
    {
        int UDPPort = 47808;

        IPEndPoint localEP;
        IPAddress localIP = IPAddress.Parse("172.20.10.222");

        IPEndPoint remoteEP;
        IPAddress remoteIP = IPAddress.Parse("172.20.255.255");
        //IPAddress remoteIP = IPAddress.Parse("172.17.84.13");

        UdpClient sendUDP;

        UdpClient receiveUDP;

        public BACNetConnection()
        {
            localEP = new IPEndPoint(localIP, UDPPort);
            remoteEP = new IPEndPoint(remoteIP, UDPPort);

            sendUDP = new UdpClient();
            sendUDP.ExclusiveAddressUse = false;
            sendUDP.Client.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.ReuseAddress, true);
            sendUDP.Client.Bind(localEP);

            //receiveUDP = new UdpClient(UDPPort, AddressFamily.InterNetwork);
        }

        public void whoIs()
        {
            byte[] testByte = new byte[12];

            // Send the request
            try
            {
                //PEP Use NPDU.Create and APDU.Create (when written)
                //BVLC
                testByte[0] = 0x81;     // BVLC Type (0x81 = BACNet/IP)
                testByte[1] = 0x0B;     // BVLC Function (0x0B = BROADCAST)
                testByte[2] = 0x00;     // BVLC Length (2 bytes)
                testByte[3] = 0x0C;     // BVLC Length 

                //NPDU
                testByte[4] = 0x01;     // Version
                testByte[5] = 0x20;     // Control Flags =  0010 0000
                                        //                  0... .... = NSDU contains: BACnet APDU, message type field absent.
                                        //                  .0.. .... = Reserved: Shall be zero and is zero.
                                        //                  ..1. .... = Destination Specifier: DNET, DLEN and Hop Count present. If DLEN=0: broadcast, dest. address field absent.
                                        //                  ...0 .... = Reserved: Shall be zero and is zero.
                                        //                  .... 0... = Source specifier: SNET, SLEN and SADR absent
                                        //                  .... .0.. = Expecting Reply: Other than a BACnet-Confirmed-Request-PDU, segment of BACnet-ComplexACK-PDU or network layer message expecting a reply present.
                                        //                  .... ..0. = Priority: Not a Life Safety or Critical Equipment message.
                                        //                  .... ...0 = Priority: Normal message

                testByte[6] = 0xFF;     // DNET - 2-octet ultimate destination network number.
                testByte[7] = 0xFF;     // DNET

                testByte[8] = 0x00;     // DLEN - 1-octet length of ultimate destination MAC layer address (A value of 0 indicates a broadcast on the destination network.)

                testByte[9] = 0xFF;     // Hop Count (FF = 255)

                //APDU
                testByte[10] = 0x10;    // APDU Type : Unconfirmed Request
                testByte[11] = 0x08;    // Unconfirmed Service Choice: 8, who is. (pg 794)


                sendUDP.EnableBroadcast = false;
                sendUDP.Send(testByte, 12, remoteEP);
                while (true)
                {
                    var remoteIpEndPoint = new IPEndPoint(IPAddress.Any, 0);
                    var recvBytes = sendUDP.Receive(ref remoteEP);
                    Console.WriteLine(remoteEP.Address.ToString());
                    Console.WriteLine("this many bytes: " + recvBytes.Length);
                    BACnetFrame b = new BACnetFrame(Array.ConvertAll(recvBytes, c => (int)c));
                    // Parse and save the BACnet data
                    for (int i = 0; i < recvBytes.Length; i++)
                    {
                      Console.WriteLine(recvBytes[i].ToString("X2"));
                    }
                    Console.WriteLine("-----------");
                }
            }
            catch (Exception ex)
            {
            }
        }

        public void readPropertyTest()
        {
            byte[] testByte = { 0x81, 0x0a, 0x00, 0x11, 0x01, 0x04, 0x02, 0x75, 0x00, 0x0c, 0x0c, 0x00, 0x2d, 0xc6, 0xf6, 0x19, 0x55 };


            // Send the request
            try
            {

                //sendUDP.EnableBroadcast = false;
                sendUDP.Send(testByte, 17, remoteEP);
                while (true)
                {
                    var remoteIpEndPoint = new IPEndPoint(IPAddress.Any, 0);
                    var recvBytes = sendUDP.Receive(ref remoteEP);
                    // Parse and save the BACnet data
                    for (int i = 0; i < recvBytes.Length; i++)
                    {
                        Console.WriteLine(recvBytes[i].ToString("X2"));
                    }
                    Console.WriteLine("-----------");
                }
            }
            catch (Exception ex)
            {
            }
        }

        //TODO: add type handling
        public void readProperty(int instance)
        {
            byte[] testByte = new byte[17];
            testByte[0] = 0x81;
            testByte[1] = 0x0a;
            testByte[2] = 0x00;
            testByte[3] = 0x11;
            testByte[4] = 0x01;
            testByte[5] = 0x04;
            testByte[6] = 0x00;
            testByte[7] = 0x00;
            testByte[8] = 0x01;
            testByte[9] = 0x0c;
            testByte[10] = 0x0c;
            testByte[11] = 0x00;    //object type/instance
            testByte[12] = 0x2d;    //instance
            testByte[13] = 0xc6;    //instance
            testByte[14] = 0xf6;    //instance
            testByte[15] = 0x19;
            testByte[16] = 0x55;

            byte[] b = BitConverter.GetBytes(instance);

            testByte[14] = b[0];
            testByte[13] = b[1];
            testByte[12] = b[2];
            testByte[11] = b[3];

           // Send the request
            try
            {

                //sendUDP.EnableBroadcast = false;
                sendUDP.Send(testByte, 17, remoteEP);
                while (true)
                {
                    var remoteIpEndPoint = new IPEndPoint(IPAddress.Any, 0);
                    var recvBytes = sendUDP.Receive(ref remoteEP);
                    // Parse and save the BACnet data
                    for (int i = 0; i < recvBytes.Length; i++)
                    {
                        Console.WriteLine(recvBytes[i].ToString("X2"));
                    }
                    Console.WriteLine("-----------");
                }
            }
            catch (Exception ex)
            {
            }
        }
    }
}
