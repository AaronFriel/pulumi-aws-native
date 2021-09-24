// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.S3.Inputs
{

    public sealed class BucketDestinationArgs : Pulumi.ResourceArgs
    {
        [Input("bucketAccountId")]
        public Input<string>? BucketAccountId { get; set; }

        [Input("bucketArn", required: true)]
        public Input<string> BucketArn { get; set; } = null!;

        [Input("format", required: true)]
        public Input<string> Format { get; set; } = null!;

        [Input("prefix")]
        public Input<string>? Prefix { get; set; }

        public BucketDestinationArgs()
        {
        }
    }
}