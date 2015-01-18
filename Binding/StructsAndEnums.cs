using System;

namespace MonoTouch.FlurryAnalytics
{
    public enum FlurryLogLevel
    {
        None = 0,
        CriticalOnly,
        Debug,
        All
    }

    public enum FlurryEventRecordStatus
    {
        Failed = 0,
        Recorded,
        UniqueCountExceeded,
        ParamsCountExceeded,
        LogCountExceeded,
        LoggingDelayed
    }
}

