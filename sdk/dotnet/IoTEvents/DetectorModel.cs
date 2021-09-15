// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.IoTEvents
{
    /// <summary>
    /// The AWS::IoTEvents::DetectorModel resource creates a detector model. You create a *detector model* (a model of your equipment or process) using *states*. For each state, you define conditional (Boolean) logic that evaluates the incoming inputs to detect significant events. When an event is detected, it can change the state or trigger custom-built or predefined actions using other AWS services. You can define additional events that trigger actions when entering or exiting a state and, optionally, when a condition is met. For more information, see [How to Use AWS IoT Events](https://docs.aws.amazon.com/iotevents/latest/developerguide/how-to-use-iotevents.html) in the *AWS IoT Events Developer Guide*.
    /// </summary>
    [AwsNativeResourceType("aws-native:iotevents:DetectorModel")]
    public partial class DetectorModel : Pulumi.CustomResource
    {
        [Output("detectorModelDefinition")]
        public Output<Outputs.DetectorModelDetectorModelDefinition> DetectorModelDefinition { get; private set; } = null!;

        /// <summary>
        /// A brief description of the detector model.
        /// </summary>
        [Output("detectorModelDescription")]
        public Output<string?> DetectorModelDescription { get; private set; } = null!;

        /// <summary>
        /// The name of the detector model.
        /// </summary>
        [Output("detectorModelName")]
        public Output<string?> DetectorModelName { get; private set; } = null!;

        /// <summary>
        /// Information about the order in which events are evaluated and how actions are executed.
        /// </summary>
        [Output("evaluationMethod")]
        public Output<string?> EvaluationMethod { get; private set; } = null!;

        /// <summary>
        /// The value used to identify a detector instance. When a device or system sends input, a new detector instance with a unique key value is created. AWS IoT Events can continue to route input to its corresponding detector instance based on this identifying information.
        /// 
        /// This parameter uses a JSON-path expression to select the attribute-value pair in the message payload that is used for identification. To route the message to the correct detector instance, the device must send a message payload that contains the same attribute-value.
        /// </summary>
        [Output("key")]
        public Output<string?> Key { get; private set; } = null!;

        /// <summary>
        /// The ARN of the role that grants permission to AWS IoT Events to perform its operations.
        /// </summary>
        [Output("roleArn")]
        public Output<string> RoleArn { get; private set; } = null!;

        /// <summary>
        /// An array of key-value pairs to apply to this resource.
        /// 
        /// For more information, see [Tag](https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-resource-tags.html).
        /// </summary>
        [Output("tags")]
        public Output<ImmutableArray<Outputs.DetectorModelTag>> Tags { get; private set; } = null!;


        /// <summary>
        /// Create a DetectorModel resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public DetectorModel(string name, DetectorModelArgs args, CustomResourceOptions? options = null)
            : base("aws-native:iotevents:DetectorModel", name, args ?? new DetectorModelArgs(), MakeResourceOptions(options, ""))
        {
        }

        private DetectorModel(string name, Input<string> id, CustomResourceOptions? options = null)
            : base("aws-native:iotevents:DetectorModel", name, null, MakeResourceOptions(options, id))
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
        /// Get an existing DetectorModel resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static DetectorModel Get(string name, Input<string> id, CustomResourceOptions? options = null)
        {
            return new DetectorModel(name, id, options);
        }
    }

    public sealed class DetectorModelArgs : Pulumi.ResourceArgs
    {
        [Input("detectorModelDefinition", required: true)]
        public Input<Inputs.DetectorModelDetectorModelDefinitionArgs> DetectorModelDefinition { get; set; } = null!;

        /// <summary>
        /// A brief description of the detector model.
        /// </summary>
        [Input("detectorModelDescription")]
        public Input<string>? DetectorModelDescription { get; set; }

        /// <summary>
        /// The name of the detector model.
        /// </summary>
        [Input("detectorModelName")]
        public Input<string>? DetectorModelName { get; set; }

        /// <summary>
        /// Information about the order in which events are evaluated and how actions are executed.
        /// </summary>
        [Input("evaluationMethod")]
        public Input<string>? EvaluationMethod { get; set; }

        /// <summary>
        /// The value used to identify a detector instance. When a device or system sends input, a new detector instance with a unique key value is created. AWS IoT Events can continue to route input to its corresponding detector instance based on this identifying information.
        /// 
        /// This parameter uses a JSON-path expression to select the attribute-value pair in the message payload that is used for identification. To route the message to the correct detector instance, the device must send a message payload that contains the same attribute-value.
        /// </summary>
        [Input("key")]
        public Input<string>? Key { get; set; }

        /// <summary>
        /// The ARN of the role that grants permission to AWS IoT Events to perform its operations.
        /// </summary>
        [Input("roleArn", required: true)]
        public Input<string> RoleArn { get; set; } = null!;

        [Input("tags")]
        private InputList<Inputs.DetectorModelTagArgs>? _tags;

        /// <summary>
        /// An array of key-value pairs to apply to this resource.
        /// 
        /// For more information, see [Tag](https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-resource-tags.html).
        /// </summary>
        public InputList<Inputs.DetectorModelTagArgs> Tags
        {
            get => _tags ?? (_tags = new InputList<Inputs.DetectorModelTagArgs>());
            set => _tags = value;
        }

        public DetectorModelArgs()
        {
        }
    }
}
