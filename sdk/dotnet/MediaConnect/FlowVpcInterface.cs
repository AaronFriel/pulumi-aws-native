// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.MediaConnect
{
    /// <summary>
    /// Resource schema for AWS::MediaConnect::FlowVpcInterface
    /// </summary>
    [AwsNativeResourceType("aws-native:mediaconnect:FlowVpcInterface")]
    public partial class FlowVpcInterface : Pulumi.CustomResource
    {
        /// <summary>
        /// The Amazon Resource Name (ARN), a unique identifier for any AWS resource, of the flow.
        /// </summary>
        [Output("flowArn")]
        public Output<string> FlowArn { get; private set; } = null!;

        /// <summary>
        /// Immutable and has to be a unique against other VpcInterfaces in this Flow.
        /// </summary>
        [Output("name")]
        public Output<string> Name { get; private set; } = null!;

        /// <summary>
        /// IDs of the network interfaces created in customer's account by MediaConnect.
        /// </summary>
        [Output("networkInterfaceIds")]
        public Output<ImmutableArray<string>> NetworkInterfaceIds { get; private set; } = null!;

        /// <summary>
        /// Role Arn MediaConnect can assumes to create ENIs in customer's account.
        /// </summary>
        [Output("roleArn")]
        public Output<string> RoleArn { get; private set; } = null!;

        /// <summary>
        /// Security Group IDs to be used on ENI.
        /// </summary>
        [Output("securityGroupIds")]
        public Output<ImmutableArray<string>> SecurityGroupIds { get; private set; } = null!;

        /// <summary>
        /// Subnet must be in the AZ of the Flow
        /// </summary>
        [Output("subnetId")]
        public Output<string> SubnetId { get; private set; } = null!;


        /// <summary>
        /// Create a FlowVpcInterface resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public FlowVpcInterface(string name, FlowVpcInterfaceArgs args, CustomResourceOptions? options = null)
            : base("aws-native:mediaconnect:FlowVpcInterface", name, args ?? new FlowVpcInterfaceArgs(), MakeResourceOptions(options, ""))
        {
        }

        private FlowVpcInterface(string name, Input<string> id, CustomResourceOptions? options = null)
            : base("aws-native:mediaconnect:FlowVpcInterface", name, null, MakeResourceOptions(options, id))
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
        /// Get an existing FlowVpcInterface resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static FlowVpcInterface Get(string name, Input<string> id, CustomResourceOptions? options = null)
        {
            return new FlowVpcInterface(name, id, options);
        }
    }

    public sealed class FlowVpcInterfaceArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The Amazon Resource Name (ARN), a unique identifier for any AWS resource, of the flow.
        /// </summary>
        [Input("flowArn", required: true)]
        public Input<string> FlowArn { get; set; } = null!;

        /// <summary>
        /// Immutable and has to be a unique against other VpcInterfaces in this Flow.
        /// </summary>
        [Input("name", required: true)]
        public Input<string> Name { get; set; } = null!;

        /// <summary>
        /// Role Arn MediaConnect can assumes to create ENIs in customer's account.
        /// </summary>
        [Input("roleArn", required: true)]
        public Input<string> RoleArn { get; set; } = null!;

        [Input("securityGroupIds", required: true)]
        private InputList<string>? _securityGroupIds;

        /// <summary>
        /// Security Group IDs to be used on ENI.
        /// </summary>
        public InputList<string> SecurityGroupIds
        {
            get => _securityGroupIds ?? (_securityGroupIds = new InputList<string>());
            set => _securityGroupIds = value;
        }

        /// <summary>
        /// Subnet must be in the AZ of the Flow
        /// </summary>
        [Input("subnetId", required: true)]
        public Input<string> SubnetId { get; set; } = null!;

        public FlowVpcInterfaceArgs()
        {
        }
    }
}
