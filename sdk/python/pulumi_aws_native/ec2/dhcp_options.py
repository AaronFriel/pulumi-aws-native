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

__all__ = ['DHCPOptionsArgs', 'DHCPOptions']

@pulumi.input_type
class DHCPOptionsArgs:
    def __init__(__self__, *,
                 domain_name: Optional[pulumi.Input[str]] = None,
                 domain_name_servers: Optional[pulumi.Input[Sequence[pulumi.Input[str]]]] = None,
                 netbios_name_servers: Optional[pulumi.Input[Sequence[pulumi.Input[str]]]] = None,
                 netbios_node_type: Optional[pulumi.Input[int]] = None,
                 ntp_servers: Optional[pulumi.Input[Sequence[pulumi.Input[str]]]] = None,
                 tags: Optional[pulumi.Input[Sequence[pulumi.Input['DHCPOptionsTagArgs']]]] = None):
        """
        The set of arguments for constructing a DHCPOptions resource.
        :param pulumi.Input[str] domain_name: This value is used to complete unqualified DNS hostnames.
        :param pulumi.Input[Sequence[pulumi.Input[str]]] domain_name_servers: The IPv4 addresses of up to four domain name servers, or AmazonProvidedDNS.
        :param pulumi.Input[Sequence[pulumi.Input[str]]] netbios_name_servers: The IPv4 addresses of up to four NetBIOS name servers.
        :param pulumi.Input[int] netbios_node_type: The NetBIOS node type (1, 2, 4, or 8).
        :param pulumi.Input[Sequence[pulumi.Input[str]]] ntp_servers: The IPv4 addresses of up to four Network Time Protocol (NTP) servers.
        :param pulumi.Input[Sequence[pulumi.Input['DHCPOptionsTagArgs']]] tags: Any tags assigned to the DHCP options set.
        """
        if domain_name is not None:
            pulumi.set(__self__, "domain_name", domain_name)
        if domain_name_servers is not None:
            pulumi.set(__self__, "domain_name_servers", domain_name_servers)
        if netbios_name_servers is not None:
            pulumi.set(__self__, "netbios_name_servers", netbios_name_servers)
        if netbios_node_type is not None:
            pulumi.set(__self__, "netbios_node_type", netbios_node_type)
        if ntp_servers is not None:
            pulumi.set(__self__, "ntp_servers", ntp_servers)
        if tags is not None:
            pulumi.set(__self__, "tags", tags)

    @property
    @pulumi.getter(name="domainName")
    def domain_name(self) -> Optional[pulumi.Input[str]]:
        """
        This value is used to complete unqualified DNS hostnames.
        """
        return pulumi.get(self, "domain_name")

    @domain_name.setter
    def domain_name(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "domain_name", value)

    @property
    @pulumi.getter(name="domainNameServers")
    def domain_name_servers(self) -> Optional[pulumi.Input[Sequence[pulumi.Input[str]]]]:
        """
        The IPv4 addresses of up to four domain name servers, or AmazonProvidedDNS.
        """
        return pulumi.get(self, "domain_name_servers")

    @domain_name_servers.setter
    def domain_name_servers(self, value: Optional[pulumi.Input[Sequence[pulumi.Input[str]]]]):
        pulumi.set(self, "domain_name_servers", value)

    @property
    @pulumi.getter(name="netbiosNameServers")
    def netbios_name_servers(self) -> Optional[pulumi.Input[Sequence[pulumi.Input[str]]]]:
        """
        The IPv4 addresses of up to four NetBIOS name servers.
        """
        return pulumi.get(self, "netbios_name_servers")

    @netbios_name_servers.setter
    def netbios_name_servers(self, value: Optional[pulumi.Input[Sequence[pulumi.Input[str]]]]):
        pulumi.set(self, "netbios_name_servers", value)

    @property
    @pulumi.getter(name="netbiosNodeType")
    def netbios_node_type(self) -> Optional[pulumi.Input[int]]:
        """
        The NetBIOS node type (1, 2, 4, or 8).
        """
        return pulumi.get(self, "netbios_node_type")

    @netbios_node_type.setter
    def netbios_node_type(self, value: Optional[pulumi.Input[int]]):
        pulumi.set(self, "netbios_node_type", value)

    @property
    @pulumi.getter(name="ntpServers")
    def ntp_servers(self) -> Optional[pulumi.Input[Sequence[pulumi.Input[str]]]]:
        """
        The IPv4 addresses of up to four Network Time Protocol (NTP) servers.
        """
        return pulumi.get(self, "ntp_servers")

    @ntp_servers.setter
    def ntp_servers(self, value: Optional[pulumi.Input[Sequence[pulumi.Input[str]]]]):
        pulumi.set(self, "ntp_servers", value)

    @property
    @pulumi.getter
    def tags(self) -> Optional[pulumi.Input[Sequence[pulumi.Input['DHCPOptionsTagArgs']]]]:
        """
        Any tags assigned to the DHCP options set.
        """
        return pulumi.get(self, "tags")

    @tags.setter
    def tags(self, value: Optional[pulumi.Input[Sequence[pulumi.Input['DHCPOptionsTagArgs']]]]):
        pulumi.set(self, "tags", value)


class DHCPOptions(pulumi.CustomResource):
    @overload
    def __init__(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 domain_name: Optional[pulumi.Input[str]] = None,
                 domain_name_servers: Optional[pulumi.Input[Sequence[pulumi.Input[str]]]] = None,
                 netbios_name_servers: Optional[pulumi.Input[Sequence[pulumi.Input[str]]]] = None,
                 netbios_node_type: Optional[pulumi.Input[int]] = None,
                 ntp_servers: Optional[pulumi.Input[Sequence[pulumi.Input[str]]]] = None,
                 tags: Optional[pulumi.Input[Sequence[pulumi.Input[pulumi.InputType['DHCPOptionsTagArgs']]]]] = None,
                 __props__=None):
        """
        Resource Type definition for AWS::EC2::DHCPOptions

        :param str resource_name: The name of the resource.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[str] domain_name: This value is used to complete unqualified DNS hostnames.
        :param pulumi.Input[Sequence[pulumi.Input[str]]] domain_name_servers: The IPv4 addresses of up to four domain name servers, or AmazonProvidedDNS.
        :param pulumi.Input[Sequence[pulumi.Input[str]]] netbios_name_servers: The IPv4 addresses of up to four NetBIOS name servers.
        :param pulumi.Input[int] netbios_node_type: The NetBIOS node type (1, 2, 4, or 8).
        :param pulumi.Input[Sequence[pulumi.Input[str]]] ntp_servers: The IPv4 addresses of up to four Network Time Protocol (NTP) servers.
        :param pulumi.Input[Sequence[pulumi.Input[pulumi.InputType['DHCPOptionsTagArgs']]]] tags: Any tags assigned to the DHCP options set.
        """
        ...
    @overload
    def __init__(__self__,
                 resource_name: str,
                 args: Optional[DHCPOptionsArgs] = None,
                 opts: Optional[pulumi.ResourceOptions] = None):
        """
        Resource Type definition for AWS::EC2::DHCPOptions

        :param str resource_name: The name of the resource.
        :param DHCPOptionsArgs args: The arguments to use to populate this resource's properties.
        :param pulumi.ResourceOptions opts: Options for the resource.
        """
        ...
    def __init__(__self__, resource_name: str, *args, **kwargs):
        resource_args, opts = _utilities.get_resource_args_opts(DHCPOptionsArgs, pulumi.ResourceOptions, *args, **kwargs)
        if resource_args is not None:
            __self__._internal_init(resource_name, opts, **resource_args.__dict__)
        else:
            __self__._internal_init(resource_name, *args, **kwargs)

    def _internal_init(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 domain_name: Optional[pulumi.Input[str]] = None,
                 domain_name_servers: Optional[pulumi.Input[Sequence[pulumi.Input[str]]]] = None,
                 netbios_name_servers: Optional[pulumi.Input[Sequence[pulumi.Input[str]]]] = None,
                 netbios_node_type: Optional[pulumi.Input[int]] = None,
                 ntp_servers: Optional[pulumi.Input[Sequence[pulumi.Input[str]]]] = None,
                 tags: Optional[pulumi.Input[Sequence[pulumi.Input[pulumi.InputType['DHCPOptionsTagArgs']]]]] = None,
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
            __props__ = DHCPOptionsArgs.__new__(DHCPOptionsArgs)

            __props__.__dict__["domain_name"] = domain_name
            __props__.__dict__["domain_name_servers"] = domain_name_servers
            __props__.__dict__["netbios_name_servers"] = netbios_name_servers
            __props__.__dict__["netbios_node_type"] = netbios_node_type
            __props__.__dict__["ntp_servers"] = ntp_servers
            __props__.__dict__["tags"] = tags
            __props__.__dict__["dhcp_options_id"] = None
        super(DHCPOptions, __self__).__init__(
            'aws-native:ec2:DHCPOptions',
            resource_name,
            __props__,
            opts)

    @staticmethod
    def get(resource_name: str,
            id: pulumi.Input[str],
            opts: Optional[pulumi.ResourceOptions] = None) -> 'DHCPOptions':
        """
        Get an existing DHCPOptions resource's state with the given name, id, and optional extra
        properties used to qualify the lookup.

        :param str resource_name: The unique name of the resulting resource.
        :param pulumi.Input[str] id: The unique provider ID of the resource to lookup.
        :param pulumi.ResourceOptions opts: Options for the resource.
        """
        opts = pulumi.ResourceOptions.merge(opts, pulumi.ResourceOptions(id=id))

        __props__ = DHCPOptionsArgs.__new__(DHCPOptionsArgs)

        __props__.__dict__["dhcp_options_id"] = None
        __props__.__dict__["domain_name"] = None
        __props__.__dict__["domain_name_servers"] = None
        __props__.__dict__["netbios_name_servers"] = None
        __props__.__dict__["netbios_node_type"] = None
        __props__.__dict__["ntp_servers"] = None
        __props__.__dict__["tags"] = None
        return DHCPOptions(resource_name, opts=opts, __props__=__props__)

    @property
    @pulumi.getter(name="dhcpOptionsId")
    def dhcp_options_id(self) -> pulumi.Output[str]:
        return pulumi.get(self, "dhcp_options_id")

    @property
    @pulumi.getter(name="domainName")
    def domain_name(self) -> pulumi.Output[Optional[str]]:
        """
        This value is used to complete unqualified DNS hostnames.
        """
        return pulumi.get(self, "domain_name")

    @property
    @pulumi.getter(name="domainNameServers")
    def domain_name_servers(self) -> pulumi.Output[Optional[Sequence[str]]]:
        """
        The IPv4 addresses of up to four domain name servers, or AmazonProvidedDNS.
        """
        return pulumi.get(self, "domain_name_servers")

    @property
    @pulumi.getter(name="netbiosNameServers")
    def netbios_name_servers(self) -> pulumi.Output[Optional[Sequence[str]]]:
        """
        The IPv4 addresses of up to four NetBIOS name servers.
        """
        return pulumi.get(self, "netbios_name_servers")

    @property
    @pulumi.getter(name="netbiosNodeType")
    def netbios_node_type(self) -> pulumi.Output[Optional[int]]:
        """
        The NetBIOS node type (1, 2, 4, or 8).
        """
        return pulumi.get(self, "netbios_node_type")

    @property
    @pulumi.getter(name="ntpServers")
    def ntp_servers(self) -> pulumi.Output[Optional[Sequence[str]]]:
        """
        The IPv4 addresses of up to four Network Time Protocol (NTP) servers.
        """
        return pulumi.get(self, "ntp_servers")

    @property
    @pulumi.getter
    def tags(self) -> pulumi.Output[Optional[Sequence['outputs.DHCPOptionsTag']]]:
        """
        Any tags assigned to the DHCP options set.
        """
        return pulumi.get(self, "tags")

