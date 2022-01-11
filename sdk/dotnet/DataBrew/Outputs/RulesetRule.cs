// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.DataBrew.Outputs
{

    /// <summary>
    /// Data quality rule for a target resource (dataset)
    /// </summary>
    [OutputType]
    public sealed class RulesetRule
    {
        public readonly string CheckExpression;
        public readonly ImmutableArray<Outputs.RulesetColumnSelector> ColumnSelectors;
        public readonly bool? Disabled;
        /// <summary>
        /// Name of the rule
        /// </summary>
        public readonly string Name;
        public readonly ImmutableArray<Outputs.RulesetSubstitutionValue> SubstitutionMap;
        public readonly Outputs.RulesetThreshold? Threshold;

        [OutputConstructor]
        private RulesetRule(
            string checkExpression,

            ImmutableArray<Outputs.RulesetColumnSelector> columnSelectors,

            bool? disabled,

            string name,

            ImmutableArray<Outputs.RulesetSubstitutionValue> substitutionMap,

            Outputs.RulesetThreshold? threshold)
        {
            CheckExpression = checkExpression;
            ColumnSelectors = columnSelectors;
            Disabled = disabled;
            Name = name;
            SubstitutionMap = substitutionMap;
            Threshold = threshold;
        }
    }
}
