// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.Kinesis.Inputs
{

    /// <summary>
    /// When specified, enables or updates server-side encryption using an AWS KMS key for a specified stream. Removing this property from your stack template and updating your stack disables encryption.
    /// </summary>
    public sealed class StreamStreamEncryptionArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The encryption type to use. The only valid value is KMS. 
        /// </summary>
        [Input("encryptionType", required: true)]
        public Input<string> EncryptionType { get; set; } = null!;

        /// <summary>
        /// The GUID for the customer-managed AWS KMS key to use for encryption. This value can be a globally unique identifier, a fully specified Amazon Resource Name (ARN) to either an alias or a key, or an alias name prefixed by "alias/".You can also use a master key owned by Kinesis Data Streams by specifying the alias aws/kinesis.
        /// </summary>
        [Input("keyId", required: true)]
        public Input<string> KeyId { get; set; } = null!;

        public StreamStreamEncryptionArgs()
        {
        }
    }
}
