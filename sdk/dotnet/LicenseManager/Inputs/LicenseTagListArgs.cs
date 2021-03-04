// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.LicenseManager.Inputs
{

    /// <summary>
    /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-licensemanager-license-taglist.html
    /// </summary>
    public sealed class LicenseTagListArgs : Pulumi.ResourceArgs
    {
        [Input("TagList")]
        private InputList<Pulumi.AwsNative.Inputs.TagArgs>? _TagList;

        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-licensemanager-license-taglist.html#cfn-licensemanager-license-taglist-taglist
        /// </summary>
        public InputList<Pulumi.AwsNative.Inputs.TagArgs> TagList
        {
            get => _TagList ?? (_TagList = new InputList<Pulumi.AwsNative.Inputs.TagArgs>());
            set => _TagList = value;
        }

        public LicenseTagListArgs()
        {
        }
    }
}
