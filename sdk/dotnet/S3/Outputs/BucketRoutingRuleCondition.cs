// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.S3.Outputs
{

    /// <summary>
    /// A container for describing a condition that must be met for the specified redirect to apply.You must specify at least one of HttpErrorCodeReturnedEquals and KeyPrefixEquals
    /// </summary>
    [OutputType]
    public sealed class BucketRoutingRuleCondition
    {
        /// <summary>
        /// The HTTP error code when the redirect is applied. 
        /// </summary>
        public readonly string? HttpErrorCodeReturnedEquals;
        /// <summary>
        /// The object key name prefix when the redirect is applied.
        /// </summary>
        public readonly string? KeyPrefixEquals;

        [OutputConstructor]
        private BucketRoutingRuleCondition(
            string? httpErrorCodeReturnedEquals,

            string? keyPrefixEquals)
        {
            HttpErrorCodeReturnedEquals = httpErrorCodeReturnedEquals;
            KeyPrefixEquals = keyPrefixEquals;
        }
    }
}
