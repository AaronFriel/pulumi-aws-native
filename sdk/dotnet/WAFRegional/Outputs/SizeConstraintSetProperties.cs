// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.WAFRegional.Outputs
{

    [OutputType]
    public sealed class SizeConstraintSetProperties
    {
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-wafregional-sizeconstraintset.html#cfn-wafregional-sizeconstraintset-name
        /// </summary>
        public readonly string Name;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-wafregional-sizeconstraintset.html#cfn-wafregional-sizeconstraintset-sizeconstraints
        /// </summary>
        public readonly ImmutableArray<Outputs.SizeConstraintSetSizeConstraint> SizeConstraints;

        [OutputConstructor]
        private SizeConstraintSetProperties(
            string Name,

            ImmutableArray<Outputs.SizeConstraintSetSizeConstraint> SizeConstraints)
        {
            this.Name = Name;
            this.SizeConstraints = SizeConstraints;
        }
    }
}
