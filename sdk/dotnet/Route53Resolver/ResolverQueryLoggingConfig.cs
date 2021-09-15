// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.Route53Resolver
{
    /// <summary>
    /// Resource schema for AWS::Route53Resolver::ResolverQueryLoggingConfig.
    /// </summary>
    [AwsNativeResourceType("aws-native:route53resolver:ResolverQueryLoggingConfig")]
    public partial class ResolverQueryLoggingConfig : Pulumi.CustomResource
    {
        /// <summary>
        /// Arn
        /// </summary>
        [Output("arn")]
        public Output<string> Arn { get; private set; } = null!;

        /// <summary>
        /// Count
        /// </summary>
        [Output("associationCount")]
        public Output<int> AssociationCount { get; private set; } = null!;

        /// <summary>
        /// Rfc3339TimeString
        /// </summary>
        [Output("creationTime")]
        public Output<string> CreationTime { get; private set; } = null!;

        /// <summary>
        /// The id of the creator request.
        /// </summary>
        [Output("creatorRequestId")]
        public Output<string> CreatorRequestId { get; private set; } = null!;

        /// <summary>
        /// destination arn
        /// </summary>
        [Output("destinationArn")]
        public Output<string?> DestinationArn { get; private set; } = null!;

        /// <summary>
        /// ResolverQueryLogConfigName
        /// </summary>
        [Output("name")]
        public Output<string?> Name { get; private set; } = null!;

        /// <summary>
        /// AccountId
        /// </summary>
        [Output("ownerId")]
        public Output<string> OwnerId { get; private set; } = null!;

        /// <summary>
        /// ShareStatus, possible values are NOT_SHARED, SHARED_WITH_ME, SHARED_BY_ME.
        /// </summary>
        [Output("shareStatus")]
        public Output<string> ShareStatus { get; private set; } = null!;

        /// <summary>
        /// ResolverQueryLogConfigStatus, possible values are CREATING, CREATED, DELETED AND FAILED.
        /// </summary>
        [Output("status")]
        public Output<string> Status { get; private set; } = null!;


        /// <summary>
        /// Create a ResolverQueryLoggingConfig resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public ResolverQueryLoggingConfig(string name, ResolverQueryLoggingConfigArgs? args = null, CustomResourceOptions? options = null)
            : base("aws-native:route53resolver:ResolverQueryLoggingConfig", name, args ?? new ResolverQueryLoggingConfigArgs(), MakeResourceOptions(options, ""))
        {
        }

        private ResolverQueryLoggingConfig(string name, Input<string> id, CustomResourceOptions? options = null)
            : base("aws-native:route53resolver:ResolverQueryLoggingConfig", name, null, MakeResourceOptions(options, id))
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
        /// Get an existing ResolverQueryLoggingConfig resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static ResolverQueryLoggingConfig Get(string name, Input<string> id, CustomResourceOptions? options = null)
        {
            return new ResolverQueryLoggingConfig(name, id, options);
        }
    }

    public sealed class ResolverQueryLoggingConfigArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// destination arn
        /// </summary>
        [Input("destinationArn")]
        public Input<string>? DestinationArn { get; set; }

        /// <summary>
        /// ResolverQueryLogConfigName
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        public ResolverQueryLoggingConfigArgs()
        {
        }
    }
}
