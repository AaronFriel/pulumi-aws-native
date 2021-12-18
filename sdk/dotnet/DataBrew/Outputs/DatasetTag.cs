// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.DataBrew.Outputs
{

    /// <summary>
    /// A key-value pair to associate with a resource.
    /// </summary>
    [OutputType]
    public sealed class DatasetTag
    {
        public readonly string Key;
        public readonly string Value;

        [OutputConstructor]
        private DatasetTag(
            string key,

            string value)
        {
            Key = key;
            Value = value;
        }
    }
}
