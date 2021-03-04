// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.S3.Inputs
{

    /// <summary>
    /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-sourceselectioncriteria.html
    /// </summary>
    public sealed class BucketSourceSelectionCriteriaArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-sourceselectioncriteria.html#cfn-s3-bucket-sourceselectioncriteria-replicamodifications
        /// </summary>
        [Input("ReplicaModifications")]
        public Input<Inputs.BucketReplicaModificationsArgs>? ReplicaModifications { get; set; }

        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-sourceselectioncriteria.html#cfn-s3-bucket-sourceselectioncriteria-ssekmsencryptedobjects
        /// </summary>
        [Input("SseKmsEncryptedObjects")]
        public Input<Inputs.BucketSseKmsEncryptedObjectsArgs>? SseKmsEncryptedObjects { get; set; }

        public BucketSourceSelectionCriteriaArgs()
        {
        }
    }
}
