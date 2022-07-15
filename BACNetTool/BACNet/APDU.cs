using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BACNetTool.BACNet
{
    public enum APDUType
    {
        ConfirmedRequest,
        UnconfirmedRequest,
        SimpleACK,
        ComplexACK,
        SegmentACK,
        Error,
        Reject,
        Abort
    }

    enum BACnetConfirmedServiceChoice
    {
        // Alarm and Event Services
        AcknowledgeAlarm = 0,
        ConfirmedCOVNotification = 1,
        ConfirmedCOVNotificationMultiple = 31,
        ConfirmedEventNotification = 2,
        GetAlarmSummary = 3,
        GetEnrollmentSummary = 4,
        GetEventInformation = 29,
        LifeSafetyOperation = 27,
        SubscribeCOV = 5,
        SubscribeCOVProperty = 28,
        SubscribeCOVPropertyMultiple = 30,

        // File Access Services
        AtomicReadFile = 6,
        AtomicWriteFile = 7,

        // Object Access Services
        AddListElement = 8,
        RemoveListElement = 9,
        CreateObject = 10,
        DeleteObject = 11,
        ReadProperty = 12,
        ReadPropertyMultiple = 14,
        ReadRange = 26,
        WriteProperty = 15,
        WritePropertyMultiple = 16,

        // Remote Device Management Services
        DeviceCommunicationControl = 17,
        ConfirmedPrivateTransfer = 18,
        ConfirmedTextMessage = 19,
        ReinitializeDevice = 20,

        // Virtual Terminal Services
        VTOpen = 21,
        VTClose = 22,
        VTData = 23
    }


    enum BACnetUnconfirmedServiceChoice {
        IAm = 0,
        IHave = 1,
        UnconfirmedCOVNotification = 2,
        UnconfirmedEventNotification = 3,
        UnconfirmedPrivateTransfer = 4,
        UnconfirmedTextMessage = 5,
        TimeSynchronization = 6,
        WhoHas = 7,
        WhoIs = 8,
        UTCTimeSynchronization = 9,
        WriteGroup = 10,
        UnconfirmedCOVNotificationMultiple = 11
    }

    enum BACnetError
    {
        //TODO:Figure out what bacnet errors look like?
    }

    enum BACnetRejectReason
    {
        Other = 0,
        BufferOverflow = 1,
        InconsistentParameters = 2,
        InvalidParameterDataType = 3,
        InvalidTag = 4,
        MissingRequiredParameter = 5,
        ParameterOutOfRange = 6,
        TooManyArguments = 7,
        UndefinedEnumeration = 8,
        UnrecognizedService = 9
    }

    enum BACnetAbortReason
    {
        Other = 0,
        BufferOverflow = 1,
        InvalidAPDUInThisState = 2,
        PreemptedByHigherPriorityTask = 3,
        SegmentationNotSupported = 4,
        SecurityError = 5,
        InsufficientSecurity = 6,
        WindowSizeOutOfRange = 7,
        ApplicationExceededReplyTime = 8,
        OutOfResources = 9,
        TSMTimeout = 10,
        APDUTooLong = 11
    }

    public class APDU
    {
        int reserved = 0;
        public int[] decode(int[] data)
        {
            return new int[0];
        }
    }

    public class ConfirmedRequest : APDU
    {
        bool segmentedMessage = false;
        bool moreFollows = false;
        bool segmentedResponseAccepted = false;
        int maxSegmentsAccepted;
        int maxAPDULengthAccepted;
        int invokeID;
        int sequenceNumber;
        int proposedWindowSize;
        BACnetConfirmedServiceChoice serviceChoice;

        public int[] decode(int[] data)
        {
            int i = 0;
            int type = data[i++] % 16;

            if ((type / 8) == 1)
                segmentedMessage = true;
            type %= 8;

            if ((type / 4) == 1)
                moreFollows = true;
            type %= 4;

            if ((type / 2) == 1)
                segmentedResponseAccepted = true;
            type %= 2;

            maxSegmentsAccepted = 2 ^ (data[i] / 16);
            int maxAPDU = data[i++] % 16;

            switch (maxAPDU)
            {
                case 0:
                    maxAPDULengthAccepted = 50;
                    break;
                case 1:
                    maxAPDULengthAccepted = 128;
                    break;
                case 2:
                    maxAPDULengthAccepted = 206;
                    break;
                case 3:
                    maxAPDULengthAccepted = 480;
                    break;
                case 4:
                    maxAPDULengthAccepted = 1024;
                    break;
                case 5:
                    maxAPDULengthAccepted = 1476;
                    break;               
            }

            invokeID = data[i++];

            if (segmentedMessage)
            {
                sequenceNumber = data[i++];
                proposedWindowSize = data[i++];
            }

            serviceChoice = (BACnetConfirmedServiceChoice) data[i++];


            int[] r = new int[data.Length - i];

            for (int j = 0; j < data.Length - i; j++)
                r[j] = data[j + i];

            return r;
        }
    }

    public class UnconfirmedRequest : APDU
    {
        BACnetUnconfirmedServiceChoice serviceChoice;

        public int[] decode(int[] data)
        {
            int i = 1;

            serviceChoice = (BACnetUnconfirmedServiceChoice) data [i++];

            int[] r = new int[data.Length - i];

            for (int j = 0; j < data.Length - i; j++)
                r[j] = data[j + i];

            return r;
        }
    }

    public class SimpleACK : APDU
    {
        int invokeID;
        BACnetConfirmedServiceChoice serviceACKChoice;
    }

    public class ComplexACK : APDU
    {
        bool segmentedMessage;
        bool moreFollows;
        int invokeID;
        int sequenceNumber;
        int proposedWindowSize;
        BACnetConfirmedServiceChoice serviceACKChoice;
        BACnetConfirmedServiceChoice serviceACK;

    }

    public class SegmentACK : APDU
    {
        bool negativeACK;
        bool server;
        int originalInvokeID;
        int sequenceNumber;
        int actualWindowSize;
    }
    public class Error : APDU
    {
        int originalInvokeID;
        BACnetConfirmedServiceChoice errorChoice;
        BACnetError error;
    }
    public class Reject : APDU
    {
        int originalInvokeID;
        BACnetRejectReason rejectReason;
    }
    public class Abort : APDU
    {
        bool server;
        int originalInvokeID;
        BACnetAbortReason abortReason;
    }
}
