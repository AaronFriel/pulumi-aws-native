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
    public sealed class DatastoreIotSiteWiseMultiLayerStorage
    {
        public readonly Outputs.DatastoreCustomerManagedS3Storage? CustomerManagedS3Storage;

        [OutputConstructor]
        private DatastoreIotSiteWiseMultiLayerStorage(Outputs.DatastoreCustomerManagedS3Storage? customerManagedS3Storage)
        {
            CustomerManagedS3Storage = customerManagedS3Storage;
        }
    }
}
