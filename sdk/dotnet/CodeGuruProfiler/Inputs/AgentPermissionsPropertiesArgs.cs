// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.CodeGuruProfiler.Inputs
{

    /// <summary>
    /// The agent permissions attached to this profiling group.
    /// </summary>
    public sealed class AgentPermissionsPropertiesArgs : Pulumi.ResourceArgs
    {
        [Input("principals", required: true)]
        private InputList<string>? _principals;

        /// <summary>
        /// The principals for the agent permissions.
        /// </summary>
        public InputList<string> Principals
        {
            get => _principals ?? (_principals = new InputList<string>());
            set => _principals = value;
        }

        public AgentPermissionsPropertiesArgs()
        {
        }
    }
}