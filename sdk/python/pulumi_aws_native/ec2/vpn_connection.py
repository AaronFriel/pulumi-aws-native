# coding=utf-8
# *** WARNING: this file was generated by pulumigen. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import warnings
import pulumi
import pulumi.runtime
from typing import Any, Mapping, Optional, Sequence, Union, overload
from .. import _utilities
from . import outputs
from .. import _inputs as _root_inputs
from .. import outputs as _root_outputs
from ._inputs import *

__all__ = ['VPNConnectionArgs', 'VPNConnection']

@pulumi.input_type
class VPNConnectionArgs:
    def __init__(__self__, *,
                 customer_gateway_id: pulumi.Input[str],
                 type: pulumi.Input[str],
                 static_routes_only: Optional[pulumi.Input[bool]] = None,
                 tags: Optional[pulumi.Input[Sequence[pulumi.Input['_root_inputs.TagArgs']]]] = None,
                 transit_gateway_id: Optional[pulumi.Input[str]] = None,
                 vpn_gateway_id: Optional[pulumi.Input[str]] = None,
                 vpn_tunnel_options_specifications: Optional[pulumi.Input[Sequence[pulumi.Input['VPNConnectionVpnTunnelOptionsSpecificationArgs']]]] = None):
        """
        The set of arguments for constructing a VPNConnection resource.
        :param pulumi.Input[str] customer_gateway_id: http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-vpn-connection.html#cfn-ec2-vpnconnection-customergatewayid
        :param pulumi.Input[str] type: http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-vpn-connection.html#cfn-ec2-vpnconnection-type
        :param pulumi.Input[bool] static_routes_only: http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-vpn-connection.html#cfn-ec2-vpnconnection-StaticRoutesOnly
        :param pulumi.Input[Sequence[pulumi.Input['_root_inputs.TagArgs']]] tags: http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-vpn-connection.html#cfn-ec2-vpnconnection-tags
        :param pulumi.Input[str] transit_gateway_id: http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-vpn-connection.html#cfn-ec2-vpnconnection-transitgatewayid
        :param pulumi.Input[str] vpn_gateway_id: http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-vpn-connection.html#cfn-ec2-vpnconnection-vpngatewayid
        :param pulumi.Input[Sequence[pulumi.Input['VPNConnectionVpnTunnelOptionsSpecificationArgs']]] vpn_tunnel_options_specifications: http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-vpn-connection.html#cfn-ec2-vpnconnection-vpntunneloptionsspecifications
        """
        pulumi.set(__self__, "customer_gateway_id", customer_gateway_id)
        pulumi.set(__self__, "type", type)
        if static_routes_only is not None:
            pulumi.set(__self__, "static_routes_only", static_routes_only)
        if tags is not None:
            pulumi.set(__self__, "tags", tags)
        if transit_gateway_id is not None:
            pulumi.set(__self__, "transit_gateway_id", transit_gateway_id)
        if vpn_gateway_id is not None:
            pulumi.set(__self__, "vpn_gateway_id", vpn_gateway_id)
        if vpn_tunnel_options_specifications is not None:
            pulumi.set(__self__, "vpn_tunnel_options_specifications", vpn_tunnel_options_specifications)

    @property
    @pulumi.getter(name="customerGatewayId")
    def customer_gateway_id(self) -> pulumi.Input[str]:
        """
        http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-vpn-connection.html#cfn-ec2-vpnconnection-customergatewayid
        """
        return pulumi.get(self, "customer_gateway_id")

    @customer_gateway_id.setter
    def customer_gateway_id(self, value: pulumi.Input[str]):
        pulumi.set(self, "customer_gateway_id", value)

    @property
    @pulumi.getter
    def type(self) -> pulumi.Input[str]:
        """
        http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-vpn-connection.html#cfn-ec2-vpnconnection-type
        """
        return pulumi.get(self, "type")

    @type.setter
    def type(self, value: pulumi.Input[str]):
        pulumi.set(self, "type", value)

    @property
    @pulumi.getter(name="staticRoutesOnly")
    def static_routes_only(self) -> Optional[pulumi.Input[bool]]:
        """
        http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-vpn-connection.html#cfn-ec2-vpnconnection-StaticRoutesOnly
        """
        return pulumi.get(self, "static_routes_only")

    @static_routes_only.setter
    def static_routes_only(self, value: Optional[pulumi.Input[bool]]):
        pulumi.set(self, "static_routes_only", value)

    @property
    @pulumi.getter
    def tags(self) -> Optional[pulumi.Input[Sequence[pulumi.Input['_root_inputs.TagArgs']]]]:
        """
        http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-vpn-connection.html#cfn-ec2-vpnconnection-tags
        """
        return pulumi.get(self, "tags")

    @tags.setter
    def tags(self, value: Optional[pulumi.Input[Sequence[pulumi.Input['_root_inputs.TagArgs']]]]):
        pulumi.set(self, "tags", value)

    @property
    @pulumi.getter(name="transitGatewayId")
    def transit_gateway_id(self) -> Optional[pulumi.Input[str]]:
        """
        http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-vpn-connection.html#cfn-ec2-vpnconnection-transitgatewayid
        """
        return pulumi.get(self, "transit_gateway_id")

    @transit_gateway_id.setter
    def transit_gateway_id(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "transit_gateway_id", value)

    @property
    @pulumi.getter(name="vpnGatewayId")
    def vpn_gateway_id(self) -> Optional[pulumi.Input[str]]:
        """
        http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-vpn-connection.html#cfn-ec2-vpnconnection-vpngatewayid
        """
        return pulumi.get(self, "vpn_gateway_id")

    @vpn_gateway_id.setter
    def vpn_gateway_id(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "vpn_gateway_id", value)

    @property
    @pulumi.getter(name="vpnTunnelOptionsSpecifications")
    def vpn_tunnel_options_specifications(self) -> Optional[pulumi.Input[Sequence[pulumi.Input['VPNConnectionVpnTunnelOptionsSpecificationArgs']]]]:
        """
        http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-vpn-connection.html#cfn-ec2-vpnconnection-vpntunneloptionsspecifications
        """
        return pulumi.get(self, "vpn_tunnel_options_specifications")

    @vpn_tunnel_options_specifications.setter
    def vpn_tunnel_options_specifications(self, value: Optional[pulumi.Input[Sequence[pulumi.Input['VPNConnectionVpnTunnelOptionsSpecificationArgs']]]]):
        pulumi.set(self, "vpn_tunnel_options_specifications", value)


class VPNConnection(pulumi.CustomResource):
    @overload
    def __init__(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 customer_gateway_id: Optional[pulumi.Input[str]] = None,
                 static_routes_only: Optional[pulumi.Input[bool]] = None,
                 tags: Optional[pulumi.Input[Sequence[pulumi.Input[pulumi.InputType['_root_inputs.TagArgs']]]]] = None,
                 transit_gateway_id: Optional[pulumi.Input[str]] = None,
                 type: Optional[pulumi.Input[str]] = None,
                 vpn_gateway_id: Optional[pulumi.Input[str]] = None,
                 vpn_tunnel_options_specifications: Optional[pulumi.Input[Sequence[pulumi.Input[pulumi.InputType['VPNConnectionVpnTunnelOptionsSpecificationArgs']]]]] = None,
                 __props__=None):
        """
        http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-vpn-connection.html

        :param str resource_name: The name of the resource.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[str] customer_gateway_id: http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-vpn-connection.html#cfn-ec2-vpnconnection-customergatewayid
        :param pulumi.Input[bool] static_routes_only: http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-vpn-connection.html#cfn-ec2-vpnconnection-StaticRoutesOnly
        :param pulumi.Input[Sequence[pulumi.Input[pulumi.InputType['_root_inputs.TagArgs']]]] tags: http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-vpn-connection.html#cfn-ec2-vpnconnection-tags
        :param pulumi.Input[str] transit_gateway_id: http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-vpn-connection.html#cfn-ec2-vpnconnection-transitgatewayid
        :param pulumi.Input[str] type: http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-vpn-connection.html#cfn-ec2-vpnconnection-type
        :param pulumi.Input[str] vpn_gateway_id: http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-vpn-connection.html#cfn-ec2-vpnconnection-vpngatewayid
        :param pulumi.Input[Sequence[pulumi.Input[pulumi.InputType['VPNConnectionVpnTunnelOptionsSpecificationArgs']]]] vpn_tunnel_options_specifications: http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-vpn-connection.html#cfn-ec2-vpnconnection-vpntunneloptionsspecifications
        """
        ...
    @overload
    def __init__(__self__,
                 resource_name: str,
                 args: VPNConnectionArgs,
                 opts: Optional[pulumi.ResourceOptions] = None):
        """
        http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-vpn-connection.html

        :param str resource_name: The name of the resource.
        :param VPNConnectionArgs args: The arguments to use to populate this resource's properties.
        :param pulumi.ResourceOptions opts: Options for the resource.
        """
        ...
    def __init__(__self__, resource_name: str, *args, **kwargs):
        resource_args, opts = _utilities.get_resource_args_opts(VPNConnectionArgs, pulumi.ResourceOptions, *args, **kwargs)
        if resource_args is not None:
            __self__._internal_init(resource_name, opts, **resource_args.__dict__)
        else:
            __self__._internal_init(resource_name, *args, **kwargs)

    def _internal_init(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 customer_gateway_id: Optional[pulumi.Input[str]] = None,
                 static_routes_only: Optional[pulumi.Input[bool]] = None,
                 tags: Optional[pulumi.Input[Sequence[pulumi.Input[pulumi.InputType['_root_inputs.TagArgs']]]]] = None,
                 transit_gateway_id: Optional[pulumi.Input[str]] = None,
                 type: Optional[pulumi.Input[str]] = None,
                 vpn_gateway_id: Optional[pulumi.Input[str]] = None,
                 vpn_tunnel_options_specifications: Optional[pulumi.Input[Sequence[pulumi.Input[pulumi.InputType['VPNConnectionVpnTunnelOptionsSpecificationArgs']]]]] = None,
                 __props__=None):
        if opts is None:
            opts = pulumi.ResourceOptions()
        if not isinstance(opts, pulumi.ResourceOptions):
            raise TypeError('Expected resource options to be a ResourceOptions instance')
        if opts.version is None:
            opts.version = _utilities.get_version()
        if opts.id is None:
            if __props__ is not None:
                raise TypeError('__props__ is only valid when passed in combination with a valid opts.id to get an existing resource')
            __props__ = VPNConnectionArgs.__new__(VPNConnectionArgs)

            if customer_gateway_id is None and not opts.urn:
                raise TypeError("Missing required property 'customer_gateway_id'")
            __props__.__dict__["customer_gateway_id"] = customer_gateway_id
            __props__.__dict__["static_routes_only"] = static_routes_only
            __props__.__dict__["tags"] = tags
            __props__.__dict__["transit_gateway_id"] = transit_gateway_id
            if type is None and not opts.urn:
                raise TypeError("Missing required property 'type'")
            __props__.__dict__["type"] = type
            __props__.__dict__["vpn_gateway_id"] = vpn_gateway_id
            __props__.__dict__["vpn_tunnel_options_specifications"] = vpn_tunnel_options_specifications
        super(VPNConnection, __self__).__init__(
            'aws-native:ec2:VPNConnection',
            resource_name,
            __props__,
            opts)

    @staticmethod
    def get(resource_name: str,
            id: pulumi.Input[str],
            opts: Optional[pulumi.ResourceOptions] = None) -> 'VPNConnection':
        """
        Get an existing VPNConnection resource's state with the given name, id, and optional extra
        properties used to qualify the lookup.

        :param str resource_name: The unique name of the resulting resource.
        :param pulumi.Input[str] id: The unique provider ID of the resource to lookup.
        :param pulumi.ResourceOptions opts: Options for the resource.
        """
        opts = pulumi.ResourceOptions.merge(opts, pulumi.ResourceOptions(id=id))

        __props__ = VPNConnectionArgs.__new__(VPNConnectionArgs)

        __props__.__dict__["customer_gateway_id"] = None
        __props__.__dict__["static_routes_only"] = None
        __props__.__dict__["tags"] = None
        __props__.__dict__["transit_gateway_id"] = None
        __props__.__dict__["type"] = None
        __props__.__dict__["vpn_gateway_id"] = None
        __props__.__dict__["vpn_tunnel_options_specifications"] = None
        return VPNConnection(resource_name, opts=opts, __props__=__props__)

    @property
    @pulumi.getter(name="customerGatewayId")
    def customer_gateway_id(self) -> pulumi.Output[str]:
        """
        http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-vpn-connection.html#cfn-ec2-vpnconnection-customergatewayid
        """
        return pulumi.get(self, "customer_gateway_id")

    @property
    @pulumi.getter(name="staticRoutesOnly")
    def static_routes_only(self) -> pulumi.Output[Optional[bool]]:
        """
        http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-vpn-connection.html#cfn-ec2-vpnconnection-StaticRoutesOnly
        """
        return pulumi.get(self, "static_routes_only")

    @property
    @pulumi.getter
    def tags(self) -> pulumi.Output[Optional[Sequence['_root_outputs.Tag']]]:
        """
        http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-vpn-connection.html#cfn-ec2-vpnconnection-tags
        """
        return pulumi.get(self, "tags")

    @property
    @pulumi.getter(name="transitGatewayId")
    def transit_gateway_id(self) -> pulumi.Output[Optional[str]]:
        """
        http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-vpn-connection.html#cfn-ec2-vpnconnection-transitgatewayid
        """
        return pulumi.get(self, "transit_gateway_id")

    @property
    @pulumi.getter
    def type(self) -> pulumi.Output[str]:
        """
        http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-vpn-connection.html#cfn-ec2-vpnconnection-type
        """
        return pulumi.get(self, "type")

    @property
    @pulumi.getter(name="vpnGatewayId")
    def vpn_gateway_id(self) -> pulumi.Output[Optional[str]]:
        """
        http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-vpn-connection.html#cfn-ec2-vpnconnection-vpngatewayid
        """
        return pulumi.get(self, "vpn_gateway_id")

    @property
    @pulumi.getter(name="vpnTunnelOptionsSpecifications")
    def vpn_tunnel_options_specifications(self) -> pulumi.Output[Optional[Sequence['outputs.VPNConnectionVpnTunnelOptionsSpecification']]]:
        """
        http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-vpn-connection.html#cfn-ec2-vpnconnection-vpntunneloptionsspecifications
        """
        return pulumi.get(self, "vpn_tunnel_options_specifications")
