using System;
using System.Drawing;

using ObjCRuntime;
using Foundation;
using UIKit;

namespace MonoTouch.FlurryAnalytics
{
    [BaseType(typeof(NSObject))]
    interface Flurry
    {
        [Static]
        [Export("setAppVersion:")]
        void SetAppVersion(string version);

        [Static]
        [Export("getFlurryAgentVersion")]
        string GetFlurryAgentVersion();

        [Static]
        [Export("setShowErrorInLogEnabled:")]
        void SetShowErrorInLog(bool value);

        [Static]
        [Export("setDebugLogEnabled:")]
        void SetDebugLog(bool value);

        [Static]
        [Export("setLogLevel:")]
        void SetLogLevel(FlurryLogLevel value);

        [Static]
        [Export("setSessionContinueSeconds:")]
        void SetSessionContinue(int seconds);

        [Static]
        [Export("setCrashReportingEnabled:")]
        void SetCrashReportingEnabled(bool value);

        [Static]
        [Export("startSession:")]
        void StartSession(string apiKey);

        [Static]
        [Export("startSession:withOptions:")]
        void StartSession(string apiKey, NSDictionary options);

        [Static]
        [Export("activeSessionExists")]
        bool ActiveSessionExists();

        [Static]
        [Export("pauseBackgroundSession:")]
        void PauseBackgroundSession();

        [Static]
        [Export("addOrigin:withVersion:")]
        void AddOrigin(String originName, string originVersion);

        [Static]
        [Export("addOrigin:withVersion:withParameters:")]
        void AddOrigin(String originName, string originVersion, NSDictionary parameters);

        [Static]
        [Export("logEvent:")]
        FlurryEventRecordStatus LogEvent(string eventName);

        [Static]
        [Export("logEvent:withParameters:")]
        FlurryEventRecordStatus LogEvent(string eventName, NSDictionary parameters);

        [Static]
        [Export("logError:message:exception:")]
        void LogError(string errorID, string message, NSException exception);

        [Static]
        [Export("logError:message:error:")]
        void LogError(string errorID, string message, NSError error);

        [Static]
        [Export("logEvent:timed:")]
        FlurryEventRecordStatus LogEvent(string eventName, bool timed);

        [Static]
        [Export("logEvent:withParameters:timed:")]
        FlurryEventRecordStatus LogEvent(string eventName, NSDictionary parameters, bool timed);

        [Static]
        [Export("endTimedEvent:withParameters:")]
        void EndTimedEvent(string eventName, NSDictionary parameters);

        [Static]
        [Export("logAllPageViewsForTarget:")]
        void LogAllPageViews(NSObject target);

        [Static]
        [Export("stopLogPageViewsForTarget:")]
        void StopLogAllPageViews(NSObject target);

        [Static]
        [Export("logPageView")]
        void LogPageView();

        [Static]
        [Export("setUserID:")]
        void SetUserID(string userID);

        [Static]
        [Export("setAge:")]
        void SetAge(int age);

        [Static]
        [Export("setGender:")]
        void SetGender(string gender);

        [Static]
        [Export("setLatitude:longitude:horizontalAccuracy:verticalAccuracy:")]
        void SetLocation(double latitude, double longitude, float horizontalAccuracy, float verticalAccuracy);

        [Static]
        [Export("setSessionReportsOnCloseEnabled:")]
        void SetSessionReportsOnClose(bool sendSessionReportsOnClose);

        [Static]
        [Export("setSessionReportsOnPauseEnabled:")]
        void SetSessionReportsOnPause(bool setSessionReportsOnPauseEnabled);

        [Static]
        [Export("setBackgroundSessionEnabled:")]
        void SetBackgroundSession(bool setBackgroundSessionEnabled);

        [Static]
        [Export("setEventLoggingEnabled:")]
        void SetEventLogging(bool value);
    }
}