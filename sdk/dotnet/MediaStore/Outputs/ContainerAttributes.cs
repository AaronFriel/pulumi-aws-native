// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.MediaStore.Outputs
{

    [OutputType]
    public sealed class ContainerAttributes
    {
        public readonly string Endpoint;

        [OutputConstructor]
        private ContainerAttributes(string Endpoint)
        {
            this.Endpoint = Endpoint;
        }
    }
}
