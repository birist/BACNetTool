﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BACNetTool.BACNet.Objects
{
    class Device
    {
        BACnetObjectIdentifier ObjectIdentifier;
        String ObjectName;
        BACnetObjectType ObjectType;
        BACnetDeviceStatus SystemStatus;
        String VendorName;
        UInt16 VendorIdentifier;
        String ModelName;
        String FirmwareRevision;
        String ApplicationSoftwareVersion;
        String Location;
        String Description;
        UInt32 ProtocolVersion;
        UInt32 ProtocolRevision;
        BACnetServicesSupported ProtocolServicesSupported;
        BACnetObjectTypesSupported ProtocolObjectTypesSupported;
        BACnetObjectIdentifier[] ObjectList;
        BACnetObjectIdentifier[] StructuredObjectList;
        UInt32 MaxAPDULengthAccepted;
        BACnetSegmentation SegmentationSupported;
        UInt32 MaxSegmentsAccepted;
        List<BACnetVTClass> VTClassesSupported;
        List<BACnetVTSession> ActiveVTSessions;
        DateTime LocalTime;
        DateTime LocalDate;
        Int32 UTCOffset;
        Boolean DaylightSavingsStatus;
        UInt32 APDUSegmentTimeout;
        UInt32 APDUTimeout;
        UInt32 NumberOfAPDURetries;
        List<BACnetRecipient> TimeSynchronizationRecipients;
        UInt16 MaxMaster;
        UInt32 MaxInfoFrames;
        List<BACnetAddressBinding> DeviceAddressBinding;
        UInt32 DatabaseRevision;
        BACnetObjectIdentifier[] ConfigurationFiles;
        BACnetTimeStamp LastRestoreTime;
        UInt16 BackupFailureTimeout;
        UInt16 BackupPreparationTime;
        UInt16 RestorePreparationTime;
        UInt16 RestoreCompletionTime;
        BACnetBackupState BackupAndRestoreState;
        List<BACnetCOVSubscription> ActiveCOVSubscriptions;
        BACnetRestartReason LastRestartReason;
        BACnetTimeStamp TimeOfDeviceRestart;
        List<BACnetRecipient> RestartNotificationRecipients;
        List<BACnetRecipient> UTCTimeSynchronizationRecipients;
        UInt32 TimeSynchronizationInterval;
        Boolean AlignIntervals;
        UInt32 IntervalOffset;
        String SerialNumber;
        BACnetPropertyIdentifier[] PropertyList;
        BACnetStatusFlags StatusFlags;
        BACnetEventState EventState;
        BACnetReliability Reliability;
        Boolean EventDetectionEnable;
        UInt32 NotificationClass;
        BACnetEventTransitionBits EventEnable;
        BACnetEventTransitionBits AckedTransitions;
        BACnetNotifyType NotifyType;
        BACnetTimeStamp[] EventTimeStamps;
        String[] EventMessageTexts;
        String[] EventMessageTextsConfig;
        Boolean ReliabilityEvaluationInhibit;
        List<BACnetCOVMultipleSubscription> ActiveCOVMultipleSubscriptions;
        BACnetNameValue[] Tags;
        String ProfileLocation;
        String DeployedProfileLocation;
        String ProfileName;
    }
}
