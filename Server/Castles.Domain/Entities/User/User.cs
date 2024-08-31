namespace Castles.Domain.Entities.User;

public record class User(
    Int32 Id,
    String Username,
    String Email,
    String Password,
    List<Image.Image> UserImages,
    String Status = "",
    Gender Gender = Gender.Unset,
    Role Role = Role.User
);

