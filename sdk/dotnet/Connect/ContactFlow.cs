// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.Connect
{
    /// <summary>
    /// Resource Type definition for AWS::Connect::ContactFlow
    /// </summary>
    [AwsNativeResourceType("aws-native:connect:ContactFlow")]
    public partial class ContactFlow : Pulumi.CustomResource
    {
        /// <summary>
        /// The identifier of the contact flow (ARN).
        /// </summary>
        [Output("contactFlowArn")]
        public Output<string> ContactFlowArn { get; private set; } = null!;

        /// <summary>
        /// The content of the contact flow in JSON format.
        /// </summary>
        [Output("content")]
        public Output<string> Content { get; private set; } = null!;

        /// <summary>
        /// The description of the contact flow.
        /// </summary>
        [Output("description")]
        public Output<string?> Description { get; private set; } = null!;

        /// <summary>
        /// The identifier of the Amazon Connect instance (ARN).
        /// </summary>
        [Output("instanceArn")]
        public Output<string> InstanceArn { get; private set; } = null!;

        /// <summary>
        /// The name of the contact flow.
        /// </summary>
        [Output("name")]
        public Output<string> Name { get; private set; } = null!;

        /// <summary>
        /// The state of the contact flow.
        /// </summary>
        [Output("state")]
        public Output<Pulumi.AwsNative.Connect.ContactFlowState?> State { get; private set; } = null!;

        /// <summary>
        /// One or more tags.
        /// </summary>
        [Output("tags")]
        public Output<ImmutableArray<Outputs.ContactFlowTag>> Tags { get; private set; } = null!;

        /// <summary>
        /// The type of the contact flow.
        /// </summary>
        [Output("type")]
        public Output<Pulumi.AwsNative.Connect.ContactFlowType?> Type { get; private set; } = null!;


        /// <summary>
        /// Create a ContactFlow resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public ContactFlow(string name, ContactFlowArgs args, CustomResourceOptions? options = null)
            : base("aws-native:connect:ContactFlow", name, args ?? new ContactFlowArgs(), MakeResourceOptions(options, ""))
        {
        }

        private ContactFlow(string name, Input<string> id, CustomResourceOptions? options = null)
            : base("aws-native:connect:ContactFlow", name, null, MakeResourceOptions(options, id))
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
        /// Get an existing ContactFlow resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static ContactFlow Get(string name, Input<string> id, CustomResourceOptions? options = null)
        {
            return new ContactFlow(name, id, options);
        }
    }

    public sealed class ContactFlowArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The content of the contact flow in JSON format.
        /// </summary>
        [Input("content", required: true)]
        public Input<string> Content { get; set; } = null!;

        /// <summary>
        /// The description of the contact flow.
        /// </summary>
        [Input("description")]
        public Input<string>? Description { get; set; }

        /// <summary>
        /// The identifier of the Amazon Connect instance (ARN).
        /// </summary>
        [Input("instanceArn", required: true)]
        public Input<string> InstanceArn { get; set; } = null!;

        /// <summary>
        /// The name of the contact flow.
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        /// <summary>
        /// The state of the contact flow.
        /// </summary>
        [Input("state")]
        public Input<Pulumi.AwsNative.Connect.ContactFlowState>? State { get; set; }

        [Input("tags")]
        private InputList<Inputs.ContactFlowTagArgs>? _tags;

        /// <summary>
        /// One or more tags.
        /// </summary>
        public InputList<Inputs.ContactFlowTagArgs> Tags
        {
            get => _tags ?? (_tags = new InputList<Inputs.ContactFlowTagArgs>());
            set => _tags = value;
        }

        /// <summary>
        /// The type of the contact flow.
        /// </summary>
        [Input("type")]
        public Input<Pulumi.AwsNative.Connect.ContactFlowType>? Type { get; set; }

        public ContactFlowArgs()
        {
        }
    }
}
