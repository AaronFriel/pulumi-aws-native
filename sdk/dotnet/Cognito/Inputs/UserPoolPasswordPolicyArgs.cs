// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.Cognito.Inputs
{

    public sealed class UserPoolPasswordPolicyArgs : Pulumi.ResourceArgs
    {
        [Input("minimumLength")]
        public Input<int>? MinimumLength { get; set; }

        [Input("requireLowercase")]
        public Input<bool>? RequireLowercase { get; set; }

        [Input("requireNumbers")]
        public Input<bool>? RequireNumbers { get; set; }

        [Input("requireSymbols")]
        public Input<bool>? RequireSymbols { get; set; }

        [Input("requireUppercase")]
        public Input<bool>? RequireUppercase { get; set; }

        [Input("temporaryPasswordValidityDays")]
        public Input<int>? TemporaryPasswordValidityDays { get; set; }

        public UserPoolPasswordPolicyArgs()
        {
        }
    }
}
