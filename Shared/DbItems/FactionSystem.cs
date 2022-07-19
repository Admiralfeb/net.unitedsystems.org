using System.ComponentModel.DataAnnotations;

namespace UnitedSystemsCooperativeWebsite.Shared.DbItems;

public class FactionSystem : DbItem
{
    [Required] public string Name { get; set; }
    public bool IsControlled { get; set; } = false;
}