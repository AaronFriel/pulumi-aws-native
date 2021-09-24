// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.PinpointEmail
{
    /// <summary>
    /// Resource Type definition for AWS::PinpointEmail::Identity
    /// </summary>
    [Obsolete(@"Identity is not yet supported by AWS Native, so its creation will currently fail. Please use the classic AWS provider, if possible.")]
    [AwsNativeResourceType("aws-native:pinpointemail:Identity")]
    public partial class Identity : Pulumi.CustomResource
    {
        [Output("dkimSigningEnabled")]
        public Output<bool?> DkimSigningEnabled { get; private set; } = null!;

        [Output("feedbackForwardingEnabled")]
        public Output<bool?> FeedbackForwardingEnabled { get; private set; } = null!;

        [Output("identityDNSRecordName1")]
        public Output<string> IdentityDNSRecordName1 { get; private set; } = null!;

        [Output("identityDNSRecordName2")]
        public Output<string> IdentityDNSRecordName2 { get; private set; } = null!;

        [Output("identityDNSRecordName3")]
        public Output<string> IdentityDNSRecordName3 { get; private set; } = null!;

        [Output("identityDNSRecordValue1")]
        public Output<string> IdentityDNSRecordValue1 { get; private set; } = null!;

        [Output("identityDNSRecordValue2")]
        public Output<string> IdentityDNSRecordValue2 { get; private set; } = null!;

        [Output("identityDNSRecordValue3")]
        public Output<string> IdentityDNSRecordValue3 { get; private set; } = null!;

        [Output("mailFromAttributes")]
        public Output<Outputs.IdentityMailFromAttributes?> MailFromAttributes { get; private set; } = null!;

        [Output("name")]
        public Output<string> Name { get; private set; } = null!;

        [Output("tags")]
        public Output<ImmutableArray<Outputs.IdentityTags>> Tags { get; private set; } = null!;


        /// <summary>
        /// Create a Identity resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public Identity(string name, IdentityArgs args, CustomResourceOptions? options = null)
            : base("aws-native:pinpointemail:Identity", name, args ?? new IdentityArgs(), MakeResourceOptions(options, ""))
        {
        }

        private Identity(string name, Input<string> id, CustomResourceOptions? options = null)
            : base("aws-native:pinpointemail:Identity", name, null, MakeResourceOptions(options, id))
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
        /// Get an existing Identity resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static Identity Get(string name, Input<string> id, CustomResourceOptions? options = null)
        {
            return new Identity(name, id, options);
        }
    }

    public sealed class IdentityArgs : Pulumi.ResourceArgs
    {
        [Input("dkimSigningEnabled")]
        public Input<bool>? DkimSigningEnabled { get; set; }

        [Input("feedbackForwardingEnabled")]
        public Input<bool>? FeedbackForwardingEnabled { get; set; }

        [Input("mailFromAttributes")]
        public Input<Inputs.IdentityMailFromAttributesArgs>? MailFromAttributes { get; set; }

        [Input("name", required: true)]
        public Input<string> Name { get; set; } = null!;

        [Input("tags")]
        private InputList<Inputs.IdentityTagsArgs>? _tags;
        public InputList<Inputs.IdentityTagsArgs> Tags
        {
            get => _tags ?? (_tags = new InputList<Inputs.IdentityTagsArgs>());
            set => _tags = value;
        }

        public IdentityArgs()
        {
        }
    }
}
