// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package iotwireless

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
	case "aws-native:iotwireless:Destination":
		r = &Destination{}
	case "aws-native:iotwireless:DeviceProfile":
		r = &DeviceProfile{}
	case "aws-native:iotwireless:PartnerAccount":
		r = &PartnerAccount{}
	case "aws-native:iotwireless:ServiceProfile":
		r = &ServiceProfile{}
	case "aws-native:iotwireless:TaskDefinition":
		r = &TaskDefinition{}
	case "aws-native:iotwireless:WirelessDevice":
		r = &WirelessDevice{}
	case "aws-native:iotwireless:WirelessGateway":
		r = &WirelessGateway{}
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
		"iotwireless",
		&module{version},
	)
}
