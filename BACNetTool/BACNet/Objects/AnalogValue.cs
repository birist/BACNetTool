using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BACNetTool.BACNet.Objects
{
    class AnalogValue
    {
        BACnetObjectIdentifier ObjectIdentifier;
        String ObjectName;
        BACnetObjectType ObjectType;
        Single PresentValue;
        String Description;
        BACnetStatusFlags StatusFlags;
        BACnetEventState EventState;
        BACnetReliability Reliability;
        Boolean OutOfService;
        BACnetEngineeringUnits Units;
        BACnetPriorityArray PriorityArray;
        Single RelinquishDefault;
        Single COVIncrement;
        UInt32 TimeDelay;
        UInt32 NotificationClass;
        Single HighLimit;
        Single LowLimit;
        Single Deadband;
        BACnetLimitEnable LimitEnable;
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
        Single MinPresValue;
        Single MaxPresValue;
        Single Resolution;
        BACnetPropertyIdentifier PropertyList;
        Single FaultHighLimit;
        Single FaultLowLimit;
        //optional 32
        UInt32 CurrentCommandPriority;
        BACnetValueSource ValueSource;
        BACnetValueSource[] ValueSourceArray;
        BACnetTimeStamp LastCommandTime;
        BACnetTimeStamp[] CommandTimeArray;
        BACnetNameValue[] Tags;
        String ProfileLocation;
        String ProfileName;

    }
}
