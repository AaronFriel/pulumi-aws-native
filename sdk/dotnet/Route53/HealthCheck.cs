// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.Route53
{
    /// <summary>
    /// Resource schema for AWS::Route53::HealthCheck.
    /// </summary>
    [AwsNativeResourceType("aws-native:route53:HealthCheck")]
    public partial class HealthCheck : Pulumi.CustomResource
    {
        /// <summary>
        /// A complex type that contains information about the health check.
        /// </summary>
        [Output("healthCheckConfig")]
        public Output<object> HealthCheckConfig { get; private set; } = null!;

        [Output("healthCheckId")]
        public Output<string> HealthCheckId { get; private set; } = null!;

        /// <summary>
        /// An array of key-value pairs to apply to this resource.
        /// </summary>
        [Output("healthCheckTags")]
        public Output<ImmutableArray<Outputs.HealthCheckHealthCheckTag>> HealthCheckTags { get; private set; } = null!;


        /// <summary>
        /// Create a HealthCheck resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public HealthCheck(string name, HealthCheckArgs args, CustomResourceOptions? options = null)
            : base("aws-native:route53:HealthCheck", name, args ?? new HealthCheckArgs(), MakeResourceOptions(options, ""))
        {
        }

        private HealthCheck(string name, Input<string> id, CustomResourceOptions? options = null)
            : base("aws-native:route53:HealthCheck", name, null, MakeResourceOptions(options, id))
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
        /// Get an existing HealthCheck resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static HealthCheck Get(string name, Input<string> id, CustomResourceOptions? options = null)
        {
            return new HealthCheck(name, id, options);
        }
    }

    public sealed class HealthCheckArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// A complex type that contains information about the health check.
        /// </summary>
        [Input("healthCheckConfig", required: true)]
        public Input<object> HealthCheckConfig { get; set; } = null!;

        [Input("healthCheckTags")]
        private InputList<Inputs.HealthCheckHealthCheckTagArgs>? _healthCheckTags;

        /// <summary>
        /// An array of key-value pairs to apply to this resource.
        /// </summary>
        public InputList<Inputs.HealthCheckHealthCheckTagArgs> HealthCheckTags
        {
            get => _healthCheckTags ?? (_healthCheckTags = new InputList<Inputs.HealthCheckHealthCheckTagArgs>());
            set => _healthCheckTags = value;
        }

        public HealthCheckArgs()
        {
        }
    }
}
