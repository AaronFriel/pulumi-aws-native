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
    public sealed class BucketAbortIncompleteMultipartUpload
    {
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-abortincompletemultipartupload.html#cfn-s3-bucket-abortincompletemultipartupload-daysafterinitiation
        /// </summary>
        public readonly int DaysAfterInitiation;

        [OutputConstructor]
        private BucketAbortIncompleteMultipartUpload(int DaysAfterInitiation)
        {
            this.DaysAfterInitiation = DaysAfterInitiation;
        }
    }
}
