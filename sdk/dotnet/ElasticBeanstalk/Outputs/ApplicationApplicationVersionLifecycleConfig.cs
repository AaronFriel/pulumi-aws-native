// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.ElasticBeanstalk.Outputs
{

    [OutputType]
    public sealed class ApplicationApplicationVersionLifecycleConfig
    {
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticbeanstalk-application-applicationversionlifecycleconfig.html#cfn-elasticbeanstalk-application-applicationversionlifecycleconfig-maxagerule
        /// </summary>
        public readonly Outputs.ApplicationMaxAgeRule? MaxAgeRule;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticbeanstalk-application-applicationversionlifecycleconfig.html#cfn-elasticbeanstalk-application-applicationversionlifecycleconfig-maxcountrule
        /// </summary>
        public readonly Outputs.ApplicationMaxCountRule? MaxCountRule;

        [OutputConstructor]
        private ApplicationApplicationVersionLifecycleConfig(
            Outputs.ApplicationMaxAgeRule? MaxAgeRule,

            Outputs.ApplicationMaxCountRule? MaxCountRule)
        {
            this.MaxAgeRule = MaxAgeRule;
            this.MaxCountRule = MaxCountRule;
        }
    }
}
