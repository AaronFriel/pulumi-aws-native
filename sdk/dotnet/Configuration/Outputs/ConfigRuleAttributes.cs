// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.Configuration.Outputs
{

    [OutputType]
    public sealed class ConfigRuleAttributes
    {
        public readonly string Arn;
        public readonly string ComplianceType;
        public readonly string ConfigRuleId;

        [OutputConstructor]
        private ConfigRuleAttributes(
            string Arn,

            string ComplianceType,

            string ConfigRuleId)
        {
            this.Arn = Arn;
            this.ComplianceType = ComplianceType;
            this.ConfigRuleId = ConfigRuleId;
        }
    }
}
