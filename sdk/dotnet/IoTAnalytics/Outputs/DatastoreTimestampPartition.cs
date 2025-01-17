// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.IoTAnalytics.Outputs
{

    [OutputType]
    public sealed class DatastoreTimestampPartition
    {
        public readonly string AttributeName;
        public readonly string? TimestampFormat;

        [OutputConstructor]
        private DatastoreTimestampPartition(
            string attributeName,

            string? timestampFormat)
        {
            AttributeName = attributeName;
            TimestampFormat = timestampFormat;
        }
    }
}
