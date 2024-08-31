namespace Castles.Domain.Entities.Image;

public record class Image(
    Int32 Id,
    // examples:
    //  Folder = "/" - root, image will be shown on main screen;
    //  Folder = "/bebra/" - on main screen will be shown folder 'bebra' which contains the file.
    //'/' in the end is required.
    String Folder,
    String Name,
    ImageCategory Category
) {
    public String FullName => Folder + Name;
};

