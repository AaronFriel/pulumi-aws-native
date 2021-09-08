// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.Greengrass.Inputs
{

    /// <summary>
    /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-greengrass-resourcedefinition-secretsmanagersecretresourcedata.html
    /// </summary>
    public sealed class ResourceDefinitionSecretsManagerSecretResourceDataArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-greengrass-resourcedefinition-secretsmanagersecretresourcedata.html#cfn-greengrass-resourcedefinition-secretsmanagersecretresourcedata-arn
        /// </summary>
        [Input("aRN", required: true)]
        public Input<string> ARN { get; set; } = null!;

        [Input("additionalStagingLabelsToDownload")]
        private InputList<string>? _additionalStagingLabelsToDownload;

        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-greengrass-resourcedefinition-secretsmanagersecretresourcedata.html#cfn-greengrass-resourcedefinition-secretsmanagersecretresourcedata-additionalstaginglabelstodownload
        /// </summary>
        public InputList<string> AdditionalStagingLabelsToDownload
        {
            get => _additionalStagingLabelsToDownload ?? (_additionalStagingLabelsToDownload = new InputList<string>());
            set => _additionalStagingLabelsToDownload = value;
        }

        public ResourceDefinitionSecretsManagerSecretResourceDataArgs()
        {
        }
    }
}