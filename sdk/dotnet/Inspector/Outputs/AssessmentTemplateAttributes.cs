// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.Inspector.Outputs
{

    [OutputType]
    public sealed class AssessmentTemplateAttributes
    {
        public readonly string Arn;

        [OutputConstructor]
        private AssessmentTemplateAttributes(string Arn)
        {
            this.Arn = Arn;
        }
    }
}
