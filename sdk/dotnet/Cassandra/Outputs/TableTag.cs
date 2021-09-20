// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.Cassandra.Outputs
{

    /// <summary>
    /// A key-value pair to apply to the resource
    /// </summary>
    [OutputType]
    public sealed class TableTag
    {
        public readonly string Key;
        public readonly string Value;

        [OutputConstructor]
        private TableTag(
            string key,

            string value)
        {
            Key = key;
            Value = value;
        }
    }
}