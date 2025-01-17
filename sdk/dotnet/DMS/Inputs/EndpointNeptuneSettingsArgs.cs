// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.DMS.Inputs
{

    public sealed class EndpointNeptuneSettingsArgs : Pulumi.ResourceArgs
    {
        [Input("errorRetryDuration")]
        public Input<int>? ErrorRetryDuration { get; set; }

        [Input("iamAuthEnabled")]
        public Input<bool>? IamAuthEnabled { get; set; }

        [Input("maxFileSize")]
        public Input<int>? MaxFileSize { get; set; }

        [Input("maxRetryCount")]
        public Input<int>? MaxRetryCount { get; set; }

        [Input("s3BucketFolder")]
        public Input<string>? S3BucketFolder { get; set; }

        [Input("s3BucketName")]
        public Input<string>? S3BucketName { get; set; }

        [Input("serviceAccessRoleArn")]
        public Input<string>? ServiceAccessRoleArn { get; set; }

        public EndpointNeptuneSettingsArgs()
        {
        }
    }
}
