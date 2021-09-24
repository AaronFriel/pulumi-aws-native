// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.IAM
{
    /// <summary>
    /// Resource Type definition for AWS::IAM::Role
    /// </summary>
    [Obsolete(@"Role is not yet supported by AWS Native, so its creation will currently fail. Please use the classic AWS provider, if possible.")]
    [AwsNativeResourceType("aws-native:iam:Role")]
    public partial class Role : Pulumi.CustomResource
    {
        [Output("arn")]
        public Output<string> Arn { get; private set; } = null!;

        [Output("assumeRolePolicyDocument")]
        public Output<object> AssumeRolePolicyDocument { get; private set; } = null!;

        [Output("description")]
        public Output<string?> Description { get; private set; } = null!;

        [Output("managedPolicyArns")]
        public Output<ImmutableArray<string>> ManagedPolicyArns { get; private set; } = null!;

        [Output("maxSessionDuration")]
        public Output<int?> MaxSessionDuration { get; private set; } = null!;

        [Output("path")]
        public Output<string?> Path { get; private set; } = null!;

        [Output("permissionsBoundary")]
        public Output<string?> PermissionsBoundary { get; private set; } = null!;

        [Output("policies")]
        public Output<ImmutableArray<Outputs.RolePolicy>> Policies { get; private set; } = null!;

        [Output("roleId")]
        public Output<string> RoleId { get; private set; } = null!;

        [Output("roleName")]
        public Output<string?> RoleName { get; private set; } = null!;

        [Output("tags")]
        public Output<ImmutableArray<Outputs.RoleTag>> Tags { get; private set; } = null!;


        /// <summary>
        /// Create a Role resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public Role(string name, RoleArgs args, CustomResourceOptions? options = null)
            : base("aws-native:iam:Role", name, args ?? new RoleArgs(), MakeResourceOptions(options, ""))
        {
        }

        private Role(string name, Input<string> id, CustomResourceOptions? options = null)
            : base("aws-native:iam:Role", name, null, MakeResourceOptions(options, id))
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
        /// Get an existing Role resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static Role Get(string name, Input<string> id, CustomResourceOptions? options = null)
        {
            return new Role(name, id, options);
        }
    }

    public sealed class RoleArgs : Pulumi.ResourceArgs
    {
        [Input("assumeRolePolicyDocument", required: true)]
        public Input<object> AssumeRolePolicyDocument { get; set; } = null!;

        [Input("description")]
        public Input<string>? Description { get; set; }

        [Input("managedPolicyArns")]
        private InputList<string>? _managedPolicyArns;
        public InputList<string> ManagedPolicyArns
        {
            get => _managedPolicyArns ?? (_managedPolicyArns = new InputList<string>());
            set => _managedPolicyArns = value;
        }

        [Input("maxSessionDuration")]
        public Input<int>? MaxSessionDuration { get; set; }

        [Input("path")]
        public Input<string>? Path { get; set; }

        [Input("permissionsBoundary")]
        public Input<string>? PermissionsBoundary { get; set; }

        [Input("policies")]
        private InputList<Inputs.RolePolicyArgs>? _policies;
        public InputList<Inputs.RolePolicyArgs> Policies
        {
            get => _policies ?? (_policies = new InputList<Inputs.RolePolicyArgs>());
            set => _policies = value;
        }

        [Input("roleName")]
        public Input<string>? RoleName { get; set; }

        [Input("tags")]
        private InputList<Inputs.RoleTagArgs>? _tags;
        public InputList<Inputs.RoleTagArgs> Tags
        {
            get => _tags ?? (_tags = new InputList<Inputs.RoleTagArgs>());
            set => _tags = value;
        }

        public RoleArgs()
        {
        }
    }
}
