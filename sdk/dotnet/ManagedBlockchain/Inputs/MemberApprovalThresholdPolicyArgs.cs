// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.ManagedBlockchain.Inputs
{

    /// <summary>
    /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-managedblockchain-member-approvalthresholdpolicy.html
    /// </summary>
    public sealed class MemberApprovalThresholdPolicyArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-managedblockchain-member-approvalthresholdpolicy.html#cfn-managedblockchain-member-approvalthresholdpolicy-proposaldurationinhours
        /// </summary>
        [Input("proposalDurationInHours")]
        public Input<int>? ProposalDurationInHours { get; set; }

        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-managedblockchain-member-approvalthresholdpolicy.html#cfn-managedblockchain-member-approvalthresholdpolicy-thresholdcomparator
        /// </summary>
        [Input("thresholdComparator")]
        public Input<string>? ThresholdComparator { get; set; }

        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-managedblockchain-member-approvalthresholdpolicy.html#cfn-managedblockchain-member-approvalthresholdpolicy-thresholdpercentage
        /// </summary>
        [Input("thresholdPercentage")]
        public Input<int>? ThresholdPercentage { get; set; }

        public MemberApprovalThresholdPolicyArgs()
        {
        }
    }
}