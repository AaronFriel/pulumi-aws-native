// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.LicenseManager.Outputs
{

    [OutputType]
    public sealed class LicenseFilterList
    {
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-licensemanager-license-filterlist.html#cfn-licensemanager-license-filterlist-filterlist
        /// </summary>
        public readonly ImmutableArray<Outputs.LicenseFilter> FilterList;

        [OutputConstructor]
        private LicenseFilterList(ImmutableArray<Outputs.LicenseFilter> FilterList)
        {
            this.FilterList = FilterList;
        }
    }
}
