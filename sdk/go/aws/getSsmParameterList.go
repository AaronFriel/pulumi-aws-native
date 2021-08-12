// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package aws

import (
	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

func GetSsmParameterList(ctx *pulumi.Context, args *GetSsmParameterListArgs, opts ...pulumi.InvokeOption) (*GetSsmParameterListResult, error) {
	var rv GetSsmParameterListResult
	err := ctx.Invoke("aws-native:index:getSsmParameterList", args, &rv, opts...)
	if err != nil {
		return nil, err
	}
	return &rv, nil
}

type GetSsmParameterListArgs struct {
	Name string `pulumi:"name"`
}

type GetSsmParameterListResult struct {
	Value []string `pulumi:"value"`
}