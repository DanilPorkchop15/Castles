namespace Castles.Service;

public static class FormFileExtensions {
    public static async Task<Byte[]> GetBytes(this IFormFile formFile) {
        await using var memoryStream = new MemoryStream();
        await formFile.CopyToAsync(memoryStream);
        return memoryStream.ToArray();
    }
}

