// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.WAF.Outputs
{

    [OutputType]
    public sealed class XssMatchSetProperties
    {
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-waf-xssmatchset.html#cfn-waf-xssmatchset-name
        /// </summary>
        public readonly string Name;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-waf-xssmatchset.html#cfn-waf-xssmatchset-xssmatchtuples
        /// </summary>
        public readonly ImmutableArray<Outputs.XssMatchSetXssMatchTuple> XssMatchTuples;

        [OutputConstructor]
        private XssMatchSetProperties(
            string Name,

            ImmutableArray<Outputs.XssMatchSetXssMatchTuple> XssMatchTuples)
        {
            this.Name = Name;
            this.XssMatchTuples = XssMatchTuples;
        }
    }
}
