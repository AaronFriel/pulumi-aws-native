// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.SES.Outputs
{

    [OutputType]
    public sealed class ReceiptRuleWorkmailAction
    {
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ses-receiptrule-workmailaction.html#cfn-ses-receiptrule-workmailaction-organizationarn
        /// </summary>
        public readonly string OrganizationArn;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ses-receiptrule-workmailaction.html#cfn-ses-receiptrule-workmailaction-topicarn
        /// </summary>
        public readonly string? TopicArn;

        [OutputConstructor]
        private ReceiptRuleWorkmailAction(
            string OrganizationArn,

            string? TopicArn)
        {
            this.OrganizationArn = OrganizationArn;
            this.TopicArn = TopicArn;
        }
    }
}
