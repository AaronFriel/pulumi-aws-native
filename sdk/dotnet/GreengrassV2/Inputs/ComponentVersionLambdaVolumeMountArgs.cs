// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.GreengrassV2.Inputs
{

    public sealed class ComponentVersionLambdaVolumeMountArgs : Pulumi.ResourceArgs
    {
        [Input("addGroupOwner")]
        public Input<bool>? AddGroupOwner { get; set; }

        [Input("destinationPath")]
        public Input<string>? DestinationPath { get; set; }

        [Input("permission")]
        public Input<Pulumi.AwsNative.GreengrassV2.ComponentVersionLambdaFilesystemPermission>? Permission { get; set; }

        [Input("sourcePath")]
        public Input<string>? SourcePath { get; set; }

        public ComponentVersionLambdaVolumeMountArgs()
        {
        }
    }
}
