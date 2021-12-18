// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package pinpoint

import (
	"fmt"

	"github.com/blang/semver"
	"github.com/pulumi/pulumi-aws-native/sdk/go/aws"
	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

type module struct {
	version semver.Version
}

func (m *module) Version() semver.Version {
	return m.version
}

func (m *module) Construct(ctx *pulumi.Context, name, typ, urn string) (r pulumi.Resource, err error) {
	switch typ {
	case "aws-native:pinpoint:ADMChannel":
		r = &ADMChannel{}
	case "aws-native:pinpoint:APNSChannel":
		r = &APNSChannel{}
	case "aws-native:pinpoint:APNSSandboxChannel":
		r = &APNSSandboxChannel{}
	case "aws-native:pinpoint:APNSVoipChannel":
		r = &APNSVoipChannel{}
	case "aws-native:pinpoint:APNSVoipSandboxChannel":
		r = &APNSVoipSandboxChannel{}
	case "aws-native:pinpoint:App":
		r = &App{}
	case "aws-native:pinpoint:ApplicationSettings":
		r = &ApplicationSettings{}
	case "aws-native:pinpoint:BaiduChannel":
		r = &BaiduChannel{}
	case "aws-native:pinpoint:Campaign":
		r = &Campaign{}
	case "aws-native:pinpoint:EmailChannel":
		r = &EmailChannel{}
	case "aws-native:pinpoint:EmailTemplate":
		r = &EmailTemplate{}
	case "aws-native:pinpoint:EventStream":
		r = &EventStream{}
	case "aws-native:pinpoint:GCMChannel":
		r = &GCMChannel{}
	case "aws-native:pinpoint:InAppTemplate":
		r = &InAppTemplate{}
	case "aws-native:pinpoint:PushTemplate":
		r = &PushTemplate{}
	case "aws-native:pinpoint:SMSChannel":
		r = &SMSChannel{}
	case "aws-native:pinpoint:Segment":
		r = &Segment{}
	case "aws-native:pinpoint:SmsTemplate":
		r = &SmsTemplate{}
	case "aws-native:pinpoint:VoiceChannel":
		r = &VoiceChannel{}
	default:
		return nil, fmt.Errorf("unknown resource type: %s", typ)
	}

	err = ctx.RegisterResource(typ, name, nil, r, pulumi.URN_(urn))
	return
}

func init() {
	version, err := aws.PkgVersion()
	if err != nil {
		fmt.Printf("failed to determine package version. defaulting to v1: %v\n", err)
	}
	pulumi.RegisterResourceModule(
		"aws-native",
		"pinpoint",
		&module{version},
	)
}
