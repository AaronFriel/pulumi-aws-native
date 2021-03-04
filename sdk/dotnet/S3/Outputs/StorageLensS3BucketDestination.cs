// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.S3.Outputs
{

    [OutputType]
    public sealed class StorageLensS3BucketDestination
    {
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-storagelens-s3bucketdestination.html#cfn-s3-storagelens-s3bucketdestination-accountid
        /// </summary>
        public readonly string AccountId;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-storagelens-s3bucketdestination.html#cfn-s3-storagelens-s3bucketdestination-arn
        /// </summary>
        public readonly string Arn;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-storagelens-s3bucketdestination.html#cfn-s3-storagelens-s3bucketdestination-encryption
        /// </summary>
        public readonly Outputs.StorageLensEncryption? Encryption;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-storagelens-s3bucketdestination.html#cfn-s3-storagelens-s3bucketdestination-format
        /// </summary>
        public readonly string Format;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-storagelens-s3bucketdestination.html#cfn-s3-storagelens-s3bucketdestination-outputschemaversion
        /// </summary>
        public readonly string OutputSchemaVersion;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-storagelens-s3bucketdestination.html#cfn-s3-storagelens-s3bucketdestination-prefix
        /// </summary>
        public readonly string? Prefix;

        [OutputConstructor]
        private StorageLensS3BucketDestination(
            string AccountId,

            string Arn,

            Outputs.StorageLensEncryption? Encryption,

            string Format,

            string OutputSchemaVersion,

            string? Prefix)
        {
            this.AccountId = AccountId;
            this.Arn = Arn;
            this.Encryption = Encryption;
            this.Format = Format;
            this.OutputSchemaVersion = OutputSchemaVersion;
            this.Prefix = Prefix;
        }
    }
}
