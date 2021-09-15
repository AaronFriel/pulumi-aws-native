// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.Glue.Outputs
{

    /// <summary>
    /// Specify checkpoint version for update. This is only required to update the Compatibility.
    /// </summary>
    [OutputType]
    public sealed class SchemaSchemaVersion
    {
        /// <summary>
        /// Indicates if the latest version needs to be updated.
        /// </summary>
        public readonly bool? IsLatest;
        /// <summary>
        /// Indicates the version number in the schema to update.
        /// </summary>
        public readonly int? VersionNumber;

        [OutputConstructor]
        private SchemaSchemaVersion(
            bool? isLatest,

            int? versionNumber)
        {
            IsLatest = isLatest;
            VersionNumber = versionNumber;
        }
    }
}
