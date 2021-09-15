// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.Lambda.Outputs
{

    /// <summary>
    /// A destination for events that failed processing.
    /// </summary>
    [OutputType]
    public sealed class EventSourceMappingOnFailure
    {
        /// <summary>
        /// The Amazon Resource Name (ARN) of the destination resource.
        /// </summary>
        public readonly string? Destination;

        [OutputConstructor]
        private EventSourceMappingOnFailure(string? destination)
        {
            Destination = destination;
        }
    }
}
