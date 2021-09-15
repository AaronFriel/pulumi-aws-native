// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.CloudFormation.Inputs
{

    /// <summary>
    ///  The AWS OrganizationalUnitIds or Accounts for which to create stack instances in the specified Regions.
    /// </summary>
    public sealed class StackSetDeploymentTargetsArgs : Pulumi.ResourceArgs
    {
        [Input("accounts")]
        private InputList<string>? _accounts;

        /// <summary>
        /// AWS accounts that you want to create stack instances in the specified Region(s) for.
        /// </summary>
        public InputList<string> Accounts
        {
            get => _accounts ?? (_accounts = new InputList<string>());
            set => _accounts = value;
        }

        [Input("organizationalUnitIds")]
        private InputList<string>? _organizationalUnitIds;

        /// <summary>
        /// The organization root ID or organizational unit (OU) IDs to which StackSets deploys.
        /// </summary>
        public InputList<string> OrganizationalUnitIds
        {
            get => _organizationalUnitIds ?? (_organizationalUnitIds = new InputList<string>());
            set => _organizationalUnitIds = value;
        }

        public StackSetDeploymentTargetsArgs()
        {
        }
    }
}
