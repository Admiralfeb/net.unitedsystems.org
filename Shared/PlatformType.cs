using System.ComponentModel;

namespace UnitedSystemsCooperativeWebsite.Shared;

public enum PlatformType
{
    [Description("PC")]
    PC,
    [Description("Xbox")]
    Xbox,
    [Description("PlayStation")]
    PS,
    Unknown
}