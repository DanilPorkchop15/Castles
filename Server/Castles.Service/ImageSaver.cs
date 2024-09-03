using System.Text;
using Minio;
using Minio.DataModel.Args;

namespace Castles.Service;

public class FileStorage(ILogger<FileStorage> logger, IMinioClient minio) {
    public async Task Upload(Byte[] file, String name, Int64 userId) {
        var bucketName = $"userbucket{userId}";
        var beArgs = new BucketExistsArgs()
            .WithBucket(bucketName);
        var found = await minio.BucketExistsAsync(beArgs).ConfigureAwait(false);
        if (!found) {
            var mbArgs = new MakeBucketArgs()
                .WithBucket(bucketName);
            await minio.MakeBucketAsync(mbArgs).ConfigureAwait(false);
        }
        // Upload a file to bucket.
        var putObjectArgs = new PutObjectArgs()
            .WithBucket(bucketName)
            .WithObject(new String(Encoding.UTF8.GetString(file))) // todo: надо оптимизировать, а то лажа полная
            .WithFileName(name)
            .WithContentType("image");
        _ = await minio.PutObjectAsync(putObjectArgs).ConfigureAwait(false);
        logger.LogInformation("Successfully uploaded " + name);
    }
}
