// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.AccessAnalyzer.Outputs
{

    [OutputType]
    public sealed class AnalyzerFilter
    {
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-accessanalyzer-analyzer-filter.html#cfn-accessanalyzer-analyzer-filter-contains
        /// </summary>
        public readonly ImmutableArray<string> Contains;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-accessanalyzer-analyzer-filter.html#cfn-accessanalyzer-analyzer-filter-eq
        /// </summary>
        public readonly ImmutableArray<string> Eq;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-accessanalyzer-analyzer-filter.html#cfn-accessanalyzer-analyzer-filter-exists
        /// </summary>
        public readonly bool? Exists;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-accessanalyzer-analyzer-filter.html#cfn-accessanalyzer-analyzer-filter-neq
        /// </summary>
        public readonly ImmutableArray<string> Neq;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-accessanalyzer-analyzer-filter.html#cfn-accessanalyzer-analyzer-filter-property
        /// </summary>
        public readonly string Property;

        [OutputConstructor]
        private AnalyzerFilter(
            ImmutableArray<string> Contains,

            ImmutableArray<string> Eq,

            bool? Exists,

            ImmutableArray<string> Neq,

            string Property)
        {
            this.Contains = Contains;
            this.Eq = Eq;
            this.Exists = Exists;
            this.Neq = Neq;
            this.Property = Property;
        }
    }
}
