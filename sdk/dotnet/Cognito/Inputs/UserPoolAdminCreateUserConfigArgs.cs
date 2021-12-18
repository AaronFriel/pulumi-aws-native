// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.Cognito.Inputs
{

    public sealed class UserPoolAdminCreateUserConfigArgs : Pulumi.ResourceArgs
    {
        [Input("allowAdminCreateUserOnly")]
        public Input<bool>? AllowAdminCreateUserOnly { get; set; }

        [Input("inviteMessageTemplate")]
        public Input<Inputs.UserPoolInviteMessageTemplateArgs>? InviteMessageTemplate { get; set; }

        [Input("unusedAccountValidityDays")]
        public Input<int>? UnusedAccountValidityDays { get; set; }

        public UserPoolAdminCreateUserConfigArgs()
        {
        }
    }
}
