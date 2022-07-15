using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BACNetTool.BACNet.Objects
{
    class BinaryInput
    {
        BACnetObjectIdentifier ObjectIdentifier;
        String ObjectName;
        BACnetObjectType ObjectType;
        BACnetBinaryPV PresentValue;
        String Description;
        String DeviceType;
        BACnetStatusFlags StatusFlags;
        BACnetEventState EventState;
        BACnetReliability Reliability;
        Boolean OutOfService;
        BACnetPolarity Polarity;
        String InactiveText;
        String ActiveText;
        BACnetDateTime ChangeOfStateTime;
        UInt32 ChangeOfStateCount;
        BACnetDateTime TimeOfStateCountReset;
        UInt32 ElapsedActiveTime;
        BACnetDateTime TimeOfActiveTimeReset;
        UInt32 TimeDelay;
        UInt32 NotificationClass;
        BACnetBinaryPV AlarmValue;
        BACnetEventTransitionBits EventEnable;
        BACnetEventTransitionBits AckedTransitions;
        BACnetNotifyType NotifyType;
        BACnetTimeStamp[] EventTimeStamps;
        String[] EventMessageTexts;
        String[] EventMessageTextsConfig;
        Boolean EventDetectionEnable;
        BACnetObjectPropertyReference EventAlgorithmInhibitRef;
        Boolean EventAlgorithmInhibit;
        UInt32 TimeDelayNormal;
        Boolean ReliabilityEvaluationInhibit;
        BACnetPropertyIdentifier[] PropertyList;
        //optional BinaryPV
        BACnetBinaryPV InterfaceValue;
        BACnetNameValue[] Tags;
        String ProfileLocation;
        String ProfileName;

    }
}
