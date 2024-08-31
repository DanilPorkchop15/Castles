namespace Castles.Domain.Entities.User;

public enum Gender {
    Male,
    Female,
    Unset,
}

public enum Role {
    User,
    Admin,
    Subcription,
}

public record class ImageCategory(Int32 Id, String Name);

public record class User(
    Int32 Id,
    String Username,
    String Email,
    String Password,
    List<Image> UserImages,
    String Status = "",
    Gender Gender = Gender.Unset,
    Role Role = Role.User
);

public record class Image(
    Int32 Id,
    // examples: 
    //  Foler = "/" - root, image will be shown on main screen; 
    //  Folder = "/bebra/" - on main screen will be shown folder 'bebra' which contains the file.
    //'/' in the end is required.
    String Folder,
    String Name,
    ImageCategory Category
) {
    public String FullName => Folder + Name;
};

