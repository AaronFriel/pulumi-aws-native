// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.NimbleStudio.Outputs
{

    [OutputType]
    public sealed class StreamingImageStreamingImageEncryptionConfiguration
    {
        public readonly string? KeyArn;
        public readonly string KeyType;

        [OutputConstructor]
        private StreamingImageStreamingImageEncryptionConfiguration(
            string? keyArn,

            string keyType)
        {
            KeyArn = keyArn;
            KeyType = keyType;
        }
    }
}
