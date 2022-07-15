using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BACNetTool.BACNet
{
    public enum NetworkLayerMessageType
    {
        WhoIsRouterToNetwork,
        IAmRouterToNetwork,
        ICouldBeRouterToNetwork,
        RejectMessageToNetwork,
        RouterBusyToNetwork,
        RouterAvailableToNetwork,
        InitializeRoutingTable,
        InitializeRoutingTableACK,
        EstablishConnectionToNetwork,
        DisconnectConnectionToNetwork,
        ChallengeRequest,
        SecurityPayload,
        SecurityResponse,
        RequestKeyUpdate,
        UpdateKeySet,
        UpdateDistributionKey,
        RequestMasterKey,
        SetMasterKey,
        WhatIsNetworkNumber,
        NetworkNumberIs
    }

    public enum NetworkPriority
    {
        NormalMessage,
        UrgentMessage,
        CriticalEquipmentMessage,
        LifeSafetyMessage
    }

    public class NPDU
    {
        int version;
        int control;

        public NetworkLayerMessageType type;

        public NetworkPriority priority = 0;

        int DNET;
        int DLEN;
        int DADR;
        int SNET;
        int SLEN;
        int SADR;
        int HopCount;
        int MessageType;
        int VendorID;

        public int[] decode(int[] data)
        {
            version = data[0];
            control = data[1];
            int i = 2;

            //bit 7
            if ((control / 128) == 1)
            {
                type = (NetworkLayerMessageType)data[i];
                Console.WriteLine("Message Type: " + type);
            }
            control %= 128;

            //bit 6
            if ((data[1] / 64) == 1)
                Console.WriteLine("THIS SHOULD BE ZERO. WHAT DID YOU DO.");
            else
                Console.WriteLine("Reserved. Shall be zero.");
            control %= 64;

            //bit 5
            if ((data[1] / 32) == 1)
            {
                Console.WriteLine("DNET, DLEN, Hop Count Present");
                DNET = data[i++] + data[i++];
                DLEN = data[i++];
                if (DLEN != 0)
                {
                    Console.WriteLine("DLEN: " + DLEN);
                    //TODO: Figure out the DADR
                }
                HopCount = data[i++];
            }
            else
                Console.WriteLine("DNET, DLEN, DADR, and Hop Count absent");
            control %= 32;

            //bit 4
            if ((data[1] / 16) == 1)
                Console.WriteLine("THIS SHOULD BE ZERO. WHAT DID YOU DO.");
            else
                Console.WriteLine("Reserved. Shall be zero.");
            control %= 16;

            //bit 3
            if ((data[1] / 8) == 1)
                Console.WriteLine("SNET, SLEN, and SADR present.");
            else
                Console.WriteLine("SNET, SLEN, and SADR absent");
            control %= 8;

            //bit 2
            if ((data[1] / 4) == 1)
                Console.WriteLine("indicates that a BACnet-Confirmed-Request-PDU, a segment of a BACnet-ComplexACK-PDU, or a network layer message expecting a reply is present.");
            else
                Console.WriteLine("indicates that other than a BACnet-Confirmed-Request-PDU, a segment of a BACnet-ComplexACK-PDU, or a network layer message expecting a reply is present.");
            control %= 4;

            //bits 1,0
            if ((data[1] / 2) == 1)
                priority += 2;
            if ((data[1] / 1) == 1)
                priority += 1;

            Console.WriteLine(priority);

            int[] r = new int[data.Length - i];

            for (int j = 0; j < data.Length - i; j++)
                r[j] = data[j + i];

            //TODO: NPDU level commands
            return r;
        }
    }
}
