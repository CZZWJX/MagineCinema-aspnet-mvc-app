/*namespace MagineCinema.Data.Enums
{
    public enum Experiences
    {
        Atmos = 1,
        Beanie,
        FamilySessions,
        Flexound,
        IMAX,
        Indulge,
        Infinity,
        Junior,
        Plushy,
        Prestige,
        Onyx
    }
}
*/

// Custom attribute to store image and description
using System;

[AttributeUsage(AttributeTargets.Field, Inherited = false, AllowMultiple = false)]
sealed class ExperiencesEnumInfoAttribute : Attribute
{
    public string ImagePath { get; }
    public string Description { get; }

    public ExperiencesEnumInfoAttribute(string imagePath, string description)
    {
        ImagePath = imagePath;
        Description = description;
    }
}

// Enum with associated attributes
enum Experiences
{
    [ExperiencesEnumInfo("../../wwwroot/images/actors/hugh-jackman.jpg", "This is IMAX")]
    IMAX = 1
}