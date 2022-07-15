using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BACNetTool.BACNet
{
    enum BACnetAccessAuthenticationFactorDisable
    {
        None = 0,
        Disabled,
        DisabledLost,
        DisabledStolen,
        DisabledDamaged,
        DisabledDestroyed
    }
    enum BACnetAccessCredentialDisable
    {
        None = 0,
        Disable = 1,
        DisableManual = 2,
        DisableLockout = 3
    }
    enum BACnetAccessCredentialDisableReason
    {
        Disabled = 0,
        DisabledNeedsProvisioning = 1,
        DisabledUnassigned = 2,
        DisabledNotYetActive = 3,
        DisabledExpired = 4,
        DisabledLockout = 5,
        DisabledMaxDays = 6,
        DisabledMaxUses = 7,
        DisabledInactivity = 8,
        DisabledManual = 9
    }
    enum BACnetAccessEvent
    {
        None = 0,
        Granted = 1,
        Muster = 2,
        PassbackDetected = 3,
        Duress = 4,
        Trace = 5,
        LockoutMaxAttempts = 6,
        LockoutOther = 7,
        LockoutRelinquished = 8,
        LockedByHigherPriority = 9,
        OutOfService = 10,
        OutOfServiceRelinquished = 11,
        AccompanimentBy = 12,
        AuthenticationFactorRead = 13,
        AuthorizationDelayed = 14,
        VerificationRequired = 15,
        NoEntryAfterGranted = 16,
        DeniedDenyAll = 128,
        DeniedUnknownCredential = 129,
        DeniedAuthenticationUnavailable = 130,
        DeniedAuthenticationFactorTimeout = 131,
        DeniedIncorrectAuthenticationFactor = 132,
        DeniedZoneNoAccessRights = 133,
        DeniedPointNoAccessRights = 134,
        DeniedNoAccessRights = 135,
        DeniedOutOfTimeRange = 136,
        DeniedThreatLevel = 137,
        DeniedPassback = 138,
        DeniedUnexpectedLocationUsage = 139,
        DeniedMaxAttempts = 140,
        DeniedLowerOccupancyLimit = 141,
        DeniedUpperOccupancyLimit = 142,
        DeniedAuthenticationFactorLost = 143,
        DeniedAuthenticationFactorStolen = 144,
        DeniedAuthenticationFactorDamaged = 145,
        DeniedAuthenticationFactorDestroyed = 146,
        DeniedAuthenticationFactorDisabled = 147,
        DeniedAuthenticationFactorError = 148,
        DeniedCredentialUnassigned = 149,
        DeniedCredentialNotProvisioned = 150,
        DeniedCredentialNotYetActive = 151,
        DeniedCredentialExpired = 152,
        DeniedCredentialManualDisable = 153,
        DeniedCredentialLockout = 154,
        DeniedCredentialMaxDays = 155,
        DeniedCredentialMaxUses = 156,
        DeniedCredentialInactivity = 157,
        DeniedCredentialDisabled = 158,
        DeniedNoAccompaniment = 159,
        DeniedIncorrectAccompaniment = 160,
        DeniedLockout = 161,
        DeniedVerificationFailed = 162,
        DeniedVerificationTimeout = 163,
        DeniedOther = 164
    }
    enum BACnetAccessPassbackMode
    {
        PassbackOff = 0,
        HardPassback = 1,
        SoftPassback = 2
    }
    enum BACnetAccessUserType
    {
        Asset = 0,
        Group = 1,
        Person = 2,
    }
    enum BACnetAccessZoneOccupancyState
    {
        Normal = 0,
        BelowLowerLimit = 1,
        AtLowerLimit = 2,
        AtUpperLimit = 3,
        AboveUpperLimit = 4,
        Disabled = 5,
        NotSupported = 6
    }
    enum BACnetAction
    {
        Direct = 0,
        Reverse = 1
    }
    enum BACnetAuthenticationFactorType
    {
        Undefined = 0,
        Error = 1,
        Custom = 2,
        SimpleNumber16 = 3,
        SimpleNumber32 = 4,
        SimpleNumber56 = 5,
        SimpleAlphaNumeric = 6,
        AbaTrack2 = 7,
        Wiegand26 = 8,
        Wiegand37 = 9,
        Wiegand37Facility = 10,
        Facility16Card32 = 11,
        Facility32Card32 = 12,
        FascN = 13,
        FascNBcd = 14,
        FascNLarge = 15,
        FascNLargeBcd = 16,
        Gsa75 = 17,
        Chuid = 18,
        ChuidFull = 19,
        Guid = 20,
        CbeffA = 21,
        CbeffB = 22,
        CbeffC = 23,
        UserPassword = 24
    }
    enum BACnetAuthenticationStatus
    {
        NotReady = 0,
        Ready = 1,
        Disabled = 2,
        WaitingForAuthenticationFactor = 3,
        WaitingForAccompaniment = 4,
        WaitingForVerification = 5,
        InProgress = 6
    }
    enum BACnetAuthorizationExemption
    {
        Passback = 0,
        OccupancyCheck = 1,
        AccessRights = 2,
        Lockout = 3,
        Deny = 4,
        Verification = 5,
        AuthorizationDelay = 6
    }
    enum BACnetAuthorizationMode
    {
        Authorize = 0,
        GrantActive = 1,
        DenyAll = 2,
        VerificationRequired = 3,
        AuthorizationDelayed = 4,
        None = 5
    }
    enum BACnetBackupState
    {
        Idle = 0,
        PreparingForBackup = 1,
        PreparingForRestore = 2,
        PerformingABackup = 3,
        PerformingARestore = 4,
        BackupFailure = 5,
        RestoreFailure = 6
    }
    enum BACnetBinaryLightingPV
    {
        Off = 0,
        On = 1,
        Warn = 2,
        WarnOff = 3,
        WarnRelinquish = 4,
        Stop = 5
    }
    enum BACnetBinaryPV
    {
        Inactive = 0,
        Active = 1
    }
    enum BACnetDeviceStatus
    {
        Operational = 0,
        OperationalReadOnly = 1,
        DownloadRequired = 2,
        DownloadInProgress = 3,
        NonOperational = 4,
        BackupInProgress = 5
    }
    enum BACnetDoorAlarmState
    {
        Normal = 0,
        Alarm = 1,
        DoorOpenTooLong = 2,
        ForcedOpen = 3,
        Tamper = 4,
        DoorFault = 5,
        LockDown = 6,
        FreeAccess = 7,
        EgressOpen = 8
    }
    enum BACnetDoorSecuredStatus
    {
        Secured = 0,
        Unsecured = 1,
        Unknown = 2
    }
    enum BACnetDoorStatus
    {
        Closed = 0,
        Opened = 1,
        Unknown = 2,
        DoorFault = 3,
        Unused = 4,
        None = 5,
        Closing = 6,
        Opening = 7,
        SafetyLocked = 8,
        LimitedOpened = 9
    }
    enum BACnetDoorValue
    {
        Lock = 0,
        Unlock = 1,
        PulseUnlock = 2,
        ExtendedPulseUnlock = 3
    }
    enum BACnetEscalatorFault
    {
        ControllerFault = 0,
        DriveAndMotorFault = 1,
        MechanicalComponentFault = 2,
        OverspeedFault = 3,
        PowerSupplyFault = 4,
        SafetyDeviceFault = 5,
        ControllerSupplyFault = 6,
        DriveTemperatureExceeded = 7,
        CombPlateFault = 8
    }
    enum BACnetEscalatorMode
    {
        Unknown = 0,
        Stop = 1,
        Up = 2,
        Down = 3,
        Inspection = 4,
        OutOfService = 5
    }
    enum BACnetEscalatorOperationDirection
    {
        Unknown = 0,
        Stopped = 1,
        UpRatedSpeed = 2,
        UpReducedSpeed = 3,
        DownRatedSpeed = 4,
        DownReducedSpeed = 5
    }
    enum BACnetEventState
    {
        Normal = 0,
        Fault = 1,
        Offnormal = 2,
        HighLimit = 3,
        LowLimit = 4,
        LifeSafetyAlarm = 5
    }
    enum BACnetFaultType
    {
        None = 0,
        FaultCharacterstring = 1,
        FaultExtended = 2,
        FaultLifeSafety = 3,
        FaultState = 4,
        FaultStatusFlags = 5,
        FaultOutOfRange = 6,
        FaultListed = 7
    }
    enum BACnetFileAccessMethod
    {
        RecordAccess = 0,
        StreamAccess = 1
    }
    enum BACnetIPMode
    {
        Normal = 0,
        Foreign = 1,
        Bbmd = 2
    }
    enum BACnetLifeSafetyMode
    {
        Off = 0,
        On = 1,
        Test = 2,
        Manned = 3,
        Unmanned = 4,
        Armed = 5,
        Disarmed = 6,
        Prearmed = 7,
        Slow = 8,
        Fast = 9,
        Disconnected = 10,
        Enabled = 11,
        Disabled = 12,
        AutomaticReleaseDisabled = 13,
        Default = 14
    }
    enum BACnetLifeSafetyOperation
    {
        None = 0,
        Silence = 1,
        SilenceAudible = 2,
        SilenceVisual = 3,
        Reset = 4,
        ResetAlarm = 5,
        ResetFault = 6,
        Unsilence = 7,
        UnsilenceAudible = 8,
        UnsilenceVisual = 9
    }
    enum BACnetLifeSafetyState
    {
        Quiet = 0,
        PreAlarm = 1,
        Alarm = 2,
        Fault = 3,
        FaultPreAlarm = 4,
        FaultAlarm = 5,
        NotReady = 6,
        Active = 7,
        Tamper = 8,
        TestAlarm = 9,
        TestActive = 10,
        TestFault = 11,
        TestFaultAlarm = 12,
        Holdup = 13,
        Duress = 14,
        TamperAlarm = 15,
        Abnormal = 16,
        EmergencyPower = 17,
        Delayed = 18,
        Blocked = 19,
        LocalAlarm = 20,
        GeneralAlarm = 21,
        Supervisory = 22,
        TestSupervisory = 23
    }
    enum BACnetLiftCarDirection
    {
        Unknown = 0,
        None = 1,
        Stopped = 2,
        Up = 3,
        Down = 4,
        UpAndDown = 5
    }
    enum BACnetLiftCarDoorCommand
    {
        None = 0,
        Open = 1,
        Close = 2
    }
    enum BACnetLiftCarDriveStatus
    {
        Unknown = 0,
        Stationary = 1,
        Braking = 2,
        Accelerate = 3,
        Decelerate = 4,
        RatedSpeed = 5,
        SingleFloorJump = 6,
        TwoFloorJump = 7,
        ThreeFloorJump = 8,
        MultiFloorJump = 9
    }
    enum BACnetLiftCarMode
    {
        Unknown = 0,
        Normal = 1,
        Vip = 2,
        Homing = 3,
        Parking = 4,
        AttendantControl = 5,
        FirefighterControl = 6,
        EmergencyPower = 7,
        Inspection = 8,
        CabinetRecall = 9,
        EarthquakeOperation = 10,
        FireOperation = 11,
        OutOfService = 12,
        OccupantEvacuation = 13
    }
    enum BACnetLiftFault
    {
        ControllerFault = 0,
        DriveAndMotorFault = 1,
        GovernorAndSafetyGearFault = 2,
        LiftShaftDeviceFault = 3,
        PowerSupplyFault = 4,
        SafetyInterlockFault = 5,
        DoorClosingFault = 6,
        DoorOpeningFault = 7,
        CarStoppedOutsideLandingZone = 8,
        CallButtonStuck = 9,
        StartFailure = 10,
        ControllerSupplyFault = 11,
        SelfTestFailure = 12,
        RuntimeLimitExceeded = 13,
        PositionLost = 14,
        DriveTemperatureExceeded = 15,
        LoadMeasurementFault = 16
    }
    enum BACnetLiftGroupMode
    {
        Unknown = 0,
        Normal = 1,
        DownPeak = 2,
        TwoWay = 3,
        FourWay = 4,
        EmergencyPower = 5,
        UpPeak = 6
    }
    enum BACnetLightingInProgress
    {
        Idle = 0,
        FadeActive = 1,
        RampActive = 2,
        NotControlled = 3,
        Other = 4
    }
    enum BACnetLightingOperation
    {
        None = 0,
        FadeTo = 1,
        RampTo = 2,
        StepUp = 3,
        StepDown = 4,
        StepOn = 5,
        StepOff = 6,
        Warn = 7,
        WarnOff = 8,
        WarnRelinquish = 9,
        Stop = 10
    }
    enum BACnetLightingTransition
    {
        None = 0,
        Fade = 1,
        Ramp = 2
    }
    enum BACnetLockStatus
    {
        Locked = 0,
        Unlocked = 1,
        LockFault = 2,
        Unused = 3,
        Unknown = 4
    }
    enum BACnetLoggingType
    {
        Polled = 0,
        Cov = 1,
        Triggered = 2
    }
    enum BACnetMaintenance
    {
        None = 0,
        PeriodicTest = 1,
        NeedServiceOperational = 2,
        NeedServiceInoperative = 3
    }
    enum BACnetNetworkNumberQuality
    {
        Unknown = 0,
        Learned = 1,
        LearnedConfigured = 2,
        Configured = 3
    }
    enum BACnetNetworkPortCommand
    {
        Idle = 0,
        DiscardChanges = 1,
        RenewFdRegistration = 2,
        RestartSlaveDiscovery = 3,
        RenewDhcp = 4,
        RestartAutonegotiation = 5,
        Disconnect = 6,
        RestartPort = 7
    }
    enum BACnetNetworkType
    {
        Ethernet = 0,
        Arcnet = 1,
        Mstp = 2,
        Ptp = 3,
        Lontalk = 4,
        Ipv4 = 5,
        Zigbee = 6,
        Virtual = 7,
        nonBacnet = 8,
        Ipv6 = 9,
        Serial = 10
    }
    enum BACnetNodeType
    {
        Unknown = 0,
        System = 1,
        Network = 2,
        Device = 3,
        Organizational = 4,
        Area = 5,
        Equipment = 6,
        Point = 7,
        Collection = 8,
        Property = 9,
        Functional = 10,
        Other = 11,
        Subsystem = 12,
        Building = 13,
        Floor = 14,
        Section = 15,
        Module = 16,
        Tree = 17,
        Member = 18,
        Protocol = 19,
        Room = 20,
        Zone = 21
    }
    enum BACnetNotifyType
    {
        Alarm = 0,
        Event = 1,
        AckNotification = 2
    }

    public enum BACnetObjectType
    {
        AccessCredential = 32,
        AccessDoor = 30,
        AccessPoint = 33,
        AccessRights = 34,
        AccessUser = 35,
        AccessZone = 36,
        Accumulator = 23,
        AlertEnrollment = 52,
        AnalogInput = 0,
        AnalogOutput = 1,
        AnalogValue = 2,
        Averaging = 18,
        BinaryInput = 3,
        BinaryLightingOutput = 55,
        BinaryOutput = 4,
        BinaryValue = 5,
        BitstringValue = 39,
        Calendar = 6,
        Channel = 53,
        CharacterstringValue = 40,
        Command = 7,
        CredentialDataInput = 37,
        DatepatternValue = 41,
        DateValue = 42,
        DatetimepatternValue = 43,
        DatetimeValue = 44,
        Device = 8,
        ElevatorGroup = 57,
        Escalator = 58,
        EventEnrollment = 9,
        EventLog = 25,
        File = 10,
        GlobalGroup = 26,
        Group = 11,
        IntegerValue = 45,
        LargeAnalogValue = 46,
        LifeSafetyPoint = 21,
        LifeSafetyZone = 22,
        Lift = 59,
        LightingOutput = 54,
        LoadControl = 28,
        Loop = 12,
        MultiStateInput = 13,
        MultiStateOutput = 14,
        MultiStateValue = 19,
        NetworkPort = 56,
        NetworkSecurity = 38,
        NotificationClass = 15,
        NotificationForwarder = 51,
        OctetstringValue = 47,
        PositiveIntegerValue = 48,
        Program = 16,
        PulseConverter = 24,
        Schedule = 17,
        StructuredView = 29,
        TimepatternValue = 49,
        TimeValue = 50,
        Timer = 31,
        TrendLog = 20,
        TrendLogMultiple = 27
    }
    enum BACnetPolarity
    {
        Normal = 0,
        Reverse = 1
    }
    enum BACnetProgramError
    {
        Normal = 0,
        LoadFailed = 1,
        Internal = 2,
        Program = 3,
        Other = 4
    }
    enum BACnetProgramRequest
    {
        Ready = 0,
        Load = 1,
        Run = 2,
        Halt = 3,
        Restart = 4,
        Unload = 5
    }
    enum BACnetProgramState
    {
        Idle = 0,
        Loading = 1,
        Running = 2,
        Waiting = 3,
        Halted = 4,
        Unloading = 5
    }
    enum BACnetPropertyIdentifier
    {
        AbsenteeLimit = 244,
        AcceptedModes = 175,
        AccessAlarmEvents = 245,
        AccessDoors = 246,
        AccessEvent = 247,
        AccessEventAuthenticationFactor = 248,
        AccessEventCredential = 249,
        AccessEventTag = 322,
        AccessEventTime = 250,
        AccessTransactionEvents = 251,
        Accompaniment = 252,
        AccompanimentTime = 253,
        AckRequired = 1,
        AckedTransitions = 0,
        Action = 2,
        ActionText = 3,
        ActivationTime = 254,
        ActiveAuthenticationPolicy = 255,
        ActiveCovMultipleSubscriptions = 481,
        ActiveCovSubscriptions = 152,
        ActiveText = 4,
        ActiveVtSessions = 5,
        ActualShedLevel = 212,
        AdjustValue = 176,
        AlarmValue = 6,
        AlarmValues = 7,
        AlignIntervals = 193,
        All = 8,
        AllWritesSuccessful = 9,
        AllowGroupDelayInhibit = 365,
        ApduLength = 399,
        ApduSegmentTimeout = 10,
        ApduTimeout = 11,
        ApplicationSoftwareVersion = 12,
        Archive = 13,
        AssignedAccessRights = 256,
        AssignedLandingCalls = 447,
        AttemptedSamples = 124,
        AuthenticationFactors = 257,
        AuthenticationPolicyList = 258,
        AuthenticationPolicyNames = 259,
        AuthenticationStatus = 260,
        AuthorizationExemptions = 364,
        AuthorizationMode = 261,
        AutoSlaveDiscovery = 169,
        AverageValue = 125,
        backupAndRestoreState = 338,
        backupFailureTimeout = 153,
        backupPreparationTime = 339,
        BACnetIpGlobalAddress = 407,
        BACnetIpMode = 408,
        BACnetIpMulticastAddress = 409,
        BACnetIpNatTraversal = 410,
        BACnetIpUdpPort = 412,
        BACnetIpv6Mode = 435,
        BACnetIpv6UdpPort = 438,
        BACnetIpv6MulticastAddress = 440,
        BaseDeviceSecurityPolicy = 327,
        BbmdAcceptFdRegistrations = 413,
        BbmdBroadcastDistributionTable = 414,
        BbmdForeignDeviceTable = 415,
        BelongsTo = 262,
        Bias = 14,
        BitMask = 342,
        BitText = 343,
        BlinkWarnEnable = 373,
        BufferSize = 126,
        CarAssignedDirection = 448,
        CarDoorCommand = 449,
        CarDoorStatus = 450,
        CarDoorText = 451,
        CarDoorZone = 452,
        CarDriveStatus = 453,
        CarLoad = 454,
        CarLoadUnits = 455,
        CarMode = 456,
        CarMovingDirection = 457,
        CarPosition = 458,
        ChangeOfStateCount = 15,
        ChangeOfStateTime = 16,
        ChangesPending = 416,
        ChannelNumber = 366,
        ClientCovIncrement = 127,
        Command = 417,
        CommandTimeArray = 430,
        ConfigurationFiles = 154,
        ControlGroups = 367,
        ControlledVariableReference = 19,
        ControlledVariableUnits = 20,
        ControlledVariableValue = 21,
        Count = 177,
        CountBeforeChange = 178,
        CountChangeTime = 179,
        CovIncrement = 22,
        CovPeriod = 180,
        CovResubscriptionInterval = 128,
        CovuPeriod = 349,
        CovuRecipients = 350,
        CredentialDisable = 263,
        CredentialStatus = 264,
        Credentials = 265,
        CredentialsInZone = 266,
        CurrentCommandPriority = 431,
        DatabaseRevision = 155,
        DateList = 23,
        DaylightSavingsStatus = 24,
        DaysRemaining = 267,
        Deadband = 25,
        DefaultFadeTime = 374,
        DefaultRampRate = 375,
        DefaultStepIncrement = 376,
        DefaultSubordinateRelationship = 490,
        DefaultTimeout = 393,
        DeployedProfileLocation = 484,
        DerivativeConstant = 26,
        DerivativeConstantUnits = 27,
        Description = 28,
        DescriptionOfHalt = 29,
        DeviceAddressBinding = 30,
        DeviceType = 31,
        DirectReading = 156,
        DistributionKeyRevision = 328,
        DoNotHide = 329,
        DoorAlarmState = 226,
        DoorExtendedPulseTime = 227,
        DoorMembers = 228,
        DoorOpenTooLongTime = 229,
        DoorPulseTime = 230,
        DoorStatus = 231,
        DoorUnlockDelayTime = 232,
        DutyWindow = 213,
        EffectivePeriod = 32,
        EgressActive = 386,
        EgressTime = 377,
        ElapsedActiveTime = 33,
        ElevatorGroup = 459,
        Enable = 133,
        EnergyMeter = 460,
        EnergyMeterRef = 461,
        EntryPoints = 268,
        ErrorLimit = 34,
        EscalatorMode = 462,
        EventAlgorithmInhibit = 354,
        EventAlgorithmInhibitRef = 355,
        EventDetectionEnable = 353,
        EventEnable = 35,
        EventMessageTexts = 351,
        EventMessageTextsConfig = 352,
        EventParameters = 83,
        EventState = 36,
        EventTimeStamps = 130,
        EventType = 37,
        ExceptionSchedule = 38,
        ExecutionDelay = 368,
        ExitPoints = 269,
        ExpectedShedLevel = 214,
        ExpirationTime = 270,
        ExtendedTimeEnable = 271,
        FailedAttemptEvents = 272,
        FailedAttempts = 273,
        FailedAttemptsTime = 274,
        FaultHighLimit = 388,
        FaultLowLimit = 389,
        FaultParameters = 358,
        FaultSignals = 463,
        FaultType = 359,
        FaultValues = 39,
        FdBbmdAddress = 418,
        FdSubscriptionLifetime = 419,
        FeedbackValue = 40,
        FileAccessMethod = 41,
        FileSize = 42,
        FileType = 43,
        FirmwareRevision = 44,
        FloorText = 464,
        FullDutyBaseline = 215,
        GlobalIdentifier = 323,
        GroupId = 465,
        GroupMemberNames = 346,
        GroupMembers = 345,
        GroupMode = 467,
        HighLimit = 45,
        HigherDeck = 468,
        InProcess = 47,
        InProgress = 378,
        InactiveText = 46,
        InitialTimeout = 394,
        InputReference = 181,
        InstallationId = 469,
        InstanceOf = 48,
        InstantaneousPower = 379,
        IntegralConstant = 49,
        IntegralConstantUnits = 50,
        InterfaceValue = 387,
        IntervalOffset = 195,
        IpAddress = 400,
        IpDefaultGateway = 401,
        IpDhcpEnable = 402,
        IpDhcpLeaseTime = 403,
        IpDhcpLeaseTimeRemaining = 404,
        IpDhcpServer = 405,
        IpDnsServer = 406,
        IpSubnetMask = 411,
        Ipv6Address = 436,
        Ipv6AutoAddressingEnable = 442,
        Ipv6DefaultGateway = 439,
        Ipv6DhcpLeaseTime = 443,
        Ipv6DhcpLeaseTimeRemaining = 444,
        Ipv6DhcpServer = 445,
        Ipv6DnsServer = 441,
        Ipv6PrefixLength = 437,
        Ipv6ZoneIndex = 446,
        IsUtc = 344,
        KeySets = 330,
        LandingCallControl = 471,
        LandingCalls = 470,
        LandingDoorStatus = 472,
        LastAccessEvent = 275,
        LastAccessPoint = 276,
        LastCommandTime = 432,
        LastCredentialAdded = 277,
        LastCredentialAddedTime = 278,
        LastCredentialRemoved = 279,
        LastCredentialRemovedTime = 280,
        LastKeyServer = 331,
        LastNotifyRecord = 173,
        LastPriority = 369,
        LastRestartReason = 196,
        LastRestoreTime = 157,
        LastStateChange = 395,
        LastUseTime = 281,
        LifeSafetyAlarmValues = 166,
        LightingCommand = 380,
        LightingCommandDefaultPriority = 381,
        LimitEnable = 52,
        LimitMonitoringInterval = 182,
        LinkSpeed = 420,
        LinkSpeedAutonegotiate = 422,
        LinkSpeeds = 421,
        ListOfGroupMembers = 53,
        ListOfObjectPropertyReferences = 54,
        LocalDate = 56,
        LocalForwardingOnly = 360,
        LocalTime = 57,
        Location = 58,
        LockStatus = 233,
        Lockout = 282,
        LockoutRelinquishTime = 283,
        LogBuffer = 131,
        LogDeviceObjectProperty = 132,
        LogInterval = 134,
        LoggingObject = 183,
        LoggingRecord = 184,
        LoggingType = 197,
        LowDiffLimit = 390,
        LowLimit = 59,
        LowerDeck = 473,
        MacAddress = 423,
        MachineRoomId = 474,
        MaintenanceRequired = 158,
        MakingCarCall = 475,
        ManipulatedVariableReference = 60,
        ManualSlaveAddressBinding = 170,
        MaskedAlarmValues = 234,
        MaxActualValue = 382,
        MaxApduLengthAccepted = 62,
        MaxFailedAttempts = 285,
        MaxInfoFrames = 63,
        MaxMaster = 64,
        MaxPresValue = 65,
        MaxSegmentsAccepted = 167,
        MaximumOutput = 61,
        MaximumValue = 135,
        MaximumValueTimestamp = 149,
        MemberOf = 159,
        MemberStatusFlags = 347,
        Members = 286,
        MinActualValue = 383,
        MinPresValue = 69,
        MinimumOffTime = 66,
        MinimumOnTime = 67,
        MinimumOutput = 68,
        MinimumValue = 136,
        MinimumValueTimestamp = 150,
        Mode = 160,
        ModelName = 70,
        ModificationDate = 71,
        MusterPoint = 287,
        NegativeAccessRules = 288,
        NetworkAccessSecurityPolicies = 332,
        NetworkInterfaceName = 424,
        NetworkNumber = 425,
        NetworkNumberQuality = 426,
        NetworkType = 427,
        NextStoppingFloor = 476,
        NodeSubtype = 207,
        NodeType = 208,
        NotificationClass = 17,
        NotificationThreshold = 137,
        NotifyType = 72,
        NumberOfApduRetries = 73,
        NumberOfAuthenticationPolicies = 289,
        NumberOfStates = 74,
        ObjectIdentifier = 75,
        ObjectList = 76,
        ObjectName = 77,
        ObjectPropertyReference = 78,
        ObjectType = 79,
        OccupancyCount = 290,
        OccupancyCountAdjust = 291,
        OccupancyCountEnable = 292,
        OccupancyLowerLimit = 294,
        OccupancyLowerLimitEnforced = 295,
        OccupancyState = 296,
        OccupancyUpperLimit = 297,
        OccupancyUpperLimitEnforced = 298,
        OperationDirection = 477,
        OperationExpected = 161,
        Optional = 80,
        OutOfService = 81,
        OutputUnits = 82,
        PacketReorderTime = 333,
        PassbackMode = 300,
        PassbackTimeout = 301,
        PassengerAlarm = 478,
        Polarity = 84,
        PortFilter = 363,
        PositiveAccessRules = 302,
        Power = 384,
        PowerMode = 479,
        Prescale = 185,
        PresentValue = 85,
        Priority = 86,
        PriorityArray = 87,
        PriorityForWriting = 88,
        ProcessIdentifier = 89,
        ProcessIdentifierFilter = 361,
        ProfileLocation = 485,
        ProfileName = 168,
        ProgramChange = 90,
        ProgramLocation = 91,
        ProgramState = 92,
        PropertyList = 371,
        ProportionalConstant = 93,
        ProportionalConstantUnits = 94,
        ProtocolLevel = 482,
        ProtocolObjectTypesSupported = 96,
        ProtocolRevision = 139,
        ProtocolServicesSupported = 97,
        ProtocolVersion = 98,
        PulseRate = 186,
        ReadOnly = 99,
        ReasonForDisable = 303,
        ReasonForHalt = 100,
        RecipientList = 102,
        RecordCount = 141,
        RecordsSinceNotification = 140,
        ReferencePort = 483,
        RegisteredCarCall = 480,
        Reliability = 103,
        ReliabilityEvaluationInhibit = 357,
        RelinquishDefault = 104,
        Represents = 491,
        RequestedShedLevel = 218,
        RequestedUpdateInterval = 348,
        Required = 105,
        Resolution = 106,
        RestartNotificationRecipients = 202,
        RestoreCompletionTime = 340,
        RestorePreparationTime = 341,
        RoutingTable = 428,
        Scale = 187,
        ScaleFactor = 188,
        ScheduleDefault = 174,
        SecuredStatus = 235,
        SecurityPduTimeout = 334,
        SecurityTimeWindow = 335,
        SegmentationSupported = 107,
        SerialNumber = 372,
        Setpoint = 108,
        SetpointReference = 109,
        Setting = 162,
        ShedDuration = 219,
        ShedLevelDescriptions = 220,
        ShedLevels = 221,
        Silenced = 163,
        SlaveAddressBinding = 171,
        SlaveProxyEnable = 172,
        StartTime = 142,
        StateChangeValues = 396,
        StateDescription = 222,
        StateText = 110,
        StatusFlags = 111,
        StopTime = 143,
        StopWhenFull = 144,
        StrikeCount = 391,
        StructuredObjectList = 209,
        SubordinateAnnotations = 210,
        SubordinateList = 211,
        SubordinateNodeTypes = 487,
        SubordinateRelationships = 489,
        SubordinateTags = 488,
        SubscribedRecipients = 362,
        SupportedFormatClasses = 305,
        SupportedFormats = 304,
        SupportedSecurityAlgorithms = 336,
        SystemStatus = 112,
        Tags = 486,
        ThreatAuthority = 306,
        ThreatLevel = 307,
        TimeDelay = 113,
        TimeDelayNormal = 356,
        TimeOfActiveTimeReset = 114,
        TimeOfDeviceRestart = 203,
        TimeOfStateCountReset = 115,
        TimeOfStrikeCountReset = 392,
        TimeSynchronizationInterval = 204,
        TimeSynchronizationRecipients = 116,
        TimerRunning = 397,
        TimerState = 398,
        TotalRecordCount = 145,
        TraceFlag = 308,
        TrackingValue = 164,
        TransactionNotificationClass = 309,
        Transition = 385,
        Trigger = 205,
        Units = 117,
        UpdateInterval = 118,
        UpdateKeySetTimeout = 337,
        UpdateTime = 189,
        UserExternalIdentifier = 310,
        UserInformationReference = 311,
        UserName = 317,
        UserType = 318,
        UsesRemaining = 319,
        UtcOffset = 119,
        UtcTimeSynchronizationRecipients = 206,
        ValidSamples = 146,
        ValueBeforeChange = 190,
        ValueChangeTime = 192,
        ValueSet = 191,
        ValueSource = 433,
        ValueSourceArray = 434,
        VarianceValue = 151,
        VendorIdentifier = 120,
        VendorName = 121,
        VerificationTime = 326,
        VirtualMacAddressTable = 429,
        VtClassesSupported = 122,
        WeeklySchedule = 123,
        WindowInterval = 147,
        WindowSamples = 148,
        WriteStatus = 370,
        ZoneFrom = 320,
        ZoneMembers = 165,
        ZoneTo = 321
    }
    enum BACnetProtocolLevel
    {
        Physical = 0,
        Protocol = 1,
        BACnetApplication = 2,
        NonBacnetApplication = 3
    }
    enum BACnetRelationship
    {
        Unknown = 0,
        Default = 1,
        Contains = 2,
        ContainedBy = 3,
        Uses = 4,
        UsedBy = 5,
        Commands = 6,
        CommandedBy = 7,
        Adjusts = 8,
        AdjustedBy = 9,
        Ingress = 10,
        Egress = 11,
        SuppliesAir = 12,
        ReceivesAir = 13,
        SuppliesHotAir = 14,
        ReceivesHotAir = 15,
        SuppliesCoolAir = 16,
        ReceivesCoolAir = 17,
        SuppliesPower = 18,
        ReceivesPower = 19,
        SuppliesGas = 20,
        ReceivesGas = 21,
        SuppliesWater = 22,
        ReceivesWater = 23,
        SuppliesHotWater = 24,
        ReceivesHotWater = 25,
        SuppliesCoolWater = 26,
        ReceivesCoolWater = 27,
        SuppliesSteam = 28,
        ReceivesSteam = 29
    }
    enum BACnetReliability
    {
        NoFaultDetected = 0,
        NoSensor = 1,
        OverRange = 2,
        UnderRange = 3,
        OpenLoop = 4,
        ShortedLoop = 5,
        NoOutput = 6,
        UnreliableOther = 7,
        ProcessError = 8,
        MultiStateFault = 9,
        ConfigurationError = 10,
        CommunicationFailure = 12,
        MemberFault = 13,
        MonitoredObjectFault = 14,
        Tripped = 15,
        LampFailure = 16,
        ActivationFailure = 17,
        RenewDhcpFailure = 18,
        RenewFdRegistrationFailure = 19,
        RestartAutoNegotiationFailure = 20,
        RestartFailure = 21,
        ProprietaryCommandFailure = 22,
        FaultsListed = 23,
        ReferencedObjectFault = 24
    }
    enum BACnetRestartReason
    {
        Unknown = 0,
        Coldstart = 1,
        Warmstart = 2,
        DetectedPowerLost = 3,
        DetectedPoweredOff = 4,
        HardwareWatchdog = 5,
        SoftwareWatchdog = 6,
        Suspended = 7,
        ActivateChanges = 8
    }
    enum BACnetSecurityLevel
    {
        Incapable = 0,
        Plain = 1,
        Signed = 2,
        Encrypted = 3,
        SignedEndToEnd = 4,
        EncryptedEndToEnd = 5
    }
    enum BACnetSecurityPolicy
    {
        PlainNonTrusted = 0,
        PlainTrusted = 1,
        SignedTrusted = 2,
        EncryptedTrusted = 3
    }
    enum BACnetSegmentation
    {
        SegmentedBoth = 0,
        SegmentedTransmit = 1,
        SegmentedReceive = 2,
        NoSegmentation = 3
    }
    enum BACnetShedState
    {
        ShedInactive = 0,
        ShedRequestPending = 1,
        ShedCompliant = 2,
        ShedNonCompliant = 3
    }
    enum BACnetSilencedState
    {
        Unsilenced = 0,
        AudibleSilenced = 1,
        VisibleSilenced = 2,
        AllSilenced = 3
    }
    enum BACnetTimerState
    {
        Idle = 0,
        Running = 1,
        Expired = 2
    }
    enum BACnetTimerTransition
    {
        None = 0,
        IdleToRunning = 1,
        RunningToIdle = 2,
        RunningToRunning = 3,
        RunningToExpired = 4,
        ForcedToExpired = 5,
        ExpiredToIdle = 6,
        ExpiredToRunning = 7
    }
    enum BACnetVTClass
    {
        DefaultTerminal = 0,
        AnsiX364 = 1,
        DecVt52 = 2,
        DecVt100 = 3,
        DecVt220 = 4,
        Hp70094 = 5,
        Ibm3130 = 6
    }
    enum BACnetWriteStatus
    {
        Idle = 0,
        InProgress = 1,
        Successful = 2,
        Failed = 3
    }

    enum BACnetStatusFlags
    {
        InAlarm = 0,
        Fault = 1,
        Overridden = 2,
        OutOfService = 3
    }

    enum BACnetLimitEnable
    {
        LowLimitEnable = 0,
        HighLimitEnable = 1
    }

    enum BACnetEventTransitionBits
    {
        ToOffnormal = 0,
        ToFault = 1,
        ToNormal = 2
    }




    enum BACnetEngineeringUnits
    {
        MetersPerSecondPerSecond = 166,
        SquareMeters = 0,
        SquareCentimeters = 116,
        SquareFeet = 1,
        SquareInches = 115,
        Currency1 = 105,
        Currency2 = 106,
        Currency3 = 107,
        Currency4 = 108,
        Currency5 = 109,
        Currency6 = 110,
        Currency7 = 111,
        Currency8 = 112,
        Currency9 = 113,
        Currency10 = 114,
        Milliamperes = 2,
        Amperes = 3,
        AmperesPerMeter = 167,
        AmperesPerSquareMeter = 168,
        AmpereSquareMeters = 169,
        Decibels = 199,
        DecibelsMillivolt = 200,
        DecibelsVolt = 201,
        Farads = 170,
        Henrys = 171,
        Ohms = 4,
        OhmMeterSquaredPerMeter = 237,
        OhmMeters = 172,
        Milliohms = 145,
        Kilohms = 122,
        Megohms = 123,
        Microsiemens = 190,
        Millisiemens = 202,
        Siemens = 173,
        SiemensPerMeter = 174,
        Teslas = 175,
        Volts = 5,
        Millivolts = 124,
        Kilovolts = 6,
        Megavolts = 7,
        VoltAmperes = 8,
        KilovoltAmperes = 9,
        MegavoltAmperes = 10,
        VoltAmperesReactive = 11,
        KilovoltAmperesReactive = 12,
        MegavoltAmperesReactive = 13,
        VoltsPerDegreeKelvin = 176,
        VoltsPerMeter = 177,
        DegreesPhase = 14,
        PowerFactor = 15,
        Webers = 178,
        AmpereSeconds = 238,
        VoltAmpereHours = 239,
        KilovoltAmpereHours = 240,
        MegavoltAmpereHours = 241,
        VoltAmpereHoursReactive = 242,
        KilovoltAmpereHoursReactive = 243,
        MegavoltAmpereHoursReactive = 244,
        VoltSquareHours = 245,
        AmpereSquareHours = 246,
        Joules = 16,
        Kilojoules = 17,
        KilojoulesPerKilogram = 125,
        Megajoules = 126,
        WattHours = 18,
        KilowattHours = 19,
        MegawattHours = 146,
        WattHoursReactive = 203,
        KilowattHoursReactive = 204,
        MegawattHoursReactive = 205,
        Btus = 20,
        KiloBtus = 147,
        MegaBtus = 148,
        Therms = 21,
        TonHours = 22,
        JoulesPerKilogramDryAir = 23,
        KilojoulesPerKilogramDryAir = 149,
        MegajoulesPerKilogramDryAir = 150,
        BtusPerPoundDryAir = 24,
        BtusPerPound = 117,
        JoulesPerDegreeKelvin = 127,
        KilojoulesPerDegreeKelvin = 151,
        MegajoulesPerDegreeKelvin = 152,
        JoulesPerKilogramDegreeKelvin = 128,
        Newton = 153,
        CyclesPerHour = 25,
        CyclesPerMinute = 26,
        Hertz = 27,
        Kilohertz = 129,
        Megahertz = 130,
        PerHour = 131,
        GramsOfWaterPerKilogramDryAir = 28,
        PercentRelativeHumidity = 29,
        Micrometers = 194,
        Millimeters = 30,
        Centimeters = 118,
        Kilometers = 193,
        Meters = 31,
        Inches = 32,
        Feet = 33,
        Candelas = 179,
        CandelasPerSquareMeter = 180,
        WattsPerSquareFoot = 34,
        WattsPerSquareMeter = 35,
        Lumens = 36,
        Luxes = 37,
        FootCandles = 38,
        Milligrams = 196,
        Grams = 195,
        Kilograms = 39,
        PoundsMass = 40,
        Tons = 41,
        GramsPerSecond = 154,
        GramsPerMinute = 155,
        KilogramsPerSecond = 42,
        KilogramsPerMinute = 43,
        KilogramsPerHour = 44,
        PoundsMassPerSecond = 119,
        PoundsMassPerMinute = 45,
        PoundsMassPerHour = 46,
        TonsPerHour = 156,
        Milliwatts = 132,
        Watts = 47,
        Kilowatts = 48,
        Megawatts = 49,
        BtusPerHour = 50,
        KiloBtusPerHour = 157,
        JoulePerHours = 247,
        Horsepower = 51,
        TonsRefrigeration = 52,
        Pascals = 53,
        Hectopascals = 133,
        Kilopascals = 54,
        Millibars = 134,
        Bars = 55,
        PoundsForcePerSquareInch = 56,
        MillimetersOfWater = 206,
        CentimetersOfWater = 57,
        InchesOfWater = 58,
        MillimetersOfMercury = 59,
        CentimetersOfMercury = 60,
        InchesOfMercury = 61,
        DegreesCelsius = 62,
        DegreesKelvin = 63,
        DegreesKelvinPerHour = 181,
        DegreesKelvinPerMinute = 182,
        DegreesFahrenheit = 64,
        DegreeDaysCelsius = 65,
        DegreeDaysFahrenheit = 66,
        DeltaDegreesFahrenheit = 120,
        DeltaDegreesKelvin = 121,
        Years = 67,
        Months = 68,
        Weeks = 69,
        Days = 70,
        Hours = 71,
        Minutes = 72,
        Seconds = 73,
        HundredthsSeconds = 158,
        Milliseconds = 159,
        NewtonMeters = 160,
        IllimetersPerSecond = 161,
        MillimetersPerMinute = 162,
        MetersPerSecond = 74,
        MetersPerMinute = 163,
        MetersPerHour = 164,
        KilometersPerHour = 75,
        FeetPerSecond = 76,
        FeetPerMinute = 77,
        MilesPerHour = 78,
        CubicFeet = 79,
        CubicMeters = 80,
        ImperialGallons = 81,
        Milliliters = 197,
        Liters = 82,
        UsGallons = 83,
        CubicFeetPerSecond = 142,
        CubicFeetPerMinute = 84,
        MillionStandardCubicFeetPerMinute = 254,
        CubicFeetPerHour = 191,
        CubicFeetPerDay = 248,
        StandardCubicFeetPerDay = 47808,
        MillionStandardCubicFeetPerDay = 47809,
        ThousandCubicFeetPerDay = 47810,
        ThousandStandardCubicFeetPerDay = 47811,
        PoundsMassPerDay = 47812,
        CubicMetersPerSecond = 85,
        CubicMetersPerMinute = 165,
        CubicMetersPerHour = 135,
        CubicMetersPerDay = 249,
        ImperialGallonsPerMinute = 86,
        MillilitersPerSecond = 198,
        LitersPerSecond = 87,
        LitersPerMinute = 88,
        LitersPerHour = 136,
        UsGallonsPerMinute = 89,
        UsGallonsPerHour = 192,
        DegreesAngular = 90,
        DegreesCelsiusPerHour = 91,
        DegreesCelsiusPerMinute = 92,
        DegreesFahrenheitPerHour = 93,
        DegreesFahrenheitPerMinute = 94,
        JouleSeconds = 183,
        KilogramsPerCubicMeter = 186,
        KilowattHoursPerSquareMeter = 137,
        KilowattHoursPerSquareFoot = 138,
        WattHoursPerCubicMeter = 250,
        JoulesPerCubicMeter = 251,
        MegajoulesPerSquareMeter = 139,
        MegajoulesPerSquareFoot = 140,
        MolePercent = 252,
        NoUnits = 95,
        NewtonSeconds = 187,
        NewtonsPerMeter = 188,
        PartsPerMillion = 96,
        PartsPerBillion = 97,
        PascalSeconds = 253,
        Percent = 98,
        PercentObscurationPerFoot = 143,
        PercentObscurationPerMeter = 144,
        PercentPerSecond = 99,
        PerMinute = 100,
        PerSecond = 101,
        PsiPerDegreeFahrenheit = 102,
        Radians = 103,
        RadiansPerSecond = 184,
        RevolutionsPerMinute = 104,
        SquareMetersPerNewton = 185,
        WattsPerMeterPerDegreeKelvin = 189,
        WattsPerSquareMeterDegreeKelvin = 141,
        PerMille = 207,
        GramsPerGram = 208,
        KilogramsPerKilogram = 209,
        GramsPerKilogram = 210,
        MilligramsPerGram = 211,
        MilligramsPerKilogram = 212,
        GramsPerMilliliter = 213,
        GramsPerLiter = 214,
        MilligramsPerLiter = 215,
        MicrogramsPerLiter = 216,
        GramsPerCubicMeter = 217,
        MilligramsPerCubicMeter = 218,
        MicrogramsPerCubicMeter = 219,
        NanogramsPerCubicMeter = 220,
        GramsPerCubicCentimeter = 221,
        Becquerels = 222,
        Kilobecquerels = 223,
        Megabecquerels = 224,
        Gray = 225,
        Milligray = 226,
        Microgray = 227,
        Sieverts = 228,
        Millisieverts = 229,
        Microsieverts = 230,
        MicrosievertsPerHour = 231,
        Millirems = 47814,
        MilliremsPerHour = 47815,
        DecibelsA = 232,
        NephelometricTurbidityUnit = 233,
        PH = 234,
        GramsPerSquareMeter = 235,
        MinutesPerDegreeKelvin = 236
    }

    class BACnetVTSession
    {
        //technically could put char instead of uint16
        UInt16 localVTSessionID;
        UInt16 remoteVTSessionID;
        BACnetAddress remoteVTAddress;
    }

    [Flags]
    enum BACnetServicesSupported : Int64
    {
        AcknowledgeAlarm = 549755813888,
        ConfirmedCOVNotification = 274877906944,
        ConfirmedEventNotification = 137438953472,
        GetAlarmSummary = 68719476736,
        GetEnrollmentSummary = 34359738368,
        SubscribeCOV = 17179869184,
        AtomicReadFile = 8589934592,
        AtomicWriteFile = 4294967296,
        AddListElement = 2147483648,
        RemoveListElement = 1073741824,
        CreateObject = 536870912,
        DeleteObject = 268435456,
        ReadProperty = 134217728,
        ReadPropertyConditional = 67108864,
        ReadPropertyMultiple = 33554432,
        WriteProperty = 16777216,
        WritePropertyMultiple = 8388608,
        DeviceCommunicationControl = 4194304,
        ConfirmedPrivateTransfer = 2097152,
        ConfirmedTextMessage = 1048576,
        ReinitializeDevice = 524288,
        VTOpen = 262144,
        VTClose = 131072,
        VTData = 65536,
        Authenticate = 32768,
        RequestKey = 16384,
        IAm = 8192,
        IHave = 4096,
        UnconfirmedCOVNotification = 2048,
        UnconfirmedEventNotification = 1024,
        UnconfirmedPrivateTransfer = 512,
        UnconfirmedTextMessage = 256,
        TimeSynchronization = 128,
        WhoHas = 64,
        WhoIs = 32,
        ReadRange = 16,
        UTUTimeSynchronization = 8,
        LifeSafetyOperation = 4,
        SubscribeCOVProperty = 2,
        GetEventInformation = 1
    }

    [Flags]
    enum BACnetObjectTypesSupported : Int64
    {
        Lift = 1,
        Escalator = 2,
        ElevatorGroup = 4,
        NetworkPort = 8,
        BinaryLightingOutput = 16,
        LightingOutput = 32,
        Channel = 64,
        AlertEnrollment = 128,
        NotificationForwarder = 256,
        TimeValue = 512,
        TimepatternValue = 1024,
        PositiveIntegerValue = 2048,
        OctetstringValue = 4096,
        LargeAnalogValue = 8192,
        IntegerValue = 16384,
        DatetimeValue = 32768,
        DatetimepatternValue = 65536,
        DateValue = 131072,
        DatepatternValue = 262144,
        CharacterstringValue = 524288,
        BitstringValue = 1048576,
        NetworkSecurity = 2097152,
        CredentialDataInput = 4194304,
        AccessZone = 8388608,
        AccessUser = 16777216,
        AccessRights = 33554432,
        AccessPoint = 67108864,
        AccessCredential = 134217728,
        Timer = 268435456,
        AccessDoor = 536870912,
        StructuredView = 1073741824,
        LoadControl = 2147483648,
        TrendLogMultiple = 4294967296,
        GlobalGroup = 8589934592,
        EventLog = 17179869184,
        PulseConverter = 34359738368,
        Accumulator = 68719476736,
        LifeSafetyZone = 137438953472,
        LifeSafetyPoint = 274877906944,
        TrendLog = 549755813888,
        MultiStateValue = 1099511627776,
        Averaging = 2199023255552,
        Schedule = 4398046511104,
        Program = 8796093022208,
        NotificationClass = 17592186044416,
        MultiStateOutput = 35184372088832,
        MultiStateInput = 70368744177664,
        Loop = 140737488355328,
        Group = 281474976710656,
        File = 562949953421312,
        EventEnrollment = 1125899906842620,
        Device = 2251799813685250,
        Command = 4503599627370500,
        Calendar = 9007199254740990,
        BinaryValue = 18014398509482000,
        BinaryOutput = 36028797018964000,
        BinaryInput = 72057594037927900,
        AnalogValue = 144115188075856000,
        AnalogOutput = 288230376151712000,
        AnalogInput = 576460752303423000
    }

    class BACnetRecipient
    {
        BACnetObjectIdentifier recipient;
        UInt32 processIdentifier;
    }

    class BACnetAddressBinding
    {
        BACnetObjectIdentifier deviceIdentifier;
        BACnetAddress deviceAddress;
    }

    class BACnetCOVSubscription
    {
        BACnetRecipientProcess recipient;
        BACnetObjectPropertyReference monitoredPropertyReference;
        Boolean issueConfirmedNotifications;
        //is it 32 or 16? it just says unsigned.
        UInt32 timeRemaining;
        //is real a float or double?
        Double COVIncrement;
    }

    class BACnetObjectPropertyReference
    {
        BACnetObjectIdentifier objectIdentifier;
        BACnetPropertyIdentifier propertyIdentifier;
        UInt32 propertyArrayIndex;
    }

    class BACnetPropertyReference
    {
        BACnetPropertyIdentifier propertyIdentifier;
        UInt32 propertyArrayIndex;
    }

    class BACnetCOVMultipleSubscription
    {
        class COVSubscriptionSpecifications
        {
            class COVReferences
            {
                BACnetPropertyReference monitoredProperty;
                Double COVIncrement;
                Boolean timeStamped;
            }

            BACnetObjectIdentifier monitoredObjectIdentifier;
            List<COVReferences> listOfCOVReferences;
        }

        BACnetRecipientProcess recipient;
        Boolean issueConfirmedNotifications;
        UInt32 timeRemaining;
        UInt32 maxNotificationDelay;
        List<COVSubscriptionSpecifications> listOfCOVSSubscriptionSpecifications;
    }

    class BACnetRecipientProcess
    {
        BACnetRecipient recipient;
        UInt32 processIdentifier;
    }

    class BACnetTimeStamp
    {
        DateTime time;
        UInt16 sequenceNumber;
        BACnetDateTime dateTime;
    }

    class BACnetNameValue
    {
        String name;
        //TODO: figure out var value
    }

    class BACnetAddress
    {
        UInt16 networkNumber;
        Byte macAddress;
    }

    class BACnetDateTime
    {
        //TODO: lookup restrictions
        DateTime date;
        DateTime time;
    }

    class BACnetPriorityArray
    {
        BACnetPriorityValue[] priorityArray;
    }

    class BACnetPriorityValue
    {
        Byte value;
        BACnetBaseDataType type;
    }

    enum BACnetBaseDataType
    {
        NULL,
        REAL,
        ENUMERATED,
        Unsigned,
        BOOLEAN,
        INTEGER,
        Double,
        Time,
        CharacterString,
        OCTETSTRING,
        BITSTRING,
        Date,
        BACnetObjectIdentifier,
        ABSTRACT,
        BACnetDateTime
    }


    class BACnetValueSource
    {
        public BACnetValueSource(BACnetDeviceObjectReference o)
        {
            BACnetDeviceObjectReference Object = o;
        }
        public BACnetValueSource(BACnetAddress a)
        {
            BACnetAddress Address = a;
        }
    }


    class BACnetDeviceObjectReference
    {
        BACnetObjectIdentifier deviceIdentifier;
        BACnetObjectIdentifier objectIdentifier;
    }

}
