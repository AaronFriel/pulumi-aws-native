// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.ECS.Inputs
{

    public sealed class ServiceServiceRegistryArgs : Pulumi.ResourceArgs
    {
        [Input("containerName")]
        public Input<string>? ContainerName { get; set; }

        [Input("containerPort")]
        public Input<int>? ContainerPort { get; set; }

        [Input("port")]
        public Input<int>? Port { get; set; }

        [Input("registryArn")]
        public Input<string>? RegistryArn { get; set; }

        public ServiceServiceRegistryArgs()
        {
        }
    }
}
