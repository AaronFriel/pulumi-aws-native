// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.CodeStarConnections.Outputs
{

    [OutputType]
    public sealed class ConnectionProperties
    {
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-codestarconnections-connection.html#cfn-codestarconnections-connection-connectionname
        /// </summary>
        public readonly string ConnectionName;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-codestarconnections-connection.html#cfn-codestarconnections-connection-hostarn
        /// </summary>
        public readonly string? HostArn;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-codestarconnections-connection.html#cfn-codestarconnections-connection-providertype
        /// </summary>
        public readonly string? ProviderType;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-codestarconnections-connection.html#cfn-codestarconnections-connection-tags
        /// </summary>
        public readonly ImmutableArray<Pulumi.AwsNative.Outputs.Tag> Tags;

        [OutputConstructor]
        private ConnectionProperties(
            string ConnectionName,

            string? HostArn,

            string? ProviderType,

            ImmutableArray<Pulumi.AwsNative.Outputs.Tag> Tags)
        {
            this.ConnectionName = ConnectionName;
            this.HostArn = HostArn;
            this.ProviderType = ProviderType;
            this.Tags = Tags;
        }
    }
}
