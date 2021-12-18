// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.QuickSight.Outputs
{

    /// <summary>
    /// &lt;p&gt;The key or keys of the key-value pairs for the resource tag or tags assigned to the
    ///             resource.&lt;/p&gt;
    /// </summary>
    [OutputType]
    public sealed class DashboardTag
    {
        /// <summary>
        /// &lt;p&gt;Tag key.&lt;/p&gt;
        /// </summary>
        public readonly string Key;
        /// <summary>
        /// &lt;p&gt;Tag value.&lt;/p&gt;
        /// </summary>
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
