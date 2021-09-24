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
    /// Resource Type definition for AWS::Cognito::UserPool
    /// </summary>
    [Obsolete(@"UserPool is not yet supported by AWS Native, so its creation will currently fail. Please use the classic AWS provider, if possible.")]
    [AwsNativeResourceType("aws-native:cognito:UserPool")]
    public partial class UserPool : Pulumi.CustomResource
    {
        [Output("accountRecoverySetting")]
        public Output<Outputs.UserPoolAccountRecoverySetting?> AccountRecoverySetting { get; private set; } = null!;

        [Output("adminCreateUserConfig")]
        public Output<Outputs.UserPoolAdminCreateUserConfig?> AdminCreateUserConfig { get; private set; } = null!;

        [Output("aliasAttributes")]
        public Output<ImmutableArray<string>> AliasAttributes { get; private set; } = null!;

        [Output("arn")]
        public Output<string> Arn { get; private set; } = null!;

        [Output("autoVerifiedAttributes")]
        public Output<ImmutableArray<string>> AutoVerifiedAttributes { get; private set; } = null!;

        [Output("deviceConfiguration")]
        public Output<Outputs.UserPoolDeviceConfiguration?> DeviceConfiguration { get; private set; } = null!;

        [Output("emailConfiguration")]
        public Output<Outputs.UserPoolEmailConfiguration?> EmailConfiguration { get; private set; } = null!;

        [Output("emailVerificationMessage")]
        public Output<string?> EmailVerificationMessage { get; private set; } = null!;

        [Output("emailVerificationSubject")]
        public Output<string?> EmailVerificationSubject { get; private set; } = null!;

        [Output("enabledMfas")]
        public Output<ImmutableArray<string>> EnabledMfas { get; private set; } = null!;

        [Output("lambdaConfig")]
        public Output<Outputs.UserPoolLambdaConfig?> LambdaConfig { get; private set; } = null!;

        [Output("mfaConfiguration")]
        public Output<string?> MfaConfiguration { get; private set; } = null!;

        [Output("policies")]
        public Output<Outputs.UserPoolPolicies?> Policies { get; private set; } = null!;

        [Output("providerName")]
        public Output<string> ProviderName { get; private set; } = null!;

        [Output("providerURL")]
        public Output<string> ProviderURL { get; private set; } = null!;

        [Output("schema")]
        public Output<ImmutableArray<Outputs.UserPoolSchemaAttribute>> Schema { get; private set; } = null!;

        [Output("smsAuthenticationMessage")]
        public Output<string?> SmsAuthenticationMessage { get; private set; } = null!;

        [Output("smsConfiguration")]
        public Output<Outputs.UserPoolSmsConfiguration?> SmsConfiguration { get; private set; } = null!;

        [Output("smsVerificationMessage")]
        public Output<string?> SmsVerificationMessage { get; private set; } = null!;

        [Output("userPoolAddOns")]
        public Output<Outputs.UserPoolUserPoolAddOns?> UserPoolAddOns { get; private set; } = null!;

        [Output("userPoolName")]
        public Output<string?> UserPoolName { get; private set; } = null!;

        [Output("userPoolTags")]
        public Output<object?> UserPoolTags { get; private set; } = null!;

        [Output("usernameAttributes")]
        public Output<ImmutableArray<string>> UsernameAttributes { get; private set; } = null!;

        [Output("usernameConfiguration")]
        public Output<Outputs.UserPoolUsernameConfiguration?> UsernameConfiguration { get; private set; } = null!;

        [Output("verificationMessageTemplate")]
        public Output<Outputs.UserPoolVerificationMessageTemplate?> VerificationMessageTemplate { get; private set; } = null!;


        /// <summary>
        /// Create a UserPool resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public UserPool(string name, UserPoolArgs? args = null, CustomResourceOptions? options = null)
            : base("aws-native:cognito:UserPool", name, args ?? new UserPoolArgs(), MakeResourceOptions(options, ""))
        {
        }

        private UserPool(string name, Input<string> id, CustomResourceOptions? options = null)
            : base("aws-native:cognito:UserPool", name, null, MakeResourceOptions(options, id))
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
        /// Get an existing UserPool resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static UserPool Get(string name, Input<string> id, CustomResourceOptions? options = null)
        {
            return new UserPool(name, id, options);
        }
    }

    public sealed class UserPoolArgs : Pulumi.ResourceArgs
    {
        [Input("accountRecoverySetting")]
        public Input<Inputs.UserPoolAccountRecoverySettingArgs>? AccountRecoverySetting { get; set; }

        [Input("adminCreateUserConfig")]
        public Input<Inputs.UserPoolAdminCreateUserConfigArgs>? AdminCreateUserConfig { get; set; }

        [Input("aliasAttributes")]
        private InputList<string>? _aliasAttributes;
        public InputList<string> AliasAttributes
        {
            get => _aliasAttributes ?? (_aliasAttributes = new InputList<string>());
            set => _aliasAttributes = value;
        }

        [Input("autoVerifiedAttributes")]
        private InputList<string>? _autoVerifiedAttributes;
        public InputList<string> AutoVerifiedAttributes
        {
            get => _autoVerifiedAttributes ?? (_autoVerifiedAttributes = new InputList<string>());
            set => _autoVerifiedAttributes = value;
        }

        [Input("deviceConfiguration")]
        public Input<Inputs.UserPoolDeviceConfigurationArgs>? DeviceConfiguration { get; set; }

        [Input("emailConfiguration")]
        public Input<Inputs.UserPoolEmailConfigurationArgs>? EmailConfiguration { get; set; }

        [Input("emailVerificationMessage")]
        public Input<string>? EmailVerificationMessage { get; set; }

        [Input("emailVerificationSubject")]
        public Input<string>? EmailVerificationSubject { get; set; }

        [Input("enabledMfas")]
        private InputList<string>? _enabledMfas;
        public InputList<string> EnabledMfas
        {
            get => _enabledMfas ?? (_enabledMfas = new InputList<string>());
            set => _enabledMfas = value;
        }

        [Input("lambdaConfig")]
        public Input<Inputs.UserPoolLambdaConfigArgs>? LambdaConfig { get; set; }

        [Input("mfaConfiguration")]
        public Input<string>? MfaConfiguration { get; set; }

        [Input("policies")]
        public Input<Inputs.UserPoolPoliciesArgs>? Policies { get; set; }

        [Input("schema")]
        private InputList<Inputs.UserPoolSchemaAttributeArgs>? _schema;
        public InputList<Inputs.UserPoolSchemaAttributeArgs> Schema
        {
            get => _schema ?? (_schema = new InputList<Inputs.UserPoolSchemaAttributeArgs>());
            set => _schema = value;
        }

        [Input("smsAuthenticationMessage")]
        public Input<string>? SmsAuthenticationMessage { get; set; }

        [Input("smsConfiguration")]
        public Input<Inputs.UserPoolSmsConfigurationArgs>? SmsConfiguration { get; set; }

        [Input("smsVerificationMessage")]
        public Input<string>? SmsVerificationMessage { get; set; }

        [Input("userPoolAddOns")]
        public Input<Inputs.UserPoolUserPoolAddOnsArgs>? UserPoolAddOns { get; set; }

        [Input("userPoolName")]
        public Input<string>? UserPoolName { get; set; }

        [Input("userPoolTags")]
        public Input<object>? UserPoolTags { get; set; }

        [Input("usernameAttributes")]
        private InputList<string>? _usernameAttributes;
        public InputList<string> UsernameAttributes
        {
            get => _usernameAttributes ?? (_usernameAttributes = new InputList<string>());
            set => _usernameAttributes = value;
        }

        [Input("usernameConfiguration")]
        public Input<Inputs.UserPoolUsernameConfigurationArgs>? UsernameConfiguration { get; set; }

        [Input("verificationMessageTemplate")]
        public Input<Inputs.UserPoolVerificationMessageTemplateArgs>? VerificationMessageTemplate { get; set; }

        public UserPoolArgs()
        {
        }
    }
}
