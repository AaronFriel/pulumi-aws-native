// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.AppMesh.Inputs
{

    public sealed class VirtualGatewayListenerTlsFileCertificateArgs : Pulumi.ResourceArgs
    {
        [Input("certificateChain", required: true)]
        public Input<string> CertificateChain { get; set; } = null!;

        [Input("privateKey", required: true)]
        public Input<string> PrivateKey { get; set; } = null!;

        public VirtualGatewayListenerTlsFileCertificateArgs()
        {
        }
    }
}
