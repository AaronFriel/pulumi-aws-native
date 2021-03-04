// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.Route53Resolver.Outputs
{

    [OutputType]
    public sealed class ResolverRuleAssociationAttributes
    {
        public readonly string Name;
        public readonly string ResolverRuleAssociationId;
        public readonly string ResolverRuleId;
        public readonly string VPCId;

        [OutputConstructor]
        private ResolverRuleAssociationAttributes(
            string Name,

            string ResolverRuleAssociationId,

            string ResolverRuleId,

            string VPCId)
        {
            this.Name = Name;
            this.ResolverRuleAssociationId = ResolverRuleAssociationId;
            this.ResolverRuleId = ResolverRuleId;
            this.VPCId = VPCId;
        }
    }
}
