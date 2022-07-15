using System;
using BACNetTool.BACNet;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Decoding_Methods
{
    public class BVLC_Decoding
    {
        public void BVLC_Result_Decode(int[] data)
        {
            //Actual
            BVLC encoded = new BVLC();
            encoded.decode(data);

            //Expected
            BVLC decoded = new BVLC();
            decoded.type = BVLCType.BVLLforBACnetIP;
            decoded.function = BVLCFunction.Result;

            //Assertions
            Assert.AreEqual(decoded.type, encoded.type);
            Assert.AreEqual(decoded.function, encoded.function);
        }


        public void BVLC_WriteBroadcastDistributionTable_Decode(int[] data)
        {
            //Actual
            BVLC encoded = new BVLC();
            encoded.decode(data);

            //Expected
            BVLC decoded = new BVLC();
            decoded.type = BVLCType.BVLLforBACnetIP;
            decoded.function = BVLCFunction.WriteBroadcastDistributionTable;

            //Assertions
            Assert.AreEqual(decoded.type, encoded.type);
            Assert.AreEqual(decoded.function, encoded.function);
        }


        public void BVLC_ReadBroadcastDistributionTable_Decode(int[] data)
        {
            //Actual
            BVLC encoded = new BVLC();
            encoded.decode(data);

            //Expected
            BVLC decoded = new BVLC();
            decoded.type = BVLCType.BVLLforBACnetIP;
            decoded.function = BVLCFunction.ReadBroadcastDistributionTable;

            //Assertions
            Assert.AreEqual(decoded.type, encoded.type);
            Assert.AreEqual(decoded.function, encoded.function);
        }


        public void BVLC_ReadBroadcastDistributionTableAck_Decode(int[] data)
        {
            //Actual
            BVLC encoded = new BVLC();
            encoded.decode(data);

            //Expected
            BVLC decoded = new BVLC();
            decoded.type = BVLCType.BVLLforBACnetIP;
            decoded.function = BVLCFunction.ReadBroadcastDistributionTableAck;

            //Assertions
            Assert.AreEqual(decoded.type, encoded.type);
            Assert.AreEqual(decoded.function, encoded.function);
        }


        public void BVLC_ForwardedNPDU_Decode(int[] data)
        {
            //Actual
            BVLC encoded = new BVLC();
            encoded.decode(data);

            //Expected
            BVLC decoded = new BVLC();
            decoded.type = BVLCType.BVLLforBACnetIP;
            decoded.function = BVLCFunction.ForwardedNPDU;

            //Assertions
            Assert.AreEqual(decoded.type, encoded.type);
            Assert.AreEqual(decoded.function, encoded.function);
        }


        public void BVLC_RegisterForeignDevice_Decode(int[] data)
        {
            //Actual
            BVLC encoded = new BVLC();
            encoded.decode(data);

            //Expected
            BVLC decoded = new BVLC();
            decoded.type = BVLCType.BVLLforBACnetIP;
            decoded.function = BVLCFunction.RegisterForeignDevice;

            //Assertions
            Assert.AreEqual(decoded.type, encoded.type);
            Assert.AreEqual(decoded.function, encoded.function);
        }


        public void BVLC_ReadForeignDeviceTable_Decode(int[] data)
        {
            //Actual
            BVLC encoded = new BVLC();
            encoded.decode(data);

            //Expected
            BVLC decoded = new BVLC();
            decoded.type = BVLCType.BVLLforBACnetIP;
            decoded.function = BVLCFunction.ReadForeignDeviceTable;

            //Assertions
            Assert.AreEqual(decoded.type, encoded.type);
            Assert.AreEqual(decoded.function, encoded.function);
        }


        public void BVLC_ReadForeignDeviceTableAck_Decode(int[] data)
        {
            //Actual
            BVLC encoded = new BVLC();
            encoded.decode(data);

            //Expected
            BVLC decoded = new BVLC();
            decoded.type = BVLCType.BVLLforBACnetIP;
            decoded.function = BVLCFunction.ReadForeignDeviceTableAck;

            //Assertions
            Assert.AreEqual(decoded.type, encoded.type);
            Assert.AreEqual(decoded.function, encoded.function);
        }


        public void BVLC_DeleteForeignDeviceTableEntry_Decode(int[] data)
        {
            //Actual
            BVLC encoded = new BVLC();
            encoded.decode(data);

            //Expected
            BVLC decoded = new BVLC();
            decoded.type = BVLCType.BVLLforBACnetIP;
            decoded.function = BVLCFunction.DeleteForeignDeviceTableEntry;

            //Assertions
            Assert.AreEqual(decoded.type, encoded.type);
            Assert.AreEqual(decoded.function, encoded.function);
        }


        public void BVLC_DistributeBroadcastToNetwork_Decode(int[] data)
        {
            //Actual
            BVLC encoded = new BVLC();
            encoded.decode(data);

            //Expected
            BVLC decoded = new BVLC();
            decoded.type = BVLCType.BVLLforBACnetIP;
            decoded.function = BVLCFunction.DistributeBroadcastToNetwork;

            //Assertions
            Assert.AreEqual(decoded.type, encoded.type);
            Assert.AreEqual(decoded.function, encoded.function);
        }
        public void BVLC_OriginalUnicastNPDU_Decode(int[] data)
        {
            //Actual
            BVLC encoded = new BVLC();
            encoded.decode(data);

            //Expected
            BVLC decoded = new BVLC();
            decoded.type = BVLCType.BVLLforBACnetIP;
            decoded.function = BVLCFunction.OriginalUnicastNPDU;

            //Assertions
            Assert.AreEqual(decoded.type, encoded.type);
            Assert.AreEqual(decoded.function, encoded.function);
        }
        public void BVLC_OriginalBroadcastNPDU_Decode(int[] data)
        {
            //Actual
            BVLC encoded = new BVLC();
            encoded.decode(data);

            //Expected
            BVLC decoded = new BVLC();
            decoded.type = BVLCType.BVLLforBACnetIP;
            decoded.function = BVLCFunction.OriginalBroadcastNPDU;

            //Assertions
            Assert.AreEqual(decoded.type, encoded.type);
            Assert.AreEqual(decoded.function, encoded.function);
        }
        public void BVLC_SecureBVLL_Decode(int[] data)
        {
            //Actual
            BVLC encoded = new BVLC();
            encoded.decode(data);

            //Expected
            BVLC decoded = new BVLC();
            decoded.type = BVLCType.BVLLforBACnetIP;
            decoded.function = BVLCFunction.SecureBVLL;

            //Assertions
            Assert.AreEqual(decoded.type, encoded.type);
            Assert.AreEqual(decoded.function, encoded.function);
        }
    }

    public class NPDU_Decoding
    {
        public void NPDU_Control_NSDU_NetworkLayer_WhoIsRouterToNetwork_Decode(int[] data)
        {
            //Actual
            NPDU encoded = new NPDU();
            encoded.decode(data);

            //Expected
            NPDU decoded = new NPDU();
            decoded.type = NetworkLayerMessageType.WhoIsRouterToNetwork;

            //Assertions
            Assert.AreEqual(decoded.type, encoded.type);
        }


        public void NPDU_Control_NSDU_NetworkLayer_IAmRouterToNetwork_Decode(int[] data)
        {
            //Actual
            NPDU encoded = new NPDU();
            encoded.decode(data);

            //Expected
            NPDU decoded = new NPDU();
            decoded.type = NetworkLayerMessageType.IAmRouterToNetwork;

            //Assertions
            Assert.AreEqual(decoded.type, encoded.type);
        }


        public void NPDU_Control_NSDU_NetworkLayer_ICouldBeRouterToNetwork_Decode(int[] data)
        {
            //Actual
            NPDU encoded = new NPDU();
            encoded.decode(data);

            //Expected
            NPDU decoded = new NPDU();
            decoded.type = NetworkLayerMessageType.ICouldBeRouterToNetwork;

            //Assertions
            Assert.AreEqual(decoded.type, encoded.type);
        }


        public void NPDU_Control_NSDU_NetworkLayer_RejectMessageToNetwork_Decode(int[] data)
        {
            //Actual
            NPDU encoded = new NPDU();
            encoded.decode(data);

            //Expected
            NPDU decoded = new NPDU();
            decoded.type = NetworkLayerMessageType.RejectMessageToNetwork;

            //Assertions
            Assert.AreEqual(decoded.type, encoded.type);
        }


        public void NPDU_Control_NSDU_NetworkLayer_RouterBusyToNetwork_Decode(int[] data)
        {
            //Actual
            NPDU encoded = new NPDU();
            encoded.decode(data);

            //Expected
            NPDU decoded = new NPDU();
            decoded.type = NetworkLayerMessageType.RouterBusyToNetwork;

            //Assertions
            Assert.AreEqual(decoded.type, encoded.type);
        }


        public void NPDU_Control_NSDU_NetworkLayer_RouterAvailableToNetwork_Decode(int[] data)
        {
            //Actual
            NPDU encoded = new NPDU();
            encoded.decode(data);

            //Expected
            NPDU decoded = new NPDU();
            decoded.type = NetworkLayerMessageType.RouterAvailableToNetwork;

            //Assertions
            Assert.AreEqual(decoded.type, encoded.type);
        }


        public void NPDU_Control_NSDU_NetworkLayer_InitializeRoutingTable_Decode(int[] data)
        {
            //Actual
            NPDU encoded = new NPDU();
            encoded.decode(data);

            //Expected
            NPDU decoded = new NPDU();
            decoded.type = NetworkLayerMessageType.InitializeRoutingTable;

            //Assertions
            Assert.AreEqual(decoded.type, encoded.type);
        }


        public void NPDU_Control_NSDU_NetworkLayer_InitializeRoutingTableACK_Decode(int[] data)
        {
            //Actual
            NPDU encoded = new NPDU();
            encoded.decode(data);

            //Expected
            NPDU decoded = new NPDU();
            decoded.type = NetworkLayerMessageType.InitializeRoutingTableACK;

            //Assertions
            Assert.AreEqual(decoded.type, encoded.type);
        }


        public void NPDU_Control_NSDU_NetworkLayer_EstablishConnectionToNetwork_Decode(int[] data)
        {
            //Actual
            NPDU encoded = new NPDU();
            encoded.decode(data);

            //Expected
            NPDU decoded = new NPDU();
            decoded.type = NetworkLayerMessageType.EstablishConnectionToNetwork;

            //Assertions
            Assert.AreEqual(decoded.type, encoded.type);
        }


        public void NPDU_Control_NSDU_NetworkLayer_DisconnectConnectionToNetwork_Decode(int[] data)
        {
            //Actual
            NPDU encoded = new NPDU();
            encoded.decode(data);

            //Expected
            NPDU decoded = new NPDU();
            decoded.type = NetworkLayerMessageType.DisconnectConnectionToNetwork;

            //Assertions
            Assert.AreEqual(decoded.type, encoded.type);
        }


        public void NPDU_Control_NSDU_NetworkLayer_ChallengeRequest_Decode(int[] data)
        {
            //Actual
            NPDU encoded = new NPDU();
            encoded.decode(data);

            //Expected
            NPDU decoded = new NPDU();
            decoded.type = NetworkLayerMessageType.ChallengeRequest;

            //Assertions
            Assert.AreEqual(decoded.type, encoded.type);
        }


        public void NPDU_Control_NSDU_NetworkLayer_SecurityPayload_Decode(int[] data)
        {
            //Actual
            NPDU encoded = new NPDU();
            encoded.decode(data);

            //Expected
            NPDU decoded = new NPDU();
            decoded.type = NetworkLayerMessageType.SecurityPayload;

            //Assertions
            Assert.AreEqual(decoded.type, encoded.type);
        }


        public void NPDU_Control_NSDU_NetworkLayer_SecurityResponse_Decode(int[] data)
        {
            //Actual
            NPDU encoded = new NPDU();
            encoded.decode(data);

            //Expected
            NPDU decoded = new NPDU();
            decoded.type = NetworkLayerMessageType.SecurityResponse;

            //Assertions
            Assert.AreEqual(decoded.type, encoded.type);
        }


        public void NPDU_Control_NSDU_NetworkLayer_RequestKeyUpdate_Decode(int[] data)
        {
            //Actual
            NPDU encoded = new NPDU();
            encoded.decode(data);

            //Expected
            NPDU decoded = new NPDU();
            decoded.type = NetworkLayerMessageType.RequestKeyUpdate;

            //Assertions
            Assert.AreEqual(decoded.type, encoded.type);
        }


        public void NPDU_Control_NSDU_NetworkLayer_UpdateKeySet_Decode(int[] data)
        {
            //Actual
            NPDU encoded = new NPDU();
            encoded.decode(data);

            //Expected
            NPDU decoded = new NPDU();
            decoded.type = NetworkLayerMessageType.UpdateKeySet;

            //Assertions
            Assert.AreEqual(decoded.type, encoded.type);
        }


        public void NPDU_Control_NSDU_NetworkLayer_UpdateDistributionKey_Decode(int[] data)
        {
            //Actual
            NPDU encoded = new NPDU();
            encoded.decode(data);

            //Expected
            NPDU decoded = new NPDU();
            decoded.type = NetworkLayerMessageType.UpdateDistributionKey;

            //Assertions
            Assert.AreEqual(decoded.type, encoded.type);
        }


        public void NPDU_Control_NSDU_NetworkLayer_RequestMasterKey_Decode(int[] data)
        {
            //Actual
            NPDU encoded = new NPDU();
            encoded.decode(data);

            //Expected
            NPDU decoded = new NPDU();
            decoded.type = NetworkLayerMessageType.RequestMasterKey;

            //Assertions
            Assert.AreEqual(decoded.type, encoded.type);
        }


        public void NPDU_Control_NSDU_NetworkLayer_SetMasterKey_Decode(int[] data)
        {
            //Actual
            NPDU encoded = new NPDU();
            encoded.decode(data);

            //Expected
            NPDU decoded = new NPDU();
            decoded.type = NetworkLayerMessageType.SetMasterKey;

            //Assertions
            Assert.AreEqual(decoded.type, encoded.type);
        }


        public void NPDU_Control_NSDU_NetworkLayer_WhatIsNetworkNumber_Decode(int[] data)
        {
            //Actual
            NPDU encoded = new NPDU();
            encoded.decode(data);

            //Expected
            NPDU decoded = new NPDU();
            decoded.type = NetworkLayerMessageType.WhatIsNetworkNumber;

            //Assertions
            Assert.AreEqual(decoded.type, encoded.type);
        }


        public void NPDU_Control_NSDU_NetworkLayer_NetworkNumberIs_Decode(int[] data)
        {
            //Actual
            NPDU encoded = new NPDU();
            encoded.decode(data);

            //Expected
            NPDU decoded = new NPDU();
            decoded.type = NetworkLayerMessageType.NetworkNumberIs;

            //Assertions
            Assert.AreEqual(decoded.type, encoded.type);
        }


        public void NPDU_Control_DNET_Absent_Decode(int[] data)
        {

        }


        public void NPDU_Control_DNET_Present_Decode(int[] data)
        {

        }


        public void NPDU_Control_DNET_Present_DLENZero_Decode(int[] data)
        {

        }


        public void NPDU_Control_SNET_Absent_Decode(int[] data)
        {

        }

        public void NPDU_Control_SNET_Present_Decode(int[] data)
        {

        }


        public void NPDU_Control_SNET_Present_SLENZero_Decode(int[] data)
        {

        }


        public void NPDU_Control_Expecting_Reply_Decode(int[] data)
        {

        }


        public void NPDU_Control_Not_Expecting_Reply_Decode(int[] data)
        {

        }


        public void NPDU_Control_Priority_LifeSafety_Decode(int[] data)
        {

        }


        public void NPDU_Control_Priority_CriticalEquipment_Decode(int[] data)
        {

        }


        public void NPDU_Control_Priority_UrgentMessage_Decode(int[] data)
        {

        }


        public void NPDU_Control_Priortiy_NormalMessage_Decode(int[] data)
        {

        }
    }

    public class BACnetTag_Decoding
    {
    }
}

namespace Static_Decoding
{
    [TestClass]
    public class BVLC_Tests
    {
        Decoding_Methods.BVLC_Decoding Test = new Decoding_Methods.BVLC_Decoding();

        [TestMethod]
        public void BVLC_Result_Decode()
        {
            Test.BVLC_Result_Decode(new int[] { 0x81, 0x00, 0x00, 0x04 });
        }

        [TestMethod]
        public void BVLC_WriteBroadcastDistributionTable_Decode()
        {
            Test.BVLC_WriteBroadcastDistributionTable_Decode(new int[] { 0x81, 0x01, 0x00, 0x04 });
        }

        [TestMethod]
        public void BVLC_ReadBroadcastDistributionTable_Decode()
        {
            Test.BVLC_ReadBroadcastDistributionTable_Decode(new int[] { 0x81, 0x02, 0x00, 0x04 });
        }

        [TestMethod]
        public void BVLC_ReadBroadcastDistributionTableAck_Decode()
        {
            Test.BVLC_ReadBroadcastDistributionTableAck_Decode(new int[] { 0x81, 0x03, 0x00, 0x04 });
        }

        [TestMethod]
        public void BVLC_ForwardedNPDU_Decode()
        {
            Test.BVLC_ForwardedNPDU_Decode(new int[] { 0x81, 0x04, 0x00, 0x04 });
        }

        [TestMethod]
        public void BVLC_RegisterForeignDevice_Decode()
        {
            Test.BVLC_RegisterForeignDevice_Decode(new int[] { 0x81, 0x05, 0x00, 0x04 });
        }

        [TestMethod]
        public void BVLC_ReadForeignDeviceTable_Decode()
        {
            Test.BVLC_ReadForeignDeviceTable_Decode(new int[] { 0x81, 0x06, 0x00, 0x04 });
        }

        [TestMethod]
        public void BVLC_ReadForeignDeviceTableAck_Decode()
        {
            Test.BVLC_ReadForeignDeviceTableAck_Decode(new int[] { 0x81, 0x07, 0x00, 0x04 });
        }

        [TestMethod]
        public void BVLC_DeleteForeignDeviceTableEntry_Decode()
        {
            Test.BVLC_DeleteForeignDeviceTableEntry_Decode(new int[] { 0x81, 0x08, 0x00, 0x04 });
        }

        [TestMethod]
        public void BVLC_DistributeBroadcastToNetwork_Decode()
        {
            Test.BVLC_DistributeBroadcastToNetwork_Decode(new int[] { 0x81, 0x09, 0x00, 0x04 });
        }

        [TestMethod]
        public void BVLC_OriginalUnicastNPDU_Decode()
        {
            Test.BVLC_OriginalUnicastNPDU_Decode(new int[] { 0x81, 0x0a, 0x00, 0x04 });
        }

        [TestMethod]
        public void BVLC_OriginalBroadcastNPDU_Decode()
        {
            Test.BVLC_OriginalBroadcastNPDU_Decode(new int[] { 0x81, 0x0b, 0x00, 0x04 });
        }

        [TestMethod]
        public void BVLC_SecureBVLL_Decode() {
            Test.BVLC_SecureBVLL_Decode(new int[] { 0x81, 0x0c, 0x00, 0x04 });
        }
    }

    [TestClass]
    public class NPDU_Tests
    {
        Decoding_Methods.NPDU_Decoding Test = new Decoding_Methods.NPDU_Decoding();

        [TestMethod]
        public void NPDU_Control_NSDU_NetworkLayer_WhoIsRouterToNetwork_Decode()
        {
            Test.NPDU_Control_NSDU_NetworkLayer_WhoIsRouterToNetwork_Decode(new int[] { 0x01, 0x80, 0x00 });
        }

        [TestMethod]
        public void NPDU_Control_NSDU_NetworkLayer_IAmRouterToNetwork_Decode()
        {
            Assert.AreEqual(true, false);
        }

        [TestMethod]
        public void NPDU_Control_NSDU_NetworkLayer_ICouldBeRouterToNetwork_Decode()
        {
            Assert.AreEqual(true, false);

        }

        [TestMethod]
        public void NPDU_Control_NSDU_NetworkLayer_RejectMessageToNetwork_Decode()
        {
            Assert.AreEqual(true, false);
        }

        [TestMethod]
        public void NPDU_Control_NSDU_NetworkLayer_RouterBusyToNetwork_Decode()
        {
            Assert.AreEqual(true, false);
        }

        [TestMethod]
        public void NPDU_Control_NSDU_NetworkLayer_RouterAvailableToNetwork_Decode()
        {
            Assert.AreEqual(true, false);
        }

        [TestMethod]
        public void NPDU_Control_NSDU_NetworkLayer_InitializeRoutingTable_Decode()
        {
            Assert.AreEqual(true, false);
        }

        [TestMethod]
        public void NPDU_Control_NSDU_NetworkLayer_InitializeRoutingTableACK_Decode()
        {
            Assert.AreEqual(true, false);
        }

        [TestMethod]
        public void NPDU_Control_NSDU_NetworkLayer_EstablishConnectionToNetwork_Decode()
        {
            Assert.AreEqual(true, false);
        }

        [TestMethod]
        public void NPDU_Control_NSDU_NetworkLayer_DisconnectConnectionToNetwork_Decode()
        {
            Assert.AreEqual(true, false);
        }

        [TestMethod]
        public void NPDU_Control_NSDU_NetworkLayer_ChallengeRequest_Decode()
        {
            Assert.AreEqual(true, false);
        }

        [TestMethod]
        public void NPDU_Control_NSDU_NetworkLayer_SecurityPayload_Decode()
        {
            Assert.AreEqual(true, false);
        }

        [TestMethod]
        public void NPDU_Control_NSDU_NetworkLayer_SecurityResponse_Decode()
        {
            Assert.AreEqual(true, false);
        }

        [TestMethod]
        public void NPDU_Control_NSDU_NetworkLayer_RequestKeyUpdate_Decode()
        {
            Assert.AreEqual(true, false);
        }

        [TestMethod]
        public void NPDU_Control_NSDU_NetworkLayer_UpdateKeySet_Decode()
        {
            Assert.AreEqual(true, false);

        }

        [TestMethod]
        public void NPDU_Control_NSDU_NetworkLayer_UpdateDistributionKey_Decode()
        {
            Assert.AreEqual(true, false);

        }

        [TestMethod]
        public void NPDU_Control_NSDU_NetworkLayer_RequestMasterKey_Decode()
        {
            Assert.AreEqual(true, false);

        }

        [TestMethod]
        public void NPDU_Control_NSDU_NetworkLayer_SetMasterKey_Decode()
        {
            Assert.AreEqual(true, false);

        }

        [TestMethod]
        public void NPDU_Control_NSDU_NetworkLayer_WhatIsNetworkNumber_Decode()
        {
            Assert.AreEqual(true, false);

        }

        [TestMethod]
        public void NPDU_Control_NSDU_NetworkLayer_NetworkNumberIs_Decode()
        {
            Assert.AreEqual(true, false);

        }

        [TestMethod]
        public void NPDU_Control_DNET_Absent_Decode(int[] data)
        {
            Assert.AreEqual(true, false);
        }

        [TestMethod]
        public void NPDU_Control_DNET_Present_Decode(int[] data)
        {
            Assert.AreEqual(true, false);
        }

        [TestMethod]
        public void NPDU_Control_DNET_Present_DLENZero_Decode(int[] data)
        {
            Assert.AreEqual(true, false);
        }

        [TestMethod]
        public void NPDU_Control_SNET_Absent_Decode(int[] data)
        {
            Assert.AreEqual(true, false);
        }

        [TestMethod]
        public void NPDU_Control_SNET_Present_Decode(int[] data)
        {
            Assert.AreEqual(true, false);
        }

        [TestMethod]
        public void NPDU_Control_SNET_Present_SLENZero_Decode(int[] data)
        {
            Assert.AreEqual(true, false);
        }

        [TestMethod]
        public void NPDU_Control_Expecting_Reply_Decode(int[] data)
        {
            Assert.AreEqual(true, false);
        }

        [TestMethod]
        public void NPDU_Control_Not_Expecting_Reply_Decode(int[] data)
        {
            Assert.AreEqual(true, false);
        }

        [TestMethod]
        public void NPDU_Control_Priority_LifeSafety_Decode(int[] data)
        {
            Assert.AreEqual(true, false);
        }

        [TestMethod]
        public void NPDU_Control_Priority_CriticalEquipment_Decode(int[] data)
        {
            Assert.AreEqual(true, false);
        }

        [TestMethod]
        public void NPDU_Control_Priority_UrgentMessage_Decode(int[] data)
        {
            Assert.AreEqual(true, false);
        }

        [TestMethod]
        public void NPDU_Control_Priortiy_NormalMessage_Decode(int[] data)
        {
            Assert.AreEqual(true, false);

        }
    }

    [TestClass]
    public class APDU_Tests
    {
        //Confirmed Requests
        [TestMethod]
        public void APDU_ConfirmedRequest_Decode()
        {
            APDU test = new APDU();

        }



        //Unconfirmed Requests

        //SimpleACK
        
        //ComplexACK
        
        //SegmentACK

        //Error

        //Reject

        //Abort

    }

    [TestClass]
    public class BACnetTag_Tests
    {
        [TestMethod]
        public void BACnetTag_Null_Decode()
        {

        }

        [TestMethod]
        public void BACnetTag_Boolean_Decode()
        {

        }

        [TestMethod]
        public void BACnetTag_UnsignedInteger_Decode()
        {

        }

        [TestMethod]
        public void BACnetTag_SignedInteger_Decode()
        {

        }

        [TestMethod]
        public void BACnetTag_Real_Decode()
        {

        }

        [TestMethod]
        public void BACnetTag_Double_Decode()
        {

        }

        [TestMethod]
        public void BACnetTag_OctetString_Decode()
        {

        }
        [TestMethod]
        public void BACnetTag_CharacterString_Decode()
        {

        }
        [TestMethod]
        public void BACnetTag_BitString_Decode()
        {

        }
        [TestMethod]
        public void BACnetTag_Enumerated_Decode()
        {

        }
        [TestMethod]
        public void BACnetTag_Date_Decode()
        {

        }
        [TestMethod]
        public void BACnetTag_Time_Decode()
        {

        }
        [TestMethod]
        public void BACnetTag_BACnetObjectIdentifer_Decode()
        {

        }

    }

    [TestClass]
    public class BACnetFrame_Tests
    {

    }
}

namespace Encoding_Methods
{

}

namespace Static_Encoding
{

}


