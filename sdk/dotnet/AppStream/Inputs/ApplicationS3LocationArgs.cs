// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.AppStream.Inputs
{

    public sealed class ApplicationS3LocationArgs : Pulumi.ResourceArgs
    {
        [Input("s3Bucket", required: true)]
        public Input<string> S3Bucket { get; set; } = null!;

        [Input("s3Key", required: true)]
        public Input<string> S3Key { get; set; } = null!;

        public ApplicationS3LocationArgs()
        {
        }
    }
}
