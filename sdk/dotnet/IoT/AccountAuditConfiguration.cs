// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.IoT
{
    /// <summary>
    /// Configures the Device Defender audit settings for this account. Settings include how audit notifications are sent and which audit checks are enabled or disabled.
    /// </summary>
    [AwsNativeResourceType("aws-native:iot:AccountAuditConfiguration")]
    public partial class AccountAuditConfiguration : Pulumi.CustomResource
    {
        /// <summary>
        /// Your 12-digit account ID (used as the primary identifier for the CloudFormation resource).
        /// </summary>
        [Output("accountId")]
        public Output<string> AccountId { get; private set; } = null!;

        [Output("auditCheckConfigurations")]
        public Output<Outputs.AccountAuditConfigurationAuditCheckConfigurations> AuditCheckConfigurations { get; private set; } = null!;

        [Output("auditNotificationTargetConfigurations")]
        public Output<Outputs.AccountAuditConfigurationAuditNotificationTargetConfigurations?> AuditNotificationTargetConfigurations { get; private set; } = null!;

        /// <summary>
        /// The ARN of the role that grants permission to AWS IoT to access information about your devices, policies, certificates and other items as required when performing an audit.
        /// </summary>
        [Output("roleArn")]
        public Output<string> RoleArn { get; private set; } = null!;


        /// <summary>
        /// Create a AccountAuditConfiguration resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public AccountAuditConfiguration(string name, AccountAuditConfigurationArgs args, CustomResourceOptions? options = null)
            : base("aws-native:iot:AccountAuditConfiguration", name, args ?? new AccountAuditConfigurationArgs(), MakeResourceOptions(options, ""))
        {
        }

        private AccountAuditConfiguration(string name, Input<string> id, CustomResourceOptions? options = null)
            : base("aws-native:iot:AccountAuditConfiguration", name, null, MakeResourceOptions(options, id))
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
        /// Get an existing AccountAuditConfiguration resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static AccountAuditConfiguration Get(string name, Input<string> id, CustomResourceOptions? options = null)
        {
            return new AccountAuditConfiguration(name, id, options);
        }
    }

    public sealed class AccountAuditConfigurationArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Your 12-digit account ID (used as the primary identifier for the CloudFormation resource).
        /// </summary>
        [Input("accountId", required: true)]
        public Input<string> AccountId { get; set; } = null!;

        [Input("auditCheckConfigurations", required: true)]
        public Input<Inputs.AccountAuditConfigurationAuditCheckConfigurationsArgs> AuditCheckConfigurations { get; set; } = null!;

        [Input("auditNotificationTargetConfigurations")]
        public Input<Inputs.AccountAuditConfigurationAuditNotificationTargetConfigurationsArgs>? AuditNotificationTargetConfigurations { get; set; }

        /// <summary>
        /// The ARN of the role that grants permission to AWS IoT to access information about your devices, policies, certificates and other items as required when performing an audit.
        /// </summary>
        [Input("roleArn", required: true)]
        public Input<string> RoleArn { get; set; } = null!;

        public AccountAuditConfigurationArgs()
        {
        }
    }
}
