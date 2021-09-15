// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.S3Outposts.Inputs
{

    /// <summary>
    /// Specifies the days since the initiation of an incomplete multipart upload that Amazon S3Outposts will wait before permanently removing all parts of the upload.
    /// </summary>
    public sealed class BucketAbortIncompleteMultipartUploadArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Specifies the number of days after which Amazon S3Outposts aborts an incomplete multipart upload.
        /// </summary>
        [Input("daysAfterInitiation", required: true)]
        public Input<int> DaysAfterInitiation { get; set; } = null!;

        public BucketAbortIncompleteMultipartUploadArgs()
        {
        }
    }
}
