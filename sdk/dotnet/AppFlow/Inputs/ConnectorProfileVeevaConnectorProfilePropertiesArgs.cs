// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.AppFlow.Inputs
{

    public sealed class ConnectorProfileVeevaConnectorProfilePropertiesArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The location of the Veeva resource
        /// </summary>
        [Input("instanceUrl", required: true)]
        public Input<string> InstanceUrl { get; set; } = null!;

        public ConnectorProfileVeevaConnectorProfilePropertiesArgs()
        {
        }
    }
}
