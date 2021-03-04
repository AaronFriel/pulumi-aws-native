// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.KinesisAnalyticsV2.Inputs
{

    /// <summary>
    /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisanalyticsv2-application-environmentproperties.html
    /// </summary>
    public sealed class ApplicationEnvironmentPropertiesArgs : Pulumi.ResourceArgs
    {
        [Input("PropertyGroups")]
        private InputList<Inputs.ApplicationPropertyGroupArgs>? _PropertyGroups;

        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisanalyticsv2-application-environmentproperties.html#cfn-kinesisanalyticsv2-application-environmentproperties-propertygroups
        /// </summary>
        public InputList<Inputs.ApplicationPropertyGroupArgs> PropertyGroups
        {
            get => _PropertyGroups ?? (_PropertyGroups = new InputList<Inputs.ApplicationPropertyGroupArgs>());
            set => _PropertyGroups = value;
        }

        public ApplicationEnvironmentPropertiesArgs()
        {
        }
    }
}
