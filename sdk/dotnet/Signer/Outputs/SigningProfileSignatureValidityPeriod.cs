// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.Signer.Outputs
{

    [OutputType]
    public sealed class SigningProfileSignatureValidityPeriod
    {
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-signer-signingprofile-signaturevalidityperiod.html#cfn-signer-signingprofile-signaturevalidityperiod-type
        /// </summary>
        public readonly string? Type;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-signer-signingprofile-signaturevalidityperiod.html#cfn-signer-signingprofile-signaturevalidityperiod-value
        /// </summary>
        public readonly int? Value;

        [OutputConstructor]
        private SigningProfileSignatureValidityPeriod(
            string? Type,

            int? Value)
        {
            this.Type = Type;
            this.Value = Value;
        }
    }
}
