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
    public sealed class BucketEncryptionConfiguration
    {
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-encryptionconfiguration.html#cfn-s3-bucket-encryptionconfiguration-replicakmskeyid
        /// </summary>
        public readonly string ReplicaKmsKeyID;

        [OutputConstructor]
        private BucketEncryptionConfiguration(string ReplicaKmsKeyID)
        {
            this.ReplicaKmsKeyID = ReplicaKmsKeyID;
        }
    }
}
