// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.Macie.Outputs
{

    [OutputType]
    public sealed class CustomDataIdentifierProperties
    {
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-macie-customdataidentifier.html#cfn-macie-customdataidentifier-description
        /// </summary>
        public readonly string? Description;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-macie-customdataidentifier.html#cfn-macie-customdataidentifier-ignorewords
        /// </summary>
        public readonly ImmutableArray<string> IgnoreWords;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-macie-customdataidentifier.html#cfn-macie-customdataidentifier-keywords
        /// </summary>
        public readonly ImmutableArray<string> Keywords;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-macie-customdataidentifier.html#cfn-macie-customdataidentifier-maximummatchdistance
        /// </summary>
        public readonly int? MaximumMatchDistance;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-macie-customdataidentifier.html#cfn-macie-customdataidentifier-name
        /// </summary>
        public readonly string Name;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-macie-customdataidentifier.html#cfn-macie-customdataidentifier-regex
        /// </summary>
        public readonly string Regex;

        [OutputConstructor]
        private CustomDataIdentifierProperties(
            string? Description,

            ImmutableArray<string> IgnoreWords,

            ImmutableArray<string> Keywords,

            int? MaximumMatchDistance,

            string Name,

            string Regex)
        {
            this.Description = Description;
            this.IgnoreWords = IgnoreWords;
            this.Keywords = Keywords;
            this.MaximumMatchDistance = MaximumMatchDistance;
            this.Name = Name;
            this.Regex = Regex;
        }
    }
}
