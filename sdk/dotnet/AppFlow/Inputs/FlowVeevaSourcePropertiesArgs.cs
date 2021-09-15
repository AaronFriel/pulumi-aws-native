// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.AppFlow.Inputs
{

    public sealed class FlowVeevaSourcePropertiesArgs : Pulumi.ResourceArgs
    {
        [Input("documentType")]
        public Input<string>? DocumentType { get; set; }

        [Input("includeAllVersions")]
        public Input<bool>? IncludeAllVersions { get; set; }

        [Input("includeRenditions")]
        public Input<bool>? IncludeRenditions { get; set; }

        [Input("includeSourceFiles")]
        public Input<bool>? IncludeSourceFiles { get; set; }

        [Input("object", required: true)]
        public Input<string> Object { get; set; } = null!;

        public FlowVeevaSourcePropertiesArgs()
        {
        }
    }
}
