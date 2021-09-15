// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.FMS.Outputs
{

    /// <summary>
    /// An FMS includeMap or excludeMap.
    /// </summary>
    [OutputType]
    public sealed class PolicyIEMap
    {
        public readonly ImmutableArray<string> ACCOUNT;
        public readonly ImmutableArray<string> ORGUNIT;

        [OutputConstructor]
        private PolicyIEMap(
            ImmutableArray<string> aCCOUNT,

            ImmutableArray<string> oRGUNIT)
        {
            ACCOUNT = aCCOUNT;
            ORGUNIT = oRGUNIT;
        }
    }
}
