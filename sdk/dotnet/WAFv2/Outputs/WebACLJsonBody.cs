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
    /// Inspect the request body as JSON. The request body immediately follows the request headers.
    /// </summary>
    [OutputType]
    public sealed class WebACLJsonBody
    {
        public readonly string? InvalidFallbackBehavior;
        public readonly Outputs.WebACLJsonMatchPattern MatchPattern;
        public readonly string MatchScope;

        [OutputConstructor]
        private WebACLJsonBody(
            string? invalidFallbackBehavior,

            Outputs.WebACLJsonMatchPattern matchPattern,

            string matchScope)
        {
            InvalidFallbackBehavior = invalidFallbackBehavior;
            MatchPattern = matchPattern;
            MatchScope = matchScope;
        }
    }
}
