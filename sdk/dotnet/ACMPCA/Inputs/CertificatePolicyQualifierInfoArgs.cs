// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.ACMPCA.Inputs
{

    /// <summary>
    /// Structure that contains X.509 Policy qualifier information.
    /// </summary>
    public sealed class CertificatePolicyQualifierInfoArgs : Pulumi.ResourceArgs
    {
        [Input("policyQualifierId", required: true)]
        public Input<string> PolicyQualifierId { get; set; } = null!;

        [Input("qualifier", required: true)]
        public Input<Inputs.CertificateQualifierArgs> Qualifier { get; set; } = null!;

        public CertificatePolicyQualifierInfoArgs()
        {
        }
    }
}
