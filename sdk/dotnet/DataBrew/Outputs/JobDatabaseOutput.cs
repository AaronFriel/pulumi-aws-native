// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.DataBrew.Outputs
{

    [OutputType]
    public sealed class JobDatabaseOutput
    {
        public readonly Outputs.JobDatabaseTableOutputOptions DatabaseOptions;
        /// <summary>
        /// Database table name
        /// </summary>
        public readonly string? DatabaseOutputMode;
        /// <summary>
        /// Glue connection name
        /// </summary>
        public readonly string GlueConnectionName;

        [OutputConstructor]
        private JobDatabaseOutput(
            Outputs.JobDatabaseTableOutputOptions databaseOptions,

            string? databaseOutputMode,

            string glueConnectionName)
        {
            DatabaseOptions = databaseOptions;
            DatabaseOutputMode = databaseOutputMode;
            GlueConnectionName = glueConnectionName;
        }
    }
}
