// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.DocDB.Outputs
{

    [OutputType]
    public sealed class DBClusterParameterGroupTag
    {
        public readonly string Key;
        public readonly string Value;

        [OutputConstructor]
        private DBClusterParameterGroupTag(
            string key,

            string value)
        {
            Key = key;
            Value = value;
        }
    }
}
