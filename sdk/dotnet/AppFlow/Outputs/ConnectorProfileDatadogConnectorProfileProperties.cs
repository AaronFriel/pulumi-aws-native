// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.AppFlow.Outputs
{

    [OutputType]
    public sealed class ConnectorProfileDatadogConnectorProfileProperties
    {
        /// <summary>
        /// The location of the Datadog resource
        /// </summary>
        public readonly string InstanceUrl;

        [OutputConstructor]
        private ConnectorProfileDatadogConnectorProfileProperties(string instanceUrl)
        {
            InstanceUrl = instanceUrl;
        }
    }
}
