﻿namespace EfsTools.Qualcomm.QcdmCommands
{
    internal enum QcdmCommand : byte
    {
        Version = 0x00, // 0
        Esn = 0x01, // 1
        MemoryPeekByte = 0x02, // 2
        MemoryPeekWord = 0x03, // 3
        MemoryPeekDword = 0x04, // 4
        MemoryPokeByte = 0x05, // 5
        MemoryPokeWord = 0x06, // 6
        MemoryPokeDword = 0x07, // 7
        OutputByte = 0x08, // 8
        OutputWord = 0x09, // 9
        InputByte = 0x0a, // 10
        InputWord = 0x0b, // 11
        Status = 0x0c, // 12
        Logmask = 0x0f, // 15
        Log = 0x10, // 16
        NvPeek = 0x11, // 17
        NvPoke = 0x12, // 18
        BadCmd = 0x13, // 19
        BadParm = 0x14, // 20
        BadLen = 0x15, // 21
        BadMode = 0x18, // 24
        Tagraph = 0x19, // 25
        Markov = 0x1a, // 26
        MarkovReset = 0x1b, // 27
        DiagVersion = 0x1c, // 28
        Time = 0x1d, // 29
        TaParm = 0x1e, // 30
        Msg = 0x1f, // 31
        HsKey = 0x20, // 32
        HsLock = 0x21, // 33
        HsScreen = 0x22, // 34
        ParmSet = 0x24, // 36
        NvRead = 0x26, // 38
        NvWrite = 0x27, // 39
        Control = 0x29, // 41
        ErrRead = 0x2a, // 42
        ErrClear = 0x2b, // 43
        SerReset = 0x2c, // 44
        SerReport = 0x2d, // 45
        Test = 0x2e, // 46
        GetDipsw = 0x2f, // 47
        SetDipsw = 0x30, // 48
        VocPcmLb = 0x31, // 49
        VocPktLb = 0x32, // 50
        Orig = 0x35, // 53
        End = 0x36, // 54
        Dload = 0x3a, // 58
        TmCmd = 0x3b, // 59
        TestState = 0x3d, // 61
        State = 0x3f, // 63
        PilotSets = 0x40, // 64
        Spc = 0x41, // 65
        BadSpcMode = 0x42, // 66
        ParmGet2 = 0x43, // 67
        SerialChg = 0x44, // 68
        Password = 0x46, // 70
        BadSecMode = 0x47, // 71
        PrListWr = 0x48, // 72
        PrListRd = 0x49, // 73
        SubsysCmd = 0x4b, // 75
        FeatureQuery = 0x51, // 81
        SmsRead = 0x53, // 83
        SmsWrite = 0x54, // 84
        Super = 0x55, // 85
        SupWalshCodes = 0x56, // 86
        SetMaxSupCh = 0x57, // 87
        ParmGetIs95B = 0x58, // 88
        SOp = 0x59, // 89
        AkeyVerify = 0x5a, // 90
        BmpHsScreen = 0x5b, // 91
        ConfigComm = 0x5c, // 92
        ExtLogmask = 0x5d, // 93
        EventReport = 0x60, // 96
        StreamingConfig = 0x61, // 97
        ParmRetrieve = 0x62, // 98
        StatusSnapshot = 0x63, // 99
        Rpc = 0x64, // 100
        GetProperty = 0x65, // 101
        PutProperty = 0x66, // 102
        GetGuid = 0x67, // 103
        UserCmd = 0x68, // 104
        GetPermProperty = 0x69, // 105
        PutPermProperty = 0x6a, // 106
        PermUserCmd = 0x6b, // 107
        GpsSessCtrl = 0x6c, // 108
        GpsGrid = 0x6d, // 109
        GpsStatistics = 0x6e, // 110
        Route = 0x6f, // 111
        Is2000Status = 0x70, // 112
        RlpStatReset = 0x71, // 113
        TdsoStatReset = 0x72, // 114
        LogConfig = 0x73, // 115
        TraceEventReport = 0x74, // 116
        SbiRead = 0x75, // 117
        SbiWrite = 0x76, // 118
        SsdVerify = 0x77, // 119
        LogOnDemand = 0x78, // 120
        ExtMsg = 0x79, // 121
        Oncrpc = 0x7a, // 122
        ProtocolLoopback = 0x7b, // 123
        ExtBuildId = 0x7c, // 124
        ExtMsgConfig = 0x7d, // 125
        ExtMsgTerse = 0x7e, // 126
        ExtMsgTerseXlate = 0x7f, // 127
        SubsysCmdVer2 = 0x80, // 128
        EventMaskGet = 0x81, // 129
        EventMaskSet = 0x82, // 130
        ChangePortSettings = 0x8c, // 140
        CntryInfo = 0x8d, // 141
        SupsReq = 0x8e, // 142
        MmsOrigSmsRequest = 0x8f, // 143
        MeasMode = 0x90, // 144
        MeasReq = 0x91, // 145
        Max = 0x92 // 146
    }
}