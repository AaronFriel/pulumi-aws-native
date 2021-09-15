// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.IoT
{
    /// <summary>
    /// Use the AWS::IoT::Certificate resource to declare an AWS IoT X.509 certificate.
    /// </summary>
    [AwsNativeResourceType("aws-native:iot:Certificate")]
    public partial class Certificate : Pulumi.CustomResource
    {
        [Output("arn")]
        public Output<string> Arn { get; private set; } = null!;

        [Output("cACertificatePem")]
        public Output<string?> CACertificatePem { get; private set; } = null!;

        [Output("certificateMode")]
        public Output<string?> CertificateMode { get; private set; } = null!;

        [Output("certificatePem")]
        public Output<string?> CertificatePem { get; private set; } = null!;

        [Output("certificateSigningRequest")]
        public Output<string?> CertificateSigningRequest { get; private set; } = null!;

        [Output("status")]
        public Output<string> Status { get; private set; } = null!;


        /// <summary>
        /// Create a Certificate resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public Certificate(string name, CertificateArgs args, CustomResourceOptions? options = null)
            : base("aws-native:iot:Certificate", name, args ?? new CertificateArgs(), MakeResourceOptions(options, ""))
        {
        }

        private Certificate(string name, Input<string> id, CustomResourceOptions? options = null)
            : base("aws-native:iot:Certificate", name, null, MakeResourceOptions(options, id))
        {
        }

        private static CustomResourceOptions MakeResourceOptions(CustomResourceOptions? options, Input<string>? id)
        {
            var defaultOptions = new CustomResourceOptions
            {
                Version = Utilities.Version,
            };
            var merged = CustomResourceOptions.Merge(defaultOptions, options);
            // Override the ID if one was specified for consistency with other language SDKs.
            merged.Id = id ?? merged.Id;
            return merged;
        }
        /// <summary>
        /// Get an existing Certificate resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static Certificate Get(string name, Input<string> id, CustomResourceOptions? options = null)
        {
            return new Certificate(name, id, options);
        }
    }

    public sealed class CertificateArgs : Pulumi.ResourceArgs
    {
        [Input("cACertificatePem")]
        public Input<string>? CACertificatePem { get; set; }

        [Input("certificateMode")]
        public Input<string>? CertificateMode { get; set; }

        [Input("certificatePem")]
        public Input<string>? CertificatePem { get; set; }

        [Input("certificateSigningRequest")]
        public Input<string>? CertificateSigningRequest { get; set; }

        [Input("status", required: true)]
        public Input<string> Status { get; set; } = null!;

        public CertificateArgs()
        {
        }
    }
}
