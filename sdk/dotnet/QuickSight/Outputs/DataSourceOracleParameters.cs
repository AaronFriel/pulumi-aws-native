// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.QuickSight.Outputs
{

    [OutputType]
    public sealed class DataSourceOracleParameters
    {
        public readonly string Database;
        public readonly string Host;
        public readonly double Port;

        [OutputConstructor]
        private DataSourceOracleParameters(
            string database,

            string host,

            double port)
        {
            Database = database;
            Host = host;
            Port = port;
        }
    }
}
