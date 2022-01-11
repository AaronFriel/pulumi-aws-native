// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.IoTSiteWise.Inputs
{

    /// <summary>
    /// The identity for this access policy. Choose either an SSO user or group or an IAM user or role.
    /// </summary>
    public sealed class AccessPolicyIdentityArgs : Pulumi.ResourceArgs
    {
        [Input("iamRole")]
        public Input<Inputs.AccessPolicyIamRoleArgs>? IamRole { get; set; }

        [Input("iamUser")]
        public Input<Inputs.AccessPolicyIamUserArgs>? IamUser { get; set; }

        [Input("user")]
        public Input<Inputs.AccessPolicyUserArgs>? User { get; set; }

        public AccessPolicyIdentityArgs()
        {
        }
    }
}
