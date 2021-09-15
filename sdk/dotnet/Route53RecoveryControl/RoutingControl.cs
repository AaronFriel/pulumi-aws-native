// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.Route53RecoveryControl
{
    /// <summary>
    /// AWS Route53 Recovery Control Routing Control resource schema .
    /// </summary>
    [AwsNativeResourceType("aws-native:route53recoverycontrol:RoutingControl")]
    public partial class RoutingControl : Pulumi.CustomResource
    {
        /// <summary>
        /// Arn associated with Control Panel
        /// </summary>
        [Output("clusterArn")]
        public Output<string?> ClusterArn { get; private set; } = null!;

        /// <summary>
        /// The Amazon Resource Name (ARN) of the control panel.
        /// </summary>
        [Output("controlPanelArn")]
        public Output<string?> ControlPanelArn { get; private set; } = null!;

        /// <summary>
        /// The name of the routing control. You can use any non-white space character in the name.
        /// </summary>
        [Output("name")]
        public Output<string> Name { get; private set; } = null!;

        /// <summary>
        /// The Amazon Resource Name (ARN) of the routing control.
        /// </summary>
        [Output("routingControlArn")]
        public Output<string> RoutingControlArn { get; private set; } = null!;

        /// <summary>
        /// The deployment status of the routing control. Status can be one of the following: PENDING, DEPLOYED, PENDING_DELETION.
        /// </summary>
        [Output("status")]
        public Output<string> Status { get; private set; } = null!;


        /// <summary>
        /// Create a RoutingControl resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public RoutingControl(string name, RoutingControlArgs args, CustomResourceOptions? options = null)
            : base("aws-native:route53recoverycontrol:RoutingControl", name, args ?? new RoutingControlArgs(), MakeResourceOptions(options, ""))
        {
        }

        private RoutingControl(string name, Input<string> id, CustomResourceOptions? options = null)
            : base("aws-native:route53recoverycontrol:RoutingControl", name, null, MakeResourceOptions(options, id))
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
        /// Get an existing RoutingControl resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static RoutingControl Get(string name, Input<string> id, CustomResourceOptions? options = null)
        {
            return new RoutingControl(name, id, options);
        }
    }

    public sealed class RoutingControlArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Arn associated with Control Panel
        /// </summary>
        [Input("clusterArn")]
        public Input<string>? ClusterArn { get; set; }

        /// <summary>
        /// The Amazon Resource Name (ARN) of the control panel.
        /// </summary>
        [Input("controlPanelArn")]
        public Input<string>? ControlPanelArn { get; set; }

        /// <summary>
        /// The name of the routing control. You can use any non-white space character in the name.
        /// </summary>
        [Input("name", required: true)]
        public Input<string> Name { get; set; } = null!;

        public RoutingControlArgs()
        {
        }
    }
}
