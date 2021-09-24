# coding=utf-8
# *** WARNING: this file was generated by the Pulumi SDK Generator. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import warnings
import pulumi
import pulumi.runtime
from typing import Any, Mapping, Optional, Sequence, Union, overload
from .. import _utilities
from . import outputs
from ._inputs import *

__all__ = ['VPCArgs', 'VPC']

@pulumi.input_type
class VPCArgs:
    def __init__(__self__, *,
                 cidr_block: pulumi.Input[str],
                 enable_dns_hostnames: Optional[pulumi.Input[bool]] = None,
                 enable_dns_support: Optional[pulumi.Input[bool]] = None,
                 instance_tenancy: Optional[pulumi.Input[str]] = None,
                 tags: Optional[pulumi.Input[Sequence[pulumi.Input['VPCTagArgs']]]] = None):
        """
        The set of arguments for constructing a VPC resource.
        """
        pulumi.set(__self__, "cidr_block", cidr_block)
        if enable_dns_hostnames is not None:
            pulumi.set(__self__, "enable_dns_hostnames", enable_dns_hostnames)
        if enable_dns_support is not None:
            pulumi.set(__self__, "enable_dns_support", enable_dns_support)
        if instance_tenancy is not None:
            pulumi.set(__self__, "instance_tenancy", instance_tenancy)
        if tags is not None:
            pulumi.set(__self__, "tags", tags)

    @property
    @pulumi.getter(name="cidrBlock")
    def cidr_block(self) -> pulumi.Input[str]:
        return pulumi.get(self, "cidr_block")

    @cidr_block.setter
    def cidr_block(self, value: pulumi.Input[str]):
        pulumi.set(self, "cidr_block", value)

    @property
    @pulumi.getter(name="enableDnsHostnames")
    def enable_dns_hostnames(self) -> Optional[pulumi.Input[bool]]:
        return pulumi.get(self, "enable_dns_hostnames")

    @enable_dns_hostnames.setter
    def enable_dns_hostnames(self, value: Optional[pulumi.Input[bool]]):
        pulumi.set(self, "enable_dns_hostnames", value)

    @property
    @pulumi.getter(name="enableDnsSupport")
    def enable_dns_support(self) -> Optional[pulumi.Input[bool]]:
        return pulumi.get(self, "enable_dns_support")

    @enable_dns_support.setter
    def enable_dns_support(self, value: Optional[pulumi.Input[bool]]):
        pulumi.set(self, "enable_dns_support", value)

    @property
    @pulumi.getter(name="instanceTenancy")
    def instance_tenancy(self) -> Optional[pulumi.Input[str]]:
        return pulumi.get(self, "instance_tenancy")

    @instance_tenancy.setter
    def instance_tenancy(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "instance_tenancy", value)

    @property
    @pulumi.getter
    def tags(self) -> Optional[pulumi.Input[Sequence[pulumi.Input['VPCTagArgs']]]]:
        return pulumi.get(self, "tags")

    @tags.setter
    def tags(self, value: Optional[pulumi.Input[Sequence[pulumi.Input['VPCTagArgs']]]]):
        pulumi.set(self, "tags", value)


warnings.warn("""VPC is not yet supported by AWS Native, so its creation will currently fail. Please use the classic AWS provider, if possible.""", DeprecationWarning)


class VPC(pulumi.CustomResource):
    warnings.warn("""VPC is not yet supported by AWS Native, so its creation will currently fail. Please use the classic AWS provider, if possible.""", DeprecationWarning)

    @overload
    def __init__(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 cidr_block: Optional[pulumi.Input[str]] = None,
                 enable_dns_hostnames: Optional[pulumi.Input[bool]] = None,
                 enable_dns_support: Optional[pulumi.Input[bool]] = None,
                 instance_tenancy: Optional[pulumi.Input[str]] = None,
                 tags: Optional[pulumi.Input[Sequence[pulumi.Input[pulumi.InputType['VPCTagArgs']]]]] = None,
                 __props__=None):
        """
        Resource Type definition for AWS::EC2::VPC

        :param str resource_name: The name of the resource.
        :param pulumi.ResourceOptions opts: Options for the resource.
        """
        ...
    @overload
    def __init__(__self__,
                 resource_name: str,
                 args: VPCArgs,
                 opts: Optional[pulumi.ResourceOptions] = None):
        """
        Resource Type definition for AWS::EC2::VPC

        :param str resource_name: The name of the resource.
        :param VPCArgs args: The arguments to use to populate this resource's properties.
        :param pulumi.ResourceOptions opts: Options for the resource.
        """
        ...
    def __init__(__self__, resource_name: str, *args, **kwargs):
        resource_args, opts = _utilities.get_resource_args_opts(VPCArgs, pulumi.ResourceOptions, *args, **kwargs)
        if resource_args is not None:
            __self__._internal_init(resource_name, opts, **resource_args.__dict__)
        else:
            __self__._internal_init(resource_name, *args, **kwargs)

    def _internal_init(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 cidr_block: Optional[pulumi.Input[str]] = None,
                 enable_dns_hostnames: Optional[pulumi.Input[bool]] = None,
                 enable_dns_support: Optional[pulumi.Input[bool]] = None,
                 instance_tenancy: Optional[pulumi.Input[str]] = None,
                 tags: Optional[pulumi.Input[Sequence[pulumi.Input[pulumi.InputType['VPCTagArgs']]]]] = None,
                 __props__=None):
        pulumi.log.warn("""VPC is deprecated: VPC is not yet supported by AWS Native, so its creation will currently fail. Please use the classic AWS provider, if possible.""")
        if opts is None:
            opts = pulumi.ResourceOptions()
        if not isinstance(opts, pulumi.ResourceOptions):
            raise TypeError('Expected resource options to be a ResourceOptions instance')
        if opts.version is None:
            opts.version = _utilities.get_version()
        if opts.id is None:
            if __props__ is not None:
                raise TypeError('__props__ is only valid when passed in combination with a valid opts.id to get an existing resource')
            __props__ = VPCArgs.__new__(VPCArgs)

            if cidr_block is None and not opts.urn:
                raise TypeError("Missing required property 'cidr_block'")
            __props__.__dict__["cidr_block"] = cidr_block
            __props__.__dict__["enable_dns_hostnames"] = enable_dns_hostnames
            __props__.__dict__["enable_dns_support"] = enable_dns_support
            __props__.__dict__["instance_tenancy"] = instance_tenancy
            __props__.__dict__["tags"] = tags
            __props__.__dict__["cidr_block_associations"] = None
            __props__.__dict__["default_network_acl"] = None
            __props__.__dict__["default_security_group"] = None
            __props__.__dict__["ipv6_cidr_blocks"] = None
        super(VPC, __self__).__init__(
            'aws-native:ec2:VPC',
            resource_name,
            __props__,
            opts)

    @staticmethod
    def get(resource_name: str,
            id: pulumi.Input[str],
            opts: Optional[pulumi.ResourceOptions] = None) -> 'VPC':
        """
        Get an existing VPC resource's state with the given name, id, and optional extra
        properties used to qualify the lookup.

        :param str resource_name: The unique name of the resulting resource.
        :param pulumi.Input[str] id: The unique provider ID of the resource to lookup.
        :param pulumi.ResourceOptions opts: Options for the resource.
        """
        opts = pulumi.ResourceOptions.merge(opts, pulumi.ResourceOptions(id=id))

        __props__ = VPCArgs.__new__(VPCArgs)

        __props__.__dict__["cidr_block"] = None
        __props__.__dict__["cidr_block_associations"] = None
        __props__.__dict__["default_network_acl"] = None
        __props__.__dict__["default_security_group"] = None
        __props__.__dict__["enable_dns_hostnames"] = None
        __props__.__dict__["enable_dns_support"] = None
        __props__.__dict__["instance_tenancy"] = None
        __props__.__dict__["ipv6_cidr_blocks"] = None
        __props__.__dict__["tags"] = None
        return VPC(resource_name, opts=opts, __props__=__props__)

    @property
    @pulumi.getter(name="cidrBlock")
    def cidr_block(self) -> pulumi.Output[str]:
        return pulumi.get(self, "cidr_block")

    @property
    @pulumi.getter(name="cidrBlockAssociations")
    def cidr_block_associations(self) -> pulumi.Output[Sequence[str]]:
        return pulumi.get(self, "cidr_block_associations")

    @property
    @pulumi.getter(name="defaultNetworkAcl")
    def default_network_acl(self) -> pulumi.Output[str]:
        return pulumi.get(self, "default_network_acl")

    @property
    @pulumi.getter(name="defaultSecurityGroup")
    def default_security_group(self) -> pulumi.Output[str]:
        return pulumi.get(self, "default_security_group")

    @property
    @pulumi.getter(name="enableDnsHostnames")
    def enable_dns_hostnames(self) -> pulumi.Output[Optional[bool]]:
        return pulumi.get(self, "enable_dns_hostnames")

    @property
    @pulumi.getter(name="enableDnsSupport")
    def enable_dns_support(self) -> pulumi.Output[Optional[bool]]:
        return pulumi.get(self, "enable_dns_support")

    @property
    @pulumi.getter(name="instanceTenancy")
    def instance_tenancy(self) -> pulumi.Output[Optional[str]]:
        return pulumi.get(self, "instance_tenancy")

    @property
    @pulumi.getter(name="ipv6CidrBlocks")
    def ipv6_cidr_blocks(self) -> pulumi.Output[Sequence[str]]:
        return pulumi.get(self, "ipv6_cidr_blocks")

    @property
    @pulumi.getter
    def tags(self) -> pulumi.Output[Optional[Sequence['outputs.VPCTag']]]:
        return pulumi.get(self, "tags")

