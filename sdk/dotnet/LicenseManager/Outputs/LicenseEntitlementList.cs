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
    public sealed class LicenseEntitlementList
    {
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-licensemanager-license-entitlementlist.html#cfn-licensemanager-license-entitlementlist-entitlementlist
        /// </summary>
        public readonly ImmutableArray<Outputs.LicenseEntitlement> EntitlementList;

        [OutputConstructor]
        private LicenseEntitlementList(ImmutableArray<Outputs.LicenseEntitlement> EntitlementList)
        {
            this.EntitlementList = EntitlementList;
        }
    }
}
