// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.Amplify.Inputs
{

    /// <summary>
    /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-amplify-app.html
    /// </summary>
    public sealed class AppPropertiesArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-amplify-app.html#cfn-amplify-app-accesstoken
        /// </summary>
        [Input("AccessToken")]
        public Input<string>? AccessToken { get; set; }

        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-amplify-app.html#cfn-amplify-app-autobranchcreationconfig
        /// </summary>
        [Input("AutoBranchCreationConfig")]
        public Input<Inputs.AppAutoBranchCreationConfigArgs>? AutoBranchCreationConfig { get; set; }

        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-amplify-app.html#cfn-amplify-app-basicauthconfig
        /// </summary>
        [Input("BasicAuthConfig")]
        public Input<Inputs.AppBasicAuthConfigArgs>? BasicAuthConfig { get; set; }

        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-amplify-app.html#cfn-amplify-app-buildspec
        /// </summary>
        [Input("BuildSpec")]
        public Input<string>? BuildSpec { get; set; }

        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-amplify-app.html#cfn-amplify-app-customheaders
        /// </summary>
        [Input("CustomHeaders")]
        public Input<string>? CustomHeaders { get; set; }

        [Input("CustomRules")]
        private InputList<Inputs.AppCustomRuleArgs>? _CustomRules;

        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-amplify-app.html#cfn-amplify-app-customrules
        /// </summary>
        public InputList<Inputs.AppCustomRuleArgs> CustomRules
        {
            get => _CustomRules ?? (_CustomRules = new InputList<Inputs.AppCustomRuleArgs>());
            set => _CustomRules = value;
        }

        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-amplify-app.html#cfn-amplify-app-description
        /// </summary>
        [Input("Description")]
        public Input<string>? Description { get; set; }

        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-amplify-app.html#cfn-amplify-app-enablebranchautodeletion
        /// </summary>
        [Input("EnableBranchAutoDeletion")]
        public Input<bool>? EnableBranchAutoDeletion { get; set; }

        [Input("EnvironmentVariables")]
        private InputList<Inputs.AppEnvironmentVariableArgs>? _EnvironmentVariables;

        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-amplify-app.html#cfn-amplify-app-environmentvariables
        /// </summary>
        public InputList<Inputs.AppEnvironmentVariableArgs> EnvironmentVariables
        {
            get => _EnvironmentVariables ?? (_EnvironmentVariables = new InputList<Inputs.AppEnvironmentVariableArgs>());
            set => _EnvironmentVariables = value;
        }

        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-amplify-app.html#cfn-amplify-app-iamservicerole
        /// </summary>
        [Input("IAMServiceRole")]
        public Input<string>? IAMServiceRole { get; set; }

        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-amplify-app.html#cfn-amplify-app-name
        /// </summary>
        [Input("Name", required: true)]
        public Input<string> Name { get; set; } = null!;

        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-amplify-app.html#cfn-amplify-app-oauthtoken
        /// </summary>
        [Input("OauthToken")]
        public Input<string>? OauthToken { get; set; }

        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-amplify-app.html#cfn-amplify-app-repository
        /// </summary>
        [Input("Repository")]
        public Input<string>? Repository { get; set; }

        [Input("Tags")]
        private InputList<Pulumi.AwsNative.Inputs.TagArgs>? _Tags;

        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-amplify-app.html#cfn-amplify-app-tags
        /// </summary>
        public InputList<Pulumi.AwsNative.Inputs.TagArgs> Tags
        {
            get => _Tags ?? (_Tags = new InputList<Pulumi.AwsNative.Inputs.TagArgs>());
            set => _Tags = value;
        }

        public AppPropertiesArgs()
        {
        }
    }
}
