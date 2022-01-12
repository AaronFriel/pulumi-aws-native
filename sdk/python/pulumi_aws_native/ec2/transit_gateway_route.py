# coding=utf-8
# *** WARNING: this file was generated by the Pulumi SDK Generator. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import warnings
import pulumi
import pulumi.runtime
from typing import Any, Mapping, Optional, Sequence, Union, overload
from .. import _utilities

__all__ = ['TransitGatewayRouteArgs', 'TransitGatewayRoute']

@pulumi.input_type
class TransitGatewayRouteArgs:
    def __init__(__self__, *,
                 transit_gateway_route_table_id: pulumi.Input[str],
                 blackhole: Optional[pulumi.Input[bool]] = None,
                 destination_cidr_block: Optional[pulumi.Input[str]] = None,
                 transit_gateway_attachment_id: Optional[pulumi.Input[str]] = None):
        """
        The set of arguments for constructing a TransitGatewayRoute resource.
        """
        pulumi.set(__self__, "transit_gateway_route_table_id", transit_gateway_route_table_id)
        if blackhole is not None:
            pulumi.set(__self__, "blackhole", blackhole)
        if destination_cidr_block is not None:
            pulumi.set(__self__, "destination_cidr_block", destination_cidr_block)
        if transit_gateway_attachment_id is not None:
            pulumi.set(__self__, "transit_gateway_attachment_id", transit_gateway_attachment_id)

    @property
    @pulumi.getter(name="transitGatewayRouteTableId")
    def transit_gateway_route_table_id(self) -> pulumi.Input[str]:
        return pulumi.get(self, "transit_gateway_route_table_id")

    @transit_gateway_route_table_id.setter
    def transit_gateway_route_table_id(self, value: pulumi.Input[str]):
        pulumi.set(self, "transit_gateway_route_table_id", value)

    @property
    @pulumi.getter
    def blackhole(self) -> Optional[pulumi.Input[bool]]:
        return pulumi.get(self, "blackhole")

    @blackhole.setter
    def blackhole(self, value: Optional[pulumi.Input[bool]]):
        pulumi.set(self, "blackhole", value)

    @property
    @pulumi.getter(name="destinationCidrBlock")
    def destination_cidr_block(self) -> Optional[pulumi.Input[str]]:
        return pulumi.get(self, "destination_cidr_block")

    @destination_cidr_block.setter
    def destination_cidr_block(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "destination_cidr_block", value)

    @property
    @pulumi.getter(name="transitGatewayAttachmentId")
    def transit_gateway_attachment_id(self) -> Optional[pulumi.Input[str]]:
        return pulumi.get(self, "transit_gateway_attachment_id")

    @transit_gateway_attachment_id.setter
    def transit_gateway_attachment_id(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "transit_gateway_attachment_id", value)


warnings.warn("""TransitGatewayRoute is not yet supported by AWS Native, so its creation will currently fail. Please use the classic AWS provider, if possible.""", DeprecationWarning)


class TransitGatewayRoute(pulumi.CustomResource):
    warnings.warn("""TransitGatewayRoute is not yet supported by AWS Native, so its creation will currently fail. Please use the classic AWS provider, if possible.""", DeprecationWarning)

    @overload
    def __init__(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 blackhole: Optional[pulumi.Input[bool]] = None,
                 destination_cidr_block: Optional[pulumi.Input[str]] = None,
                 transit_gateway_attachment_id: Optional[pulumi.Input[str]] = None,
                 transit_gateway_route_table_id: Optional[pulumi.Input[str]] = None,
                 __props__=None):
        """
        Resource Type definition for AWS::EC2::TransitGatewayRoute

        :param str resource_name: The name of the resource.
        :param pulumi.ResourceOptions opts: Options for the resource.
        """
        ...
    @overload
    def __init__(__self__,
                 resource_name: str,
                 args: TransitGatewayRouteArgs,
                 opts: Optional[pulumi.ResourceOptions] = None):
        """
        Resource Type definition for AWS::EC2::TransitGatewayRoute

        :param str resource_name: The name of the resource.
        :param TransitGatewayRouteArgs args: The arguments to use to populate this resource's properties.
        :param pulumi.ResourceOptions opts: Options for the resource.
        """
        ...
    def __init__(__self__, resource_name: str, *args, **kwargs):
        resource_args, opts = _utilities.get_resource_args_opts(TransitGatewayRouteArgs, pulumi.ResourceOptions, *args, **kwargs)
        if resource_args is not None:
            __self__._internal_init(resource_name, opts, **resource_args.__dict__)
        else:
            __self__._internal_init(resource_name, *args, **kwargs)

    def _internal_init(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 blackhole: Optional[pulumi.Input[bool]] = None,
                 destination_cidr_block: Optional[pulumi.Input[str]] = None,
                 transit_gateway_attachment_id: Optional[pulumi.Input[str]] = None,
                 transit_gateway_route_table_id: Optional[pulumi.Input[str]] = None,
                 __props__=None):
        pulumi.log.warn("""TransitGatewayRoute is deprecated: TransitGatewayRoute is not yet supported by AWS Native, so its creation will currently fail. Please use the classic AWS provider, if possible.""")
        if opts is None:
            opts = pulumi.ResourceOptions()
        if not isinstance(opts, pulumi.ResourceOptions):
            raise TypeError('Expected resource options to be a ResourceOptions instance')
        if opts.version is None:
            opts.version = _utilities.get_version()
        if opts.id is None:
            if __props__ is not None:
                raise TypeError('__props__ is only valid when passed in combination with a valid opts.id to get an existing resource')
            __props__ = TransitGatewayRouteArgs.__new__(TransitGatewayRouteArgs)

            __props__.__dict__["blackhole"] = blackhole
            __props__.__dict__["destination_cidr_block"] = destination_cidr_block
            __props__.__dict__["transit_gateway_attachment_id"] = transit_gateway_attachment_id
            if transit_gateway_route_table_id is None and not opts.urn:
                raise TypeError("Missing required property 'transit_gateway_route_table_id'")
            __props__.__dict__["transit_gateway_route_table_id"] = transit_gateway_route_table_id
        super(TransitGatewayRoute, __self__).__init__(
            'aws-native:ec2:TransitGatewayRoute',
            resource_name,
            __props__,
            opts)

    @staticmethod
    def get(resource_name: str,
            id: pulumi.Input[str],
            opts: Optional[pulumi.ResourceOptions] = None) -> 'TransitGatewayRoute':
        """
        Get an existing TransitGatewayRoute resource's state with the given name, id, and optional extra
        properties used to qualify the lookup.

        :param str resource_name: The unique name of the resulting resource.
        :param pulumi.Input[str] id: The unique provider ID of the resource to lookup.
        :param pulumi.ResourceOptions opts: Options for the resource.
        """
        opts = pulumi.ResourceOptions.merge(opts, pulumi.ResourceOptions(id=id))

        __props__ = TransitGatewayRouteArgs.__new__(TransitGatewayRouteArgs)

        __props__.__dict__["blackhole"] = None
        __props__.__dict__["destination_cidr_block"] = None
        __props__.__dict__["transit_gateway_attachment_id"] = None
        __props__.__dict__["transit_gateway_route_table_id"] = None
        return TransitGatewayRoute(resource_name, opts=opts, __props__=__props__)

    @property
    @pulumi.getter
    def blackhole(self) -> pulumi.Output[Optional[bool]]:
        return pulumi.get(self, "blackhole")

    @property
    @pulumi.getter(name="destinationCidrBlock")
    def destination_cidr_block(self) -> pulumi.Output[Optional[str]]:
        return pulumi.get(self, "destination_cidr_block")

    @property
    @pulumi.getter(name="transitGatewayAttachmentId")
    def transit_gateway_attachment_id(self) -> pulumi.Output[Optional[str]]:
        return pulumi.get(self, "transit_gateway_attachment_id")

    @property
    @pulumi.getter(name="transitGatewayRouteTableId")
    def transit_gateway_route_table_id(self) -> pulumi.Output[str]:
        return pulumi.get(self, "transit_gateway_route_table_id")

