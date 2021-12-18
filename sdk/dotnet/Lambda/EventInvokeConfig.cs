// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.Lambda
{
    /// <summary>
    /// Resource Type definition for AWS::Lambda::EventInvokeConfig
    /// </summary>
    [Obsolete(@"EventInvokeConfig is not yet supported by AWS Native, so its creation will currently fail. Please use the classic AWS provider, if possible.")]
    [AwsNativeResourceType("aws-native:lambda:EventInvokeConfig")]
    public partial class EventInvokeConfig : Pulumi.CustomResource
    {
        [Output("destinationConfig")]
        public Output<Outputs.EventInvokeConfigDestinationConfig?> DestinationConfig { get; private set; } = null!;

        [Output("functionName")]
        public Output<string> FunctionName { get; private set; } = null!;

        [Output("maximumEventAgeInSeconds")]
        public Output<int?> MaximumEventAgeInSeconds { get; private set; } = null!;

        [Output("maximumRetryAttempts")]
        public Output<int?> MaximumRetryAttempts { get; private set; } = null!;

        [Output("qualifier")]
        public Output<string> Qualifier { get; private set; } = null!;


        /// <summary>
        /// Create a EventInvokeConfig resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public EventInvokeConfig(string name, EventInvokeConfigArgs args, CustomResourceOptions? options = null)
            : base("aws-native:lambda:EventInvokeConfig", name, args ?? new EventInvokeConfigArgs(), MakeResourceOptions(options, ""))
        {
        }

        private EventInvokeConfig(string name, Input<string> id, CustomResourceOptions? options = null)
            : base("aws-native:lambda:EventInvokeConfig", name, null, MakeResourceOptions(options, id))
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
        /// Get an existing EventInvokeConfig resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static EventInvokeConfig Get(string name, Input<string> id, CustomResourceOptions? options = null)
        {
            return new EventInvokeConfig(name, id, options);
        }
    }

    public sealed class EventInvokeConfigArgs : Pulumi.ResourceArgs
    {
        [Input("destinationConfig")]
        public Input<Inputs.EventInvokeConfigDestinationConfigArgs>? DestinationConfig { get; set; }

        [Input("functionName", required: true)]
        public Input<string> FunctionName { get; set; } = null!;

        [Input("maximumEventAgeInSeconds")]
        public Input<int>? MaximumEventAgeInSeconds { get; set; }

        [Input("maximumRetryAttempts")]
        public Input<int>? MaximumRetryAttempts { get; set; }

        [Input("qualifier", required: true)]
        public Input<string> Qualifier { get; set; } = null!;

        public EventInvokeConfigArgs()
        {
        }
    }
}
