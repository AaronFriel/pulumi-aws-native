// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.CodeCommit.Outputs
{

    [OutputType]
    public sealed class RepositoryS3
    {
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-codecommit-repository-s3.html#cfn-codecommit-repository-s3-bucket
        /// </summary>
        public readonly string Bucket;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-codecommit-repository-s3.html#cfn-codecommit-repository-s3-key
        /// </summary>
        public readonly string Key;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-codecommit-repository-s3.html#cfn-codecommit-repository-s3-objectversion
        /// </summary>
        public readonly string? ObjectVersion;

        [OutputConstructor]
        private RepositoryS3(
            string Bucket,

            string Key,

            string? ObjectVersion)
        {
            this.Bucket = Bucket;
            this.Key = Key;
            this.ObjectVersion = ObjectVersion;
        }
    }
}
