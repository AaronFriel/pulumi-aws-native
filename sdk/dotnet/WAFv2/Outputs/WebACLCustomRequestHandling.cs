// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.WAFv2.Outputs
{

    /// <summary>
    /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-webacl-customrequesthandling.html
    /// </summary>
    [OutputType]
    public sealed class WebACLCustomRequestHandling
    {
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-webacl-customrequesthandling.html#cfn-wafv2-webacl-customrequesthandling-insertheaders
        /// </summary>
        public readonly ImmutableArray<Outputs.WebACLCustomHTTPHeader> InsertHeaders;

        [OutputConstructor]
        private WebACLCustomRequestHandling(ImmutableArray<Outputs.WebACLCustomHTTPHeader> insertHeaders)
        {
            InsertHeaders = insertHeaders;
        }
    }
}