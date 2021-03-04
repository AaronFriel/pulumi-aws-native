// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.IoT.Outputs
{

    [OutputType]
    public sealed class CertificateProperties
    {
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iot-certificate.html#cfn-iot-certificate-cacertificatepem
        /// </summary>
        public readonly string? CACertificatePem;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iot-certificate.html#cfn-iot-certificate-certificatemode
        /// </summary>
        public readonly string? CertificateMode;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iot-certificate.html#cfn-iot-certificate-certificatepem
        /// </summary>
        public readonly string? CertificatePem;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iot-certificate.html#cfn-iot-certificate-certificatesigningrequest
        /// </summary>
        public readonly string? CertificateSigningRequest;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iot-certificate.html#cfn-iot-certificate-status
        /// </summary>
        public readonly string Status;

        [OutputConstructor]
        private CertificateProperties(
            string? CACertificatePem,

            string? CertificateMode,

            string? CertificatePem,

            string? CertificateSigningRequest,

            string Status)
        {
            this.CACertificatePem = CACertificatePem;
            this.CertificateMode = CertificateMode;
            this.CertificatePem = CertificatePem;
            this.CertificateSigningRequest = CertificateSigningRequest;
            this.Status = Status;
        }
    }
}
