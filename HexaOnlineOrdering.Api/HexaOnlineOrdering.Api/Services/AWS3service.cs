using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Amazon.S3;
using Amazon.S3.Model;
using Amazon.S3.Transfer;
using HexaOnlineOrdering.Api.Options;
using HexaOnlineOrdering.Api.Services.Interfaces;
using HexaOnlineOrdering.Models.AttachmentFile;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Options;

namespace HexaOnlineOrdering.Api.Services
{
    public class AWS3service : IAWS3service
    {
        #region field
        private readonly AWS3setting _aws3Option;
        private string S3_SECRET_KEY;
        private string S3_ACCESS_KEY;
        private string S3_HOST_ENDPOINT;
        private string S3_BUCKET_NAME;
        private string S3_AWS_Region;
        private string S3_BASE_URL;
        #endregion

        private IAmazonS3 s3Client;
        public AWS3service(IOptions<AWS3setting> aws3Option)
        {
            _aws3Option = aws3Option != null ? aws3Option.Value : throw new ArgumentNullException(nameof(aws3Option));

            S3_SECRET_KEY = _aws3Option.SecretKey;
            S3_ACCESS_KEY = _aws3Option.Accesskey;
            S3_HOST_ENDPOINT = _aws3Option.HostEndPoint;
            S3_BUCKET_NAME = _aws3Option.BucketName;
            S3_AWS_Region = _aws3Option.Region;
            S3_BASE_URL = _aws3Option.BaseUrl;

            AmazonS3Config ClientConfig = new AmazonS3Config();
            ClientConfig.ServiceURL = S3_HOST_ENDPOINT;
            s3Client = new AmazonS3Client(S3_ACCESS_KEY, S3_SECRET_KEY, ClientConfig);
        }
        public List<string> GetFileListFromSpacesBackupStorage()
        {
            ListObjectsResponse ObjectList = s3Client.ListObjectsAsync(S3_BUCKET_NAME).Result;
            List<string> FileList = ObjectList.S3Objects.Select(c => c.Key).ToList();
            return FileList;
        }

        public async Task<long> GetFileSizeFromSpaceAsync(string filename)
        {
            GetObjectResponse objectResponse = await s3Client.GetObjectAsync(S3_BUCKET_NAME, filename);
            long contentLength = objectResponse.ContentLength;
            return contentLength;
        }

        public async Task<List<FileNameObjectModel>> UploadFileToDOSpaceAsync(List<IFormFile> files, string subDir = "")
        {
            List<FileNameObjectModel> resultNames = new List<FileNameObjectModel>();
            TransferUtility fileTransferUtility = new TransferUtility(s3Client);
            try
            {
                List<Task> uploadFIiles = new List<Task>();
                foreach (IFormFile file in files)
                {
                    if (file.Length > 0)
                    {
                        string name = Guid.NewGuid() + Path.GetExtension(file.FileName).ToLowerInvariant();
                        string filePath = !string.IsNullOrEmpty(subDir) ? subDir + "/" + name : name;
                        TransferUtilityUploadRequest fileTransferUtilityRequest = new TransferUtilityUploadRequest
                        {
                            InputStream = file.OpenReadStream(),
                            BucketName = S3_BUCKET_NAME,
                            PartSize = 6291456, // 6 MB.  
                            Key = filePath,
                            CannedACL = S3CannedACL.PublicRead
                        };
                        uploadFIiles.Add(fileTransferUtility.UploadAsync(fileTransferUtilityRequest));
                        resultNames.Add(new FileNameObjectModel(filePath, file.FileName ));
                        fileTransferUtility.Dispose();
                    }
                }

                Task.WaitAll(uploadFIiles.ToArray());

                Console.WriteLine("SUCCESS");
                return resultNames;
            }

            catch (AmazonS3Exception amazonS3Exception)
            {
                if (amazonS3Exception.ErrorCode != null &&
                    (amazonS3Exception.ErrorCode.Equals("InvalidAccessKeyId")
                    ||
                    amazonS3Exception.ErrorCode.Equals("InvalidSecurity")))
                {
                    Console.WriteLine("Check the provided AWS Credentials.");
                }
                else
                {
                    Console.WriteLine("Error occurred: " + amazonS3Exception.Message);
                }

            }
            return resultNames;
        }

        public async Task<bool> RemoveFileFromDOSpaceAsync(string fileName)
        {
            var deleteObjectRequest = new DeleteObjectRequest { BucketName = S3_BUCKET_NAME, Key = fileName };
            try
            {
                await s3Client.DeleteObjectAsync(deleteObjectRequest);
                return true;
            }
            catch (AmazonS3Exception amazonS3Exception)
            {
                if (amazonS3Exception.ErrorCode != null &&
                    (amazonS3Exception.ErrorCode.Equals("InvalidAccessKeyId")
                    ||
                    amazonS3Exception.ErrorCode.Equals("InvalidSecurity")))
                {
                    Console.WriteLine("Check the provided AWS Credentials.");
                }
                else
                {
                    Console.WriteLine("Error occurred: " + amazonS3Exception.Message);
                }
                return false;
            }
        }

        public string GenerateAwsFileUrl(string key, bool useRegion = true)
        {
            /* 
             * URL patterns: Virtual hosted style and path style
             * Virtual hosted style
             * 1. http://[bucketName].[regionName].amazonaws.com/[key]
             * 2. https://[bucketName].s3.amazonaws.com/[key]
             * 
             * Path style: DEPRECATED
             * 3. http://s3.[regionName].amazonaws.com/[bucketName]/[key]
             */
            string bucketName = S3_BUCKET_NAME;
            string publicUrl = string.Empty;

            if (useRegion)
            {
                publicUrl = $"https://{bucketName}.{S3_AWS_Region}.{S3_BASE_URL}/{key}";
            }
            else
            {
                publicUrl = $"https://{bucketName}.{S3_BASE_URL}/{key}";
            }

            return publicUrl;

        }
        public string GenerateAwsRegularFileUrl(string path, bool useRegion = true)
        {
            string bucketName = S3_BUCKET_NAME;
            string publicUrl = string.Empty;
            if (!string.IsNullOrEmpty(path))
            {
                path = path[0] != '/' ? string.Format("/{0}", path) : path;
                if (useRegion)
                {
                    publicUrl = $"https://{bucketName}.{S3_AWS_Region}.{S3_BASE_URL}{path}";
                }
                else
                {
                    publicUrl = $"https://{bucketName}.{S3_BASE_URL}{path}";
                }
            }
            return publicUrl;
        }
    }
}
