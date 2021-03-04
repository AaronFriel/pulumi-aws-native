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
    /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-licensemanager-license-stringlist.html
    /// </summary>
    public sealed class LicenseStringListArgs : Pulumi.ResourceArgs
    {
        [Input("StringList")]
        private InputList<string>? _StringList;

        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-licensemanager-license-stringlist.html#cfn-licensemanager-license-stringlist-stringlist
        /// </summary>
        public InputList<string> StringList
        {
            get => _StringList ?? (_StringList = new InputList<string>());
            set => _StringList = value;
        }

        public LicenseStringListArgs()
        {
        }
    }
}
