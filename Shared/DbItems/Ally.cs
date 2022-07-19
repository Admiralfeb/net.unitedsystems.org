using System.ComponentModel.DataAnnotations;

namespace UnitedSystemsCooperativeWebsite.Shared.DbItems;

public class Ally : DbItem
{
    [Required] public string Name { get; set; }
}