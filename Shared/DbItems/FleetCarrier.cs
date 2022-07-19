using System.ComponentModel.DataAnnotations;
using UnitedSystemsCooperativeWebsite.Shared.FormValidators;

namespace UnitedSystemsCooperativeWebsite.Shared.DbItems;

public class FleetCarrier : DbItem
{
    [Required] [FleetCarrierValidator] public override string Id { get; set; }

    [Required] public string Name { get; set; }

    [Required] public string Owner { get; set; }

    public string OwnerId { get; set; }
    public string Purpose { get; set; } = string.Empty;
    public string Link { get; set; } = string.Empty;
}