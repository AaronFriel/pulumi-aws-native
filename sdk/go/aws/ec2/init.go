// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package ec2

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
	case "aws-native:EC2:CarrierGateway":
		r = &CarrierGateway{}
	case "aws-native:EC2:EC2Fleet":
		r = &EC2Fleet{}
	case "aws-native:EC2:FlowLog":
		r = &FlowLog{}
	case "aws-native:EC2:GatewayRouteTableAssociation":
		r = &GatewayRouteTableAssociation{}
	case "aws-native:EC2:LocalGatewayRoute":
		r = &LocalGatewayRoute{}
	case "aws-native:EC2:LocalGatewayRouteTableVPCAssociation":
		r = &LocalGatewayRouteTableVPCAssociation{}
	case "aws-native:EC2:NetworkInsightsAnalysis":
		r = &NetworkInsightsAnalysis{}
	case "aws-native:EC2:NetworkInsightsPath":
		r = &NetworkInsightsPath{}
	case "aws-native:EC2:PrefixList":
		r = &PrefixList{}
	case "aws-native:EC2:SpotFleet":
		r = &SpotFleet{}
	case "aws-native:EC2:TransitGateway":
		r = &TransitGateway{}
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
		"EC2",
		&module{version},
	)
}