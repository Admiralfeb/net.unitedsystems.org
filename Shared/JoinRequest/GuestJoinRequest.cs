using System.ComponentModel.DataAnnotations;

namespace UnitedSystemsCooperativeWebsite.Shared.JoinRequest;

public class GuestJoinRequest : JoinRequestBase, IJoinRequestReferral
{
    [Required]
    [Range(typeof(ReferralType), nameof(ReferralType.USI), nameof(ReferralType.Other),
        ErrorMessage = "Please select an option")]
    public ReferralType Referral { get; set; } = ReferralType.Unknown;

    public string? ReferralDescribe { get; set; }
}