// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.MediaPackage.Inputs
{

    public sealed class PackagingGroupAuthorizationArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The Amazon Resource Name (ARN) for the secret in AWS Secrets Manager that is used for CDN authorization.
        /// </summary>
        [Input("cdnIdentifierSecret", required: true)]
        public Input<string> CdnIdentifierSecret { get; set; } = null!;

        /// <summary>
        /// The Amazon Resource Name (ARN) for the IAM role that allows MediaPackage to communicate with AWS Secrets Manager.
        /// </summary>
        [Input("secretsRoleArn", required: true)]
        public Input<string> SecretsRoleArn { get; set; } = null!;

        public PackagingGroupAuthorizationArgs()
        {
        }
    }
}
