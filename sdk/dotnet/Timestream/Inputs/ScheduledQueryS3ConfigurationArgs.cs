// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.Timestream.Inputs
{

    /// <summary>
    /// Details on S3 location for error reports that result from running a query.
    /// </summary>
    public sealed class ScheduledQueryS3ConfigurationArgs : Pulumi.ResourceArgs
    {
        [Input("bucketName", required: true)]
        public Input<string> BucketName { get; set; } = null!;

        [Input("encryptionOption")]
        public Input<Pulumi.AwsNative.Timestream.ScheduledQueryEncryptionOption>? EncryptionOption { get; set; }

        [Input("objectKeyPrefix")]
        public Input<string>? ObjectKeyPrefix { get; set; }

        public ScheduledQueryS3ConfigurationArgs()
        {
        }
    }
}
