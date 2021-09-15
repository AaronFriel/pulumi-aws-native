// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.IoTSiteWise.Outputs
{

    /// <summary>
    /// To add or update tag, provide both key and value. To delete tag, provide only tag key to be deleted
    /// </summary>
    [OutputType]
    public sealed class DashboardTag
    {
        public readonly string Key;
        public readonly string Value;

        [OutputConstructor]
        private DashboardTag(
            string key,

            string value)
        {
            Key = key;
            Value = value;
        }
    }
}
