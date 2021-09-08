// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.AppMesh
{
    /// <summary>
    /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appmesh-gatewayroute.html
    /// </summary>
    [AwsNativeResourceType("aws-native:appmesh:GatewayRoute")]
    public partial class GatewayRoute : Pulumi.CustomResource
    {
        [Output("arn")]
        public Output<string> Arn { get; private set; } = null!;

        [Output("gatewayRouteName")]
        public Output<string> GatewayRouteName { get; private set; } = null!;

        [Output("meshName")]
        public Output<string> MeshName { get; private set; } = null!;

        [Output("meshOwner")]
        public Output<string> MeshOwner { get; private set; } = null!;

        [Output("resourceOwner")]
        public Output<string> ResourceOwner { get; private set; } = null!;

        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appmesh-gatewayroute.html#cfn-appmesh-gatewayroute-spec
        /// </summary>
        [Output("spec")]
        public Output<Outputs.GatewayRouteGatewayRouteSpec> Spec { get; private set; } = null!;

        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appmesh-gatewayroute.html#cfn-appmesh-gatewayroute-tags
        /// </summary>
        [Output("tags")]
        public Output<ImmutableArray<Pulumi.AwsNative.Outputs.Tag>> Tags { get; private set; } = null!;

        [Output("uid")]
        public Output<string> Uid { get; private set; } = null!;

        [Output("virtualGatewayName")]
        public Output<string> VirtualGatewayName { get; private set; } = null!;


        /// <summary>
        /// Create a GatewayRoute resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public GatewayRoute(string name, GatewayRouteArgs args, CustomResourceOptions? options = null)
            : base("aws-native:appmesh:GatewayRoute", name, args ?? new GatewayRouteArgs(), MakeResourceOptions(options, ""))
        {
        }

        private GatewayRoute(string name, Input<string> id, CustomResourceOptions? options = null)
            : base("aws-native:appmesh:GatewayRoute", name, null, MakeResourceOptions(options, id))
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
        /// Get an existing GatewayRoute resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static GatewayRoute Get(string name, Input<string> id, CustomResourceOptions? options = null)
        {
            return new GatewayRoute(name, id, options);
        }
    }

    public sealed class GatewayRouteArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appmesh-gatewayroute.html#cfn-appmesh-gatewayroute-gatewayroutename
        /// </summary>
        [Input("gatewayRouteName")]
        public Input<string>? GatewayRouteName { get; set; }

        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appmesh-gatewayroute.html#cfn-appmesh-gatewayroute-meshname
        /// </summary>
        [Input("meshName", required: true)]
        public Input<string> MeshName { get; set; } = null!;

        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appmesh-gatewayroute.html#cfn-appmesh-gatewayroute-meshowner
        /// </summary>
        [Input("meshOwner")]
        public Input<string>? MeshOwner { get; set; }

        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appmesh-gatewayroute.html#cfn-appmesh-gatewayroute-spec
        /// </summary>
        [Input("spec", required: true)]
        public Input<Inputs.GatewayRouteGatewayRouteSpecArgs> Spec { get; set; } = null!;

        [Input("tags")]
        private InputList<Pulumi.AwsNative.Inputs.TagArgs>? _tags;

        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appmesh-gatewayroute.html#cfn-appmesh-gatewayroute-tags
        /// </summary>
        public InputList<Pulumi.AwsNative.Inputs.TagArgs> Tags
        {
            get => _tags ?? (_tags = new InputList<Pulumi.AwsNative.Inputs.TagArgs>());
            set => _tags = value;
        }

        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appmesh-gatewayroute.html#cfn-appmesh-gatewayroute-virtualgatewayname
        /// </summary>
        [Input("virtualGatewayName", required: true)]
        public Input<string> VirtualGatewayName { get; set; } = null!;

        public GatewayRouteArgs()
        {
        }
    }
}