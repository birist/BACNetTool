using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BACNetTool.BACNet.Objects
{
    class AnalogInput
    {
        BACnetObjectIdentifier ObjectIdentifier;
        String ObjectName;
        BACnetObjectType ObjectType;
        Single PresentValue;
        String Description;
        String DeviceType;
        BACnetStatusFlags StatusFlags;
        BACnetEventState EventState;
        BACnetReliability Reliability;
        Boolean OutOfService;
        UInt32 UpdateInterval;
        BACnetEngineeringUnits Units;
        Single MinPresValue;
        Single MaxPresValue;
        Single Resolution;
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
        BACnetPropertyIdentifier[] PropertyList;
        //BACnetOptionalREAL InterfaceValue , can be null or real.
        Single InterfaceValue;
        Single FaultHighLimit;
        Single FaultLowLimit;
        BACnetNameValue[] Tags;
        String ProfileLocation;
        String ProfileName;

    }
}
