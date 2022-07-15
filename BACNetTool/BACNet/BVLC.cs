using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BACNetTool.BACNet
{
    public enum BVLCType
    {
        BVLLforBACnetIP = 0x81
    }
    public enum BVLCFunction
    {
        Result,
        WriteBroadcastDistributionTable,
        ReadBroadcastDistributionTable,
        ReadBroadcastDistributionTableAck,
        ForwardedNPDU,
        RegisterForeignDevice,
        ReadForeignDeviceTable,
        ReadForeignDeviceTableAck,
        DeleteForeignDeviceTableEntry,
        DistributeBroadcastToNetwork,
        OriginalUnicastNPDU,
        OriginalBroadcastNPDU,
        SecureBVLL
    }

    public class BVLC
    {

        public BVLCType type;
        public BVLCFunction function;
        public int length;

        public int[] decode(int[] data)
        {
            type = (BVLCType)data[0];
            function = (BVLCFunction)data[1];
            length = data[2] + data[3];

            Console.WriteLine("Type: " + type);
            Console.WriteLine("Function: " + function);
            Console.WriteLine("Length: " + length);

            int[] r = new int[length - 4];
            for (int i = 0; i < length - 4; i++)
                r[i] = data[i + 4];

            return r;
        }
    }
}
