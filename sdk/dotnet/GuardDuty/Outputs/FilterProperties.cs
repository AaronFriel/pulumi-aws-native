// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.GuardDuty.Outputs
{

    [OutputType]
    public sealed class FilterProperties
    {
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-guardduty-filter.html#cfn-guardduty-filter-action
        /// </summary>
        public readonly string Action;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-guardduty-filter.html#cfn-guardduty-filter-description
        /// </summary>
        public readonly string Description;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-guardduty-filter.html#cfn-guardduty-filter-detectorid
        /// </summary>
        public readonly string DetectorId;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-guardduty-filter.html#cfn-guardduty-filter-findingcriteria
        /// </summary>
        public readonly Outputs.FilterFindingCriteria FindingCriteria;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-guardduty-filter.html#cfn-guardduty-filter-name
        /// </summary>
        public readonly string Name;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-guardduty-filter.html#cfn-guardduty-filter-rank
        /// </summary>
        public readonly int Rank;

        [OutputConstructor]
        private FilterProperties(
            string Action,

            string Description,

            string DetectorId,

            Outputs.FilterFindingCriteria FindingCriteria,

            string Name,

            int Rank)
        {
            this.Action = Action;
            this.Description = Description;
            this.DetectorId = DetectorId;
            this.FindingCriteria = FindingCriteria;
            this.Name = Name;
            this.Rank = Rank;
        }
    }
}
