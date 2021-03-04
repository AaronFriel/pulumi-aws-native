// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.ServiceCatalog.Outputs
{

    [OutputType]
    public sealed class PortfolioShareProperties
    {
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-servicecatalog-portfolioshare.html#cfn-servicecatalog-portfolioshare-acceptlanguage
        /// </summary>
        public readonly string? AcceptLanguage;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-servicecatalog-portfolioshare.html#cfn-servicecatalog-portfolioshare-accountid
        /// </summary>
        public readonly string AccountId;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-servicecatalog-portfolioshare.html#cfn-servicecatalog-portfolioshare-portfolioid
        /// </summary>
        public readonly string PortfolioId;

        [OutputConstructor]
        private PortfolioShareProperties(
            string? AcceptLanguage,

            string AccountId,

            string PortfolioId)
        {
            this.AcceptLanguage = AcceptLanguage;
            this.AccountId = AccountId;
            this.PortfolioId = PortfolioId;
        }
    }
}
