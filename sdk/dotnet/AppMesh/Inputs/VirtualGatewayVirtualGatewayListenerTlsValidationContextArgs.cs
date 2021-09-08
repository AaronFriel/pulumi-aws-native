// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.AppMesh.Inputs
{

    /// <summary>
    /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-virtualgateway-virtualgatewaylistenertlsvalidationcontext.html
    /// </summary>
    public sealed class VirtualGatewayVirtualGatewayListenerTlsValidationContextArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-virtualgateway-virtualgatewaylistenertlsvalidationcontext.html#cfn-appmesh-virtualgateway-virtualgatewaylistenertlsvalidationcontext-subjectalternativenames
        /// </summary>
        [Input("subjectAlternativeNames")]
        public Input<Inputs.VirtualGatewaySubjectAlternativeNamesArgs>? SubjectAlternativeNames { get; set; }

        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-virtualgateway-virtualgatewaylistenertlsvalidationcontext.html#cfn-appmesh-virtualgateway-virtualgatewaylistenertlsvalidationcontext-trust
        /// </summary>
        [Input("trust", required: true)]
        public Input<Inputs.VirtualGatewayVirtualGatewayListenerTlsValidationContextTrustArgs> Trust { get; set; } = null!;

        public VirtualGatewayVirtualGatewayListenerTlsValidationContextArgs()
        {
        }
    }
}