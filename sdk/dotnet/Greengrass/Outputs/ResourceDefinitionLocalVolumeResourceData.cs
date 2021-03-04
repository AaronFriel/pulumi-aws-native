// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.Greengrass.Outputs
{

    [OutputType]
    public sealed class ResourceDefinitionLocalVolumeResourceData
    {
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-greengrass-resourcedefinition-localvolumeresourcedata.html#cfn-greengrass-resourcedefinition-localvolumeresourcedata-destinationpath
        /// </summary>
        public readonly string DestinationPath;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-greengrass-resourcedefinition-localvolumeresourcedata.html#cfn-greengrass-resourcedefinition-localvolumeresourcedata-groupownersetting
        /// </summary>
        public readonly Outputs.ResourceDefinitionGroupOwnerSetting? GroupOwnerSetting;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-greengrass-resourcedefinition-localvolumeresourcedata.html#cfn-greengrass-resourcedefinition-localvolumeresourcedata-sourcepath
        /// </summary>
        public readonly string SourcePath;

        [OutputConstructor]
        private ResourceDefinitionLocalVolumeResourceData(
            string DestinationPath,

            Outputs.ResourceDefinitionGroupOwnerSetting? GroupOwnerSetting,

            string SourcePath)
        {
            this.DestinationPath = DestinationPath;
            this.GroupOwnerSetting = GroupOwnerSetting;
            this.SourcePath = SourcePath;
        }
    }
}
