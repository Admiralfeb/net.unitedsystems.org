using System.ComponentModel.DataAnnotations;

namespace UnitedSystemsCooperativeWebsite.Shared.JoinRequest;

public interface IJoinRequestReferral
{
    [Required]
    [Range(typeof(ReferralType), nameof(ReferralType.USI), nameof(ReferralType.Other),
        ErrorMessage = "Please select an option")]
    public ReferralType Referral { get; set; }

    public string? ReferralDescribe { get; set; }
}