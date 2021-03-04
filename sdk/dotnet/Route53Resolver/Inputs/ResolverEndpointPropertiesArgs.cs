// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.Route53Resolver.Inputs
{

    /// <summary>
    /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-route53resolver-resolverendpoint.html
    /// </summary>
    public sealed class ResolverEndpointPropertiesArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-route53resolver-resolverendpoint.html#cfn-route53resolver-resolverendpoint-direction
        /// </summary>
        [Input("Direction", required: true)]
        public Input<string> Direction { get; set; } = null!;

        [Input("IpAddresses", required: true)]
        private InputList<Inputs.ResolverEndpointIpAddressRequestArgs>? _IpAddresses;

        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-route53resolver-resolverendpoint.html#cfn-route53resolver-resolverendpoint-ipaddresses
        /// </summary>
        public InputList<Inputs.ResolverEndpointIpAddressRequestArgs> IpAddresses
        {
            get => _IpAddresses ?? (_IpAddresses = new InputList<Inputs.ResolverEndpointIpAddressRequestArgs>());
            set => _IpAddresses = value;
        }

        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-route53resolver-resolverendpoint.html#cfn-route53resolver-resolverendpoint-name
        /// </summary>
        [Input("Name")]
        public Input<string>? Name { get; set; }

        [Input("SecurityGroupIds", required: true)]
        private InputList<string>? _SecurityGroupIds;

        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-route53resolver-resolverendpoint.html#cfn-route53resolver-resolverendpoint-securitygroupids
        /// </summary>
        public InputList<string> SecurityGroupIds
        {
            get => _SecurityGroupIds ?? (_SecurityGroupIds = new InputList<string>());
            set => _SecurityGroupIds = value;
        }

        [Input("Tags")]
        private InputList<Pulumi.AwsNative.Inputs.TagArgs>? _Tags;

        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-route53resolver-resolverendpoint.html#cfn-route53resolver-resolverendpoint-tags
        /// </summary>
        public InputList<Pulumi.AwsNative.Inputs.TagArgs> Tags
        {
            get => _Tags ?? (_Tags = new InputList<Pulumi.AwsNative.Inputs.TagArgs>());
            set => _Tags = value;
        }

        public ResolverEndpointPropertiesArgs()
        {
        }
    }
}
