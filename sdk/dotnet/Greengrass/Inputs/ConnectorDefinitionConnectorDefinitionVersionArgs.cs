// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.Greengrass.Inputs
{

    public sealed class ConnectorDefinitionConnectorDefinitionVersionArgs : Pulumi.ResourceArgs
    {
        [Input("connectors", required: true)]
        private InputList<Inputs.ConnectorDefinitionConnectorArgs>? _connectors;
        public InputList<Inputs.ConnectorDefinitionConnectorArgs> Connectors
        {
            get => _connectors ?? (_connectors = new InputList<Inputs.ConnectorDefinitionConnectorArgs>());
            set => _connectors = value;
        }

        public ConnectorDefinitionConnectorDefinitionVersionArgs()
        {
        }
    }
}