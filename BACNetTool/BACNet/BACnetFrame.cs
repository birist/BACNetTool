using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BACNetTool.BACNet;

namespace BACNetTool.BACNet
{
    public class BACnetFrame
    {
        BVLC bvlc;
        NPDU npdu;
        APDU apdu;
        //TODO: blah
        public BACnetFrame(int[] data)
        {
            bvlc = new BVLC();
            npdu = new NPDU();

            data = bvlc.decode(data);
            data = npdu.decode(data);
            data = setAPDU(data);
            // 0000 (0) confirmed
            // 0001 (1) unconfirmed
            // 0010 (2) simple
            // 0011 (3) complex
            // 0100 (4) segment
            // 0101 (5) error
            // 0110 (6) reject
            // 0111 (7) abort

            Console.WriteLine("This is the type:" + apdu.GetType().ToString());

            for (int i = 0; i < data.Length; i++)
            {
                Console.WriteLine("This is the data:" + data[i]);
            }

        }

        public int[] setAPDU(int[] data)
        {
            int type = data[0] / 16;
        
            switch (type)
            {
                case 0:
                    apdu = new ConfirmedRequest();
                    break;
                case 1:
                    apdu = new UnconfirmedRequest();
                    break;
                case 2:
                    apdu = new SimpleACK();
                    break;
                case 3:
                    apdu = new ComplexACK();
                    break;
                case 4:
                    apdu = new SegmentACK();
                    break;
                case 5:
                    apdu = new Error();
                    break;
                case 6:
                    apdu = new Reject();
                    break;
                case 7:
                    apdu = new Abort();
                    break;

            }
            
            return apdu.decode(data);
        }
    }
}
