// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.ElastiCache
{
    /// <summary>
    /// Resource Type definition for AWS::ElastiCache::UserGroup
    /// </summary>
    [AwsNativeResourceType("aws-native:elasticache:UserGroup")]
    public partial class UserGroup : Pulumi.CustomResource
    {
        /// <summary>
        /// The Amazon Resource Name (ARN) of the user account.
        /// </summary>
        [Output("arn")]
        public Output<string> Arn { get; private set; } = null!;

        /// <summary>
        /// Must be redis.
        /// </summary>
        [Output("engine")]
        public Output<Pulumi.AwsNative.ElastiCache.UserGroupEngine> Engine { get; private set; } = null!;

        /// <summary>
        /// Indicates user group status. Can be "creating", "active", "modifying", "deleting".
        /// </summary>
        [Output("status")]
        public Output<string> Status { get; private set; } = null!;

        /// <summary>
        /// The ID of the user group.
        /// </summary>
        [Output("userGroupId")]
        public Output<string> UserGroupId { get; private set; } = null!;

        /// <summary>
        /// List of users associated to this user group.
        /// </summary>
        [Output("userIds")]
        public Output<ImmutableArray<string>> UserIds { get; private set; } = null!;


        /// <summary>
        /// Create a UserGroup resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public UserGroup(string name, UserGroupArgs args, CustomResourceOptions? options = null)
            : base("aws-native:elasticache:UserGroup", name, args ?? new UserGroupArgs(), MakeResourceOptions(options, ""))
        {
        }

        private UserGroup(string name, Input<string> id, CustomResourceOptions? options = null)
            : base("aws-native:elasticache:UserGroup", name, null, MakeResourceOptions(options, id))
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
        /// Get an existing UserGroup resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static UserGroup Get(string name, Input<string> id, CustomResourceOptions? options = null)
        {
            return new UserGroup(name, id, options);
        }
    }

    public sealed class UserGroupArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Must be redis.
        /// </summary>
        [Input("engine", required: true)]
        public Input<Pulumi.AwsNative.ElastiCache.UserGroupEngine> Engine { get; set; } = null!;

        /// <summary>
        /// The ID of the user group.
        /// </summary>
        [Input("userGroupId", required: true)]
        public Input<string> UserGroupId { get; set; } = null!;

        [Input("userIds")]
        private InputList<string>? _userIds;

        /// <summary>
        /// List of users associated to this user group.
        /// </summary>
        public InputList<string> UserIds
        {
            get => _userIds ?? (_userIds = new InputList<string>());
            set => _userIds = value;
        }

        public UserGroupArgs()
        {
        }
    }
}
