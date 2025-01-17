// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.ElasticLoadBalancingV2
{
    /// <summary>
    /// Resource Type definition for AWS::ElasticLoadBalancingV2::TargetGroup
    /// </summary>
    [Obsolete(@"TargetGroup is not yet supported by AWS Native, so its creation will currently fail. Please use the classic AWS provider, if possible.")]
    [AwsNativeResourceType("aws-native:elasticloadbalancingv2:TargetGroup")]
    public partial class TargetGroup : Pulumi.CustomResource
    {
        [Output("healthCheckEnabled")]
        public Output<bool?> HealthCheckEnabled { get; private set; } = null!;

        [Output("healthCheckIntervalSeconds")]
        public Output<int?> HealthCheckIntervalSeconds { get; private set; } = null!;

        [Output("healthCheckPath")]
        public Output<string?> HealthCheckPath { get; private set; } = null!;

        [Output("healthCheckPort")]
        public Output<string?> HealthCheckPort { get; private set; } = null!;

        [Output("healthCheckProtocol")]
        public Output<string?> HealthCheckProtocol { get; private set; } = null!;

        [Output("healthCheckTimeoutSeconds")]
        public Output<int?> HealthCheckTimeoutSeconds { get; private set; } = null!;

        [Output("healthyThresholdCount")]
        public Output<int?> HealthyThresholdCount { get; private set; } = null!;

        [Output("ipAddressType")]
        public Output<string?> IpAddressType { get; private set; } = null!;

        [Output("loadBalancerArns")]
        public Output<ImmutableArray<string>> LoadBalancerArns { get; private set; } = null!;

        [Output("matcher")]
        public Output<Outputs.TargetGroupMatcher?> Matcher { get; private set; } = null!;

        [Output("name")]
        public Output<string?> Name { get; private set; } = null!;

        [Output("port")]
        public Output<int?> Port { get; private set; } = null!;

        [Output("protocol")]
        public Output<string?> Protocol { get; private set; } = null!;

        [Output("protocolVersion")]
        public Output<string?> ProtocolVersion { get; private set; } = null!;

        [Output("tags")]
        public Output<ImmutableArray<Outputs.TargetGroupTag>> Tags { get; private set; } = null!;

        [Output("targetGroupAttributes")]
        public Output<ImmutableArray<Outputs.TargetGroupAttribute>> TargetGroupAttributes { get; private set; } = null!;

        [Output("targetGroupFullName")]
        public Output<string> TargetGroupFullName { get; private set; } = null!;

        [Output("targetGroupName")]
        public Output<string> TargetGroupName { get; private set; } = null!;

        [Output("targetType")]
        public Output<string?> TargetType { get; private set; } = null!;

        [Output("targets")]
        public Output<ImmutableArray<Outputs.TargetGroupTargetDescription>> Targets { get; private set; } = null!;

        [Output("unhealthyThresholdCount")]
        public Output<int?> UnhealthyThresholdCount { get; private set; } = null!;

        [Output("vpcId")]
        public Output<string?> VpcId { get; private set; } = null!;


        /// <summary>
        /// Create a TargetGroup resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public TargetGroup(string name, TargetGroupArgs? args = null, CustomResourceOptions? options = null)
            : base("aws-native:elasticloadbalancingv2:TargetGroup", name, args ?? new TargetGroupArgs(), MakeResourceOptions(options, ""))
        {
        }

        private TargetGroup(string name, Input<string> id, CustomResourceOptions? options = null)
            : base("aws-native:elasticloadbalancingv2:TargetGroup", name, null, MakeResourceOptions(options, id))
        {
        }

        private static CustomResourceOptions MakeResourceOptions(CustomResourceOptions? options, Input<string>? id)
        {
            var defaultOptions = new CustomResourceOptions
            {
                Version = Utilities.Version,
            };
            var merged = CustomResourceOptions.Merge(defaultOptions, options);
            // Override the ID if one was specified for consistency with other language SDKs.
            merged.Id = id ?? merged.Id;
            return merged;
        }
        /// <summary>
        /// Get an existing TargetGroup resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static TargetGroup Get(string name, Input<string> id, CustomResourceOptions? options = null)
        {
            return new TargetGroup(name, id, options);
        }
    }

    public sealed class TargetGroupArgs : Pulumi.ResourceArgs
    {
        [Input("healthCheckEnabled")]
        public Input<bool>? HealthCheckEnabled { get; set; }

        [Input("healthCheckIntervalSeconds")]
        public Input<int>? HealthCheckIntervalSeconds { get; set; }

        [Input("healthCheckPath")]
        public Input<string>? HealthCheckPath { get; set; }

        [Input("healthCheckPort")]
        public Input<string>? HealthCheckPort { get; set; }

        [Input("healthCheckProtocol")]
        public Input<string>? HealthCheckProtocol { get; set; }

        [Input("healthCheckTimeoutSeconds")]
        public Input<int>? HealthCheckTimeoutSeconds { get; set; }

        [Input("healthyThresholdCount")]
        public Input<int>? HealthyThresholdCount { get; set; }

        [Input("ipAddressType")]
        public Input<string>? IpAddressType { get; set; }

        [Input("matcher")]
        public Input<Inputs.TargetGroupMatcherArgs>? Matcher { get; set; }

        [Input("name")]
        public Input<string>? Name { get; set; }

        [Input("port")]
        public Input<int>? Port { get; set; }

        [Input("protocol")]
        public Input<string>? Protocol { get; set; }

        [Input("protocolVersion")]
        public Input<string>? ProtocolVersion { get; set; }

        [Input("tags")]
        private InputList<Inputs.TargetGroupTagArgs>? _tags;
        public InputList<Inputs.TargetGroupTagArgs> Tags
        {
            get => _tags ?? (_tags = new InputList<Inputs.TargetGroupTagArgs>());
            set => _tags = value;
        }

        [Input("targetGroupAttributes")]
        private InputList<Inputs.TargetGroupAttributeArgs>? _targetGroupAttributes;
        public InputList<Inputs.TargetGroupAttributeArgs> TargetGroupAttributes
        {
            get => _targetGroupAttributes ?? (_targetGroupAttributes = new InputList<Inputs.TargetGroupAttributeArgs>());
            set => _targetGroupAttributes = value;
        }

        [Input("targetType")]
        public Input<string>? TargetType { get; set; }

        [Input("targets")]
        private InputList<Inputs.TargetGroupTargetDescriptionArgs>? _targets;
        public InputList<Inputs.TargetGroupTargetDescriptionArgs> Targets
        {
            get => _targets ?? (_targets = new InputList<Inputs.TargetGroupTargetDescriptionArgs>());
            set => _targets = value;
        }

        [Input("unhealthyThresholdCount")]
        public Input<int>? UnhealthyThresholdCount { get; set; }

        [Input("vpcId")]
        public Input<string>? VpcId { get; set; }

        public TargetGroupArgs()
        {
        }
    }
}
