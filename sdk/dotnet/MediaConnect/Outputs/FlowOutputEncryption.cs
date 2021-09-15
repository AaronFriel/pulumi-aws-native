// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.MediaConnect.Outputs
{

    /// <summary>
    /// Information about the encryption of the flow.
    /// </summary>
    [OutputType]
    public sealed class FlowOutputEncryption
    {
        /// <summary>
        /// The type of algorithm that is used for the encryption (such as aes128, aes192, or aes256).
        /// </summary>
        public readonly string Algorithm;
        /// <summary>
        /// The type of key that is used for the encryption. If no keyType is provided, the service will use the default setting (static-key).
        /// </summary>
        public readonly string? KeyType;
        /// <summary>
        /// The ARN of the role that you created during setup (when you set up AWS Elemental MediaConnect as a trusted entity).
        /// </summary>
        public readonly string RoleArn;
        /// <summary>
        ///  The ARN of the secret that you created in AWS Secrets Manager to store the encryption key. This parameter is required for static key encryption and is not valid for SPEKE encryption.
        /// </summary>
        public readonly string SecretArn;

        [OutputConstructor]
        private FlowOutputEncryption(
            string algorithm,

            string? keyType,

            string roleArn,

            string secretArn)
        {
            Algorithm = algorithm;
            KeyType = keyType;
            RoleArn = roleArn;
            SecretArn = secretArn;
        }
    }
}
