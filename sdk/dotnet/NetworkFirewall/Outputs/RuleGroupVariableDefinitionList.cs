// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.NetworkFirewall.Outputs
{

    [OutputType]
    public sealed class RuleGroupVariableDefinitionList
    {
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-networkfirewall-rulegroup-variabledefinitionlist.html#cfn-networkfirewall-rulegroup-variabledefinitionlist-variabledefinitionlist
        /// </summary>
        public readonly ImmutableArray<string> VariableDefinitionList;

        [OutputConstructor]
        private RuleGroupVariableDefinitionList(ImmutableArray<string> VariableDefinitionList)
        {
            this.VariableDefinitionList = VariableDefinitionList;
        }
    }
}
