// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.AmazonMQ.Inputs
{

    /// <summary>
    /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-amazonmq-configurationassociation.html
    /// </summary>
    public sealed class ConfigurationAssociationPropertiesArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-amazonmq-configurationassociation.html#cfn-amazonmq-configurationassociation-broker
        /// </summary>
        [Input("Broker", required: true)]
        public Input<string> Broker { get; set; } = null!;

        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-amazonmq-configurationassociation.html#cfn-amazonmq-configurationassociation-configuration
        /// </summary>
        [Input("Configuration", required: true)]
        public Input<Inputs.ConfigurationAssociationConfigurationIdArgs> Configuration { get; set; } = null!;

        public ConfigurationAssociationPropertiesArgs()
        {
        }
    }
}
