// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.Cognito
{
    /// <summary>
    /// Resource Type definition for AWS::Cognito::UserPoolGroup
    /// </summary>
    [Obsolete(@"UserPoolGroup is not yet supported by AWS Native, so its creation will currently fail. Please use the classic AWS provider, if possible.")]
    [AwsNativeResourceType("aws-native:cognito:UserPoolGroup")]
    public partial class UserPoolGroup : Pulumi.CustomResource
    {
        [Output("description")]
        public Output<string?> Description { get; private set; } = null!;

        [Output("groupName")]
        public Output<string?> GroupName { get; private set; } = null!;

        [Output("precedence")]
        public Output<double?> Precedence { get; private set; } = null!;

        [Output("roleArn")]
        public Output<string?> RoleArn { get; private set; } = null!;

        [Output("userPoolId")]
        public Output<string> UserPoolId { get; private set; } = null!;


        /// <summary>
        /// Create a UserPoolGroup resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public UserPoolGroup(string name, UserPoolGroupArgs args, CustomResourceOptions? options = null)
            : base("aws-native:cognito:UserPoolGroup", name, args ?? new UserPoolGroupArgs(), MakeResourceOptions(options, ""))
        {
        }

        private UserPoolGroup(string name, Input<string> id, CustomResourceOptions? options = null)
            : base("aws-native:cognito:UserPoolGroup", name, null, MakeResourceOptions(options, id))
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
        /// Get an existing UserPoolGroup resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static UserPoolGroup Get(string name, Input<string> id, CustomResourceOptions? options = null)
        {
            return new UserPoolGroup(name, id, options);
        }
    }

    public sealed class UserPoolGroupArgs : Pulumi.ResourceArgs
    {
        [Input("description")]
        public Input<string>? Description { get; set; }

        [Input("groupName")]
        public Input<string>? GroupName { get; set; }

        [Input("precedence")]
        public Input<double>? Precedence { get; set; }

        [Input("roleArn")]
        public Input<string>? RoleArn { get; set; }

        [Input("userPoolId", required: true)]
        public Input<string> UserPoolId { get; set; } = null!;

        public UserPoolGroupArgs()
        {
        }
    }
}
