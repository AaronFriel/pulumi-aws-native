// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.AppIntegrations.Outputs
{

    [OutputType]
    public sealed class EventIntegrationEventFilter
    {
        /// <summary>
        /// The source of the events.
        /// </summary>
        public readonly string Source;

        [OutputConstructor]
        private EventIntegrationEventFilter(string source)
        {
            Source = source;
        }
    }
}
