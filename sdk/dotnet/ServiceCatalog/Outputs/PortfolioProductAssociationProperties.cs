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
    public sealed class PortfolioProductAssociationProperties
    {
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-servicecatalog-portfolioproductassociation.html#cfn-servicecatalog-portfolioproductassociation-acceptlanguage
        /// </summary>
        public readonly string? AcceptLanguage;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-servicecatalog-portfolioproductassociation.html#cfn-servicecatalog-portfolioproductassociation-portfolioid
        /// </summary>
        public readonly string PortfolioId;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-servicecatalog-portfolioproductassociation.html#cfn-servicecatalog-portfolioproductassociation-productid
        /// </summary>
        public readonly string ProductId;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-servicecatalog-portfolioproductassociation.html#cfn-servicecatalog-portfolioproductassociation-sourceportfolioid
        /// </summary>
        public readonly string? SourcePortfolioId;

        [OutputConstructor]
        private PortfolioProductAssociationProperties(
            string? AcceptLanguage,

            string PortfolioId,

            string ProductId,

            string? SourcePortfolioId)
        {
            this.AcceptLanguage = AcceptLanguage;
            this.PortfolioId = PortfolioId;
            this.ProductId = ProductId;
            this.SourcePortfolioId = SourcePortfolioId;
        }
    }
}
