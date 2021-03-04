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
    public sealed class WebACLWafAction
    {
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-waf-webacl-action.html#cfn-waf-webacl-action-type
        /// </summary>
        public readonly string Type;

        [OutputConstructor]
        private WebACLWafAction(string Type)
        {
            this.Type = Type;
        }
    }
}
