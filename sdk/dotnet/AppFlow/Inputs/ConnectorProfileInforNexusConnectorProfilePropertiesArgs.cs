// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.AppFlow.Inputs
{

    public sealed class ConnectorProfileInforNexusConnectorProfilePropertiesArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The location of the InforNexus resource
        /// </summary>
        [Input("instanceUrl", required: true)]
        public Input<string> InstanceUrl { get; set; } = null!;

        public ConnectorProfileInforNexusConnectorProfilePropertiesArgs()
        {
        }
    }
}
