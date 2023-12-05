using ErrorOr;

namespace BuberBreakfast.ServiceErrors;

public static class Errors
{
    public static class Breakfast
    {
        public static Error InvalidDescription
            => Error.Validation(
                code: "Breakfast.InvalidDescription",
                description: $"Breakfast Description length must be between {Models.Breakfast.MinDescriptionLength}-{Models.Breakfast.MaxDescriptionLength} characters.");

        public static Error InvalidName
            => Error.Validation(
                code: "Breakfast.InvalidName",
                description: $"Breakfast Name length must be between {Models.Breakfast.MinNameLength}-{Models.Breakfast.MaxNameLength} characters.");

        public static Error NotFound
            => Error.NotFound(
                code: "Breakfast.NotFound",
                description: "Breakfast not found");
    }
}