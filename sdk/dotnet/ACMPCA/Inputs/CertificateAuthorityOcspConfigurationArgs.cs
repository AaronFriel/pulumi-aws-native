// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.ACMPCA.Inputs
{

    /// <summary>
    /// Helps to configure online certificate status protocol (OCSP) responder for your certificate authority
    /// </summary>
    public sealed class CertificateAuthorityOcspConfigurationArgs : Pulumi.ResourceArgs
    {
        [Input("enabled")]
        public Input<bool>? Enabled { get; set; }

        [Input("ocspCustomCname")]
        public Input<string>? OcspCustomCname { get; set; }

        public CertificateAuthorityOcspConfigurationArgs()
        {
        }
    }
}
