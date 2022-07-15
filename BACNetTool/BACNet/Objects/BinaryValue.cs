﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BACNetTool.BACNet.Objects
{
    class BinaryValue
    {
        BACnetObjectIdentifier ObjectIdentifier;
        String ObjectName;
        BACnetObjectType ObjectType;
        BACnetBinaryPV PresentValue;
        String Description;
        BACnetStatusFlags StatusFlags;
        BACnetEventState EventState;
        BACnetReliability Reliability;
        Boolean OutOfService;
        String InactiveText;
        String ActiveText;
        BACnetDateTime ChangeOfStateTime;
        UInt32 ChangeOfStateCount;
        BACnetDateTime TimeOfStateCountReset;
        UInt32 ElapsedActiveTime;
        BACnetDateTime TimeOfActiveTimeReset;
        UInt32 MinimumOffTime;
        UInt32 MinimumOnTime;
        BACnetPriorityArray PriorityArray;
        BACnetBinaryPV RelinquishDefault;
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
        //optional uint32
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
