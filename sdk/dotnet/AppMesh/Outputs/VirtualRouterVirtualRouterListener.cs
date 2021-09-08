// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.AppMesh.Outputs
{

    /// <summary>
    /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-virtualrouter-virtualrouterlistener.html
    /// </summary>
    [OutputType]
    public sealed class VirtualRouterVirtualRouterListener
    {
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-virtualrouter-virtualrouterlistener.html#cfn-appmesh-virtualrouter-virtualrouterlistener-portmapping
        /// </summary>
        public readonly Outputs.VirtualRouterPortMapping PortMapping;

        [OutputConstructor]
        private VirtualRouterVirtualRouterListener(Outputs.VirtualRouterPortMapping portMapping)
        {
            PortMapping = portMapping;
        }
    }
}