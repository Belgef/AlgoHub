using AlgoHub.API.Services.Interfaces;
using Amazon;
using Amazon.S3;
using Amazon.S3.Transfer;

namespace AlgoHub.API.Services.Implementations;

public class S3StorageService : IStorageService
{
    private readonly string _bucketName;
    private readonly AmazonS3Client _awsS3Client;

    public S3StorageService(string bucketName, string accessId, string secretName, string region)
    {
        _bucketName = bucketName;
        _awsS3Client = new AmazonS3Client(accessId, secretName, RegionEndpoint.GetBySystemName(region));
    }

    public async Task SaveFile(IFormFile file, string name)
    {
        using var newMemoryStream = new MemoryStream();

        file.CopyTo(newMemoryStream);

        var uploadRequest = new TransferUtilityUploadRequest
        {
            InputStream = newMemoryStream,
            Key = name,
            BucketName = _bucketName,
            ContentType = file.ContentType,
            CannedACL = S3CannedACL.PublicRead
        };

        var fileTransferUtility = new TransferUtility(_awsS3Client);

        await fileTransferUtility.UploadAsync(uploadRequest);
    }

    public async Task UpdateFile(IFormFile newFile, string name)
    {
        throw new NotImplementedException();
    }

    public async Task DeleteFile(string name)
    {
        throw new NotImplementedException();
    }
}
