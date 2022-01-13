// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.EC2
{
    /// <summary>
    /// Associates an AWS Identity and Access Management (IAM) role with an AWS Certificate Manager (ACM) certificate. This association is based on Amazon Resource Names and it enables the certificate to be used by the ACM for Nitro Enclaves application inside an enclave.
    /// </summary>
    [AwsNativeResourceType("aws-native:ec2:EnclaveCertificateIamRoleAssociation")]
    public partial class EnclaveCertificateIamRoleAssociation : Pulumi.CustomResource
    {
        /// <summary>
        /// The Amazon Resource Name (ARN) of the ACM certificate with which to associate the IAM role.
        /// </summary>
        [Output("certificateArn")]
        public Output<string> CertificateArn { get; private set; } = null!;

        /// <summary>
        /// The name of the Amazon S3 bucket to which the certificate was uploaded.
        /// </summary>
        [Output("certificateS3BucketName")]
        public Output<string> CertificateS3BucketName { get; private set; } = null!;

        /// <summary>
        /// The Amazon S3 object key where the certificate, certificate chain, and encrypted private key bundle are stored.
        /// </summary>
        [Output("certificateS3ObjectKey")]
        public Output<string> CertificateS3ObjectKey { get; private set; } = null!;

        /// <summary>
        /// The ID of the AWS KMS CMK used to encrypt the private key of the certificate.
        /// </summary>
        [Output("encryptionKmsKeyId")]
        public Output<string> EncryptionKmsKeyId { get; private set; } = null!;

        /// <summary>
        /// The Amazon Resource Name (ARN) of the IAM role to associate with the ACM certificate. You can associate up to 16 IAM roles with an ACM certificate.
        /// </summary>
        [Output("roleArn")]
        public Output<string> RoleArn { get; private set; } = null!;


        /// <summary>
        /// Create a EnclaveCertificateIamRoleAssociation resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public EnclaveCertificateIamRoleAssociation(string name, EnclaveCertificateIamRoleAssociationArgs args, CustomResourceOptions? options = null)
            : base("aws-native:ec2:EnclaveCertificateIamRoleAssociation", name, args ?? new EnclaveCertificateIamRoleAssociationArgs(), MakeResourceOptions(options, ""))
        {
        }

        private EnclaveCertificateIamRoleAssociation(string name, Input<string> id, CustomResourceOptions? options = null)
            : base("aws-native:ec2:EnclaveCertificateIamRoleAssociation", name, null, MakeResourceOptions(options, id))
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
        /// Get an existing EnclaveCertificateIamRoleAssociation resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static EnclaveCertificateIamRoleAssociation Get(string name, Input<string> id, CustomResourceOptions? options = null)
        {
            return new EnclaveCertificateIamRoleAssociation(name, id, options);
        }
    }

    public sealed class EnclaveCertificateIamRoleAssociationArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The Amazon Resource Name (ARN) of the ACM certificate with which to associate the IAM role.
        /// </summary>
        [Input("certificateArn", required: true)]
        public Input<string> CertificateArn { get; set; } = null!;

        /// <summary>
        /// The Amazon Resource Name (ARN) of the IAM role to associate with the ACM certificate. You can associate up to 16 IAM roles with an ACM certificate.
        /// </summary>
        [Input("roleArn", required: true)]
        public Input<string> RoleArn { get; set; } = null!;

        public EnclaveCertificateIamRoleAssociationArgs()
        {
        }
    }
}
