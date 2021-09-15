// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.AppFlow.Outputs
{

    /// <summary>
    /// An object used to store task related info
    /// </summary>
    [OutputType]
    public sealed class FlowTaskPropertiesObject
    {
        public readonly string Key;
        public readonly string Value;

        [OutputConstructor]
        private FlowTaskPropertiesObject(
            string key,

            string value)
        {
            Key = key;
            Value = value;
        }
    }
}
