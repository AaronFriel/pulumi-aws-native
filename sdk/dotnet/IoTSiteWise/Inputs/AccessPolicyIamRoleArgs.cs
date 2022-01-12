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
    /// Contains information for an IAM role identity in an access policy.
    /// </summary>
    public sealed class AccessPolicyIamRoleArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The ARN of the IAM role.
        /// </summary>
        [Input("arn")]
        public Input<string>? Arn { get; set; }

        public AccessPolicyIamRoleArgs()
        {
        }
    }
}
