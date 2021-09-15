// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.CustomerProfiles.Outputs
{

    [OutputType]
    public sealed class IntegrationSalesforceSourceProperties
    {
        public readonly bool? EnableDynamicFieldUpdate;
        public readonly bool? IncludeDeletedRecords;
        public readonly string Object;

        [OutputConstructor]
        private IntegrationSalesforceSourceProperties(
            bool? enableDynamicFieldUpdate,

            bool? includeDeletedRecords,

            string @object)
        {
            EnableDynamicFieldUpdate = enableDynamicFieldUpdate;
            IncludeDeletedRecords = includeDeletedRecords;
            Object = @object;
        }
    }
}
