// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.Macie.Outputs
{

    /// <summary>
    /// Returned by ListHandler representing filter name and ID.
    /// </summary>
    [OutputType]
    public sealed class FindingsFilterFindingsFilterListItem
    {
        public readonly string? Id;
        public readonly string? Name;

        [OutputConstructor]
        private FindingsFilterFindingsFilterListItem(
            string? id,

            string? name)
        {
            Id = id;
            Name = name;
        }
    }
}
