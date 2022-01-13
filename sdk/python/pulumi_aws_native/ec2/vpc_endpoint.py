# coding=utf-8
# *** WARNING: this file was generated by the Pulumi SDK Generator. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import warnings
import pulumi
import pulumi.runtime
from typing import Any, Mapping, Optional, Sequence, Union, overload
from .. import _utilities

__all__ = ['VPCEndpointArgs', 'VPCEndpoint']

@pulumi.input_type
class VPCEndpointArgs:
    def __init__(__self__, *,
                 service_name: pulumi.Input[str],
                 vpc_id: pulumi.Input[str],
                 policy_document: Optional[Any] = None,
                 private_dns_enabled: Optional[pulumi.Input[bool]] = None,
                 route_table_ids: Optional[pulumi.Input[Sequence[pulumi.Input[str]]]] = None,
                 security_group_ids: Optional[pulumi.Input[Sequence[pulumi.Input[str]]]] = None,
                 subnet_ids: Optional[pulumi.Input[Sequence[pulumi.Input[str]]]] = None,
                 vpc_endpoint_type: Optional[pulumi.Input[str]] = None):
        """
        The set of arguments for constructing a VPCEndpoint resource.
        """
        pulumi.set(__self__, "service_name", service_name)
        pulumi.set(__self__, "vpc_id", vpc_id)
        if policy_document is not None:
            pulumi.set(__self__, "policy_document", policy_document)
        if private_dns_enabled is not None:
            pulumi.set(__self__, "private_dns_enabled", private_dns_enabled)
        if route_table_ids is not None:
            pulumi.set(__self__, "route_table_ids", route_table_ids)
        if security_group_ids is not None:
            pulumi.set(__self__, "security_group_ids", security_group_ids)
        if subnet_ids is not None:
            pulumi.set(__self__, "subnet_ids", subnet_ids)
        if vpc_endpoint_type is not None:
            pulumi.set(__self__, "vpc_endpoint_type", vpc_endpoint_type)

    @property
    @pulumi.getter(name="serviceName")
    def service_name(self) -> pulumi.Input[str]:
        return pulumi.get(self, "service_name")

    @service_name.setter
    def service_name(self, value: pulumi.Input[str]):
        pulumi.set(self, "service_name", value)

    @property
    @pulumi.getter(name="vpcId")
    def vpc_id(self) -> pulumi.Input[str]:
        return pulumi.get(self, "vpc_id")

    @vpc_id.setter
    def vpc_id(self, value: pulumi.Input[str]):
        pulumi.set(self, "vpc_id", value)

    @property
    @pulumi.getter(name="policyDocument")
    def policy_document(self) -> Optional[Any]:
        return pulumi.get(self, "policy_document")

    @policy_document.setter
    def policy_document(self, value: Optional[Any]):
        pulumi.set(self, "policy_document", value)

    @property
    @pulumi.getter(name="privateDnsEnabled")
    def private_dns_enabled(self) -> Optional[pulumi.Input[bool]]:
        return pulumi.get(self, "private_dns_enabled")

    @private_dns_enabled.setter
    def private_dns_enabled(self, value: Optional[pulumi.Input[bool]]):
        pulumi.set(self, "private_dns_enabled", value)

    @property
    @pulumi.getter(name="routeTableIds")
    def route_table_ids(self) -> Optional[pulumi.Input[Sequence[pulumi.Input[str]]]]:
        return pulumi.get(self, "route_table_ids")

    @route_table_ids.setter
    def route_table_ids(self, value: Optional[pulumi.Input[Sequence[pulumi.Input[str]]]]):
        pulumi.set(self, "route_table_ids", value)

    @property
    @pulumi.getter(name="securityGroupIds")
    def security_group_ids(self) -> Optional[pulumi.Input[Sequence[pulumi.Input[str]]]]:
        return pulumi.get(self, "security_group_ids")

    @security_group_ids.setter
    def security_group_ids(self, value: Optional[pulumi.Input[Sequence[pulumi.Input[str]]]]):
        pulumi.set(self, "security_group_ids", value)

    @property
    @pulumi.getter(name="subnetIds")
    def subnet_ids(self) -> Optional[pulumi.Input[Sequence[pulumi.Input[str]]]]:
        return pulumi.get(self, "subnet_ids")

    @subnet_ids.setter
    def subnet_ids(self, value: Optional[pulumi.Input[Sequence[pulumi.Input[str]]]]):
        pulumi.set(self, "subnet_ids", value)

    @property
    @pulumi.getter(name="vpcEndpointType")
    def vpc_endpoint_type(self) -> Optional[pulumi.Input[str]]:
        return pulumi.get(self, "vpc_endpoint_type")

    @vpc_endpoint_type.setter
    def vpc_endpoint_type(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "vpc_endpoint_type", value)


warnings.warn("""VPCEndpoint is not yet supported by AWS Native, so its creation will currently fail. Please use the classic AWS provider, if possible.""", DeprecationWarning)


class VPCEndpoint(pulumi.CustomResource):
    warnings.warn("""VPCEndpoint is not yet supported by AWS Native, so its creation will currently fail. Please use the classic AWS provider, if possible.""", DeprecationWarning)

    @overload
    def __init__(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 policy_document: Optional[Any] = None,
                 private_dns_enabled: Optional[pulumi.Input[bool]] = None,
                 route_table_ids: Optional[pulumi.Input[Sequence[pulumi.Input[str]]]] = None,
                 security_group_ids: Optional[pulumi.Input[Sequence[pulumi.Input[str]]]] = None,
                 service_name: Optional[pulumi.Input[str]] = None,
                 subnet_ids: Optional[pulumi.Input[Sequence[pulumi.Input[str]]]] = None,
                 vpc_endpoint_type: Optional[pulumi.Input[str]] = None,
                 vpc_id: Optional[pulumi.Input[str]] = None,
                 __props__=None):
        """
        Resource Type definition for AWS::EC2::VPCEndpoint

        :param str resource_name: The name of the resource.
        :param pulumi.ResourceOptions opts: Options for the resource.
        """
        ...
    @overload
    def __init__(__self__,
                 resource_name: str,
                 args: VPCEndpointArgs,
                 opts: Optional[pulumi.ResourceOptions] = None):
        """
        Resource Type definition for AWS::EC2::VPCEndpoint

        :param str resource_name: The name of the resource.
        :param VPCEndpointArgs args: The arguments to use to populate this resource's properties.
        :param pulumi.ResourceOptions opts: Options for the resource.
        """
        ...
    def __init__(__self__, resource_name: str, *args, **kwargs):
        resource_args, opts = _utilities.get_resource_args_opts(VPCEndpointArgs, pulumi.ResourceOptions, *args, **kwargs)
        if resource_args is not None:
            __self__._internal_init(resource_name, opts, **resource_args.__dict__)
        else:
            __self__._internal_init(resource_name, *args, **kwargs)

    def _internal_init(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 policy_document: Optional[Any] = None,
                 private_dns_enabled: Optional[pulumi.Input[bool]] = None,
                 route_table_ids: Optional[pulumi.Input[Sequence[pulumi.Input[str]]]] = None,
                 security_group_ids: Optional[pulumi.Input[Sequence[pulumi.Input[str]]]] = None,
                 service_name: Optional[pulumi.Input[str]] = None,
                 subnet_ids: Optional[pulumi.Input[Sequence[pulumi.Input[str]]]] = None,
                 vpc_endpoint_type: Optional[pulumi.Input[str]] = None,
                 vpc_id: Optional[pulumi.Input[str]] = None,
                 __props__=None):
        pulumi.log.warn("""VPCEndpoint is deprecated: VPCEndpoint is not yet supported by AWS Native, so its creation will currently fail. Please use the classic AWS provider, if possible.""")
        if opts is None:
            opts = pulumi.ResourceOptions()
        if not isinstance(opts, pulumi.ResourceOptions):
            raise TypeError('Expected resource options to be a ResourceOptions instance')
        if opts.version is None:
            opts.version = _utilities.get_version()
        if opts.id is None:
            if __props__ is not None:
                raise TypeError('__props__ is only valid when passed in combination with a valid opts.id to get an existing resource')
            __props__ = VPCEndpointArgs.__new__(VPCEndpointArgs)

            __props__.__dict__["policy_document"] = policy_document
            __props__.__dict__["private_dns_enabled"] = private_dns_enabled
            __props__.__dict__["route_table_ids"] = route_table_ids
            __props__.__dict__["security_group_ids"] = security_group_ids
            if service_name is None and not opts.urn:
                raise TypeError("Missing required property 'service_name'")
            __props__.__dict__["service_name"] = service_name
            __props__.__dict__["subnet_ids"] = subnet_ids
            __props__.__dict__["vpc_endpoint_type"] = vpc_endpoint_type
            if vpc_id is None and not opts.urn:
                raise TypeError("Missing required property 'vpc_id'")
            __props__.__dict__["vpc_id"] = vpc_id
            __props__.__dict__["creation_timestamp"] = None
            __props__.__dict__["dns_entries"] = None
            __props__.__dict__["network_interface_ids"] = None
        super(VPCEndpoint, __self__).__init__(
            'aws-native:ec2:VPCEndpoint',
            resource_name,
            __props__,
            opts)

    @staticmethod
    def get(resource_name: str,
            id: pulumi.Input[str],
            opts: Optional[pulumi.ResourceOptions] = None) -> 'VPCEndpoint':
        """
        Get an existing VPCEndpoint resource's state with the given name, id, and optional extra
        properties used to qualify the lookup.

        :param str resource_name: The unique name of the resulting resource.
        :param pulumi.Input[str] id: The unique provider ID of the resource to lookup.
        :param pulumi.ResourceOptions opts: Options for the resource.
        """
        opts = pulumi.ResourceOptions.merge(opts, pulumi.ResourceOptions(id=id))

        __props__ = VPCEndpointArgs.__new__(VPCEndpointArgs)

        __props__.__dict__["creation_timestamp"] = None
        __props__.__dict__["dns_entries"] = None
        __props__.__dict__["network_interface_ids"] = None
        __props__.__dict__["policy_document"] = None
        __props__.__dict__["private_dns_enabled"] = None
        __props__.__dict__["route_table_ids"] = None
        __props__.__dict__["security_group_ids"] = None
        __props__.__dict__["service_name"] = None
        __props__.__dict__["subnet_ids"] = None
        __props__.__dict__["vpc_endpoint_type"] = None
        __props__.__dict__["vpc_id"] = None
        return VPCEndpoint(resource_name, opts=opts, __props__=__props__)

    @property
    @pulumi.getter(name="creationTimestamp")
    def creation_timestamp(self) -> pulumi.Output[str]:
        return pulumi.get(self, "creation_timestamp")

    @property
    @pulumi.getter(name="dnsEntries")
    def dns_entries(self) -> pulumi.Output[Sequence[str]]:
        return pulumi.get(self, "dns_entries")

    @property
    @pulumi.getter(name="networkInterfaceIds")
    def network_interface_ids(self) -> pulumi.Output[Sequence[str]]:
        return pulumi.get(self, "network_interface_ids")

    @property
    @pulumi.getter(name="policyDocument")
    def policy_document(self) -> pulumi.Output[Optional[Any]]:
        return pulumi.get(self, "policy_document")

    @property
    @pulumi.getter(name="privateDnsEnabled")
    def private_dns_enabled(self) -> pulumi.Output[Optional[bool]]:
        return pulumi.get(self, "private_dns_enabled")

    @property
    @pulumi.getter(name="routeTableIds")
    def route_table_ids(self) -> pulumi.Output[Optional[Sequence[str]]]:
        return pulumi.get(self, "route_table_ids")

    @property
    @pulumi.getter(name="securityGroupIds")
    def security_group_ids(self) -> pulumi.Output[Optional[Sequence[str]]]:
        return pulumi.get(self, "security_group_ids")

    @property
    @pulumi.getter(name="serviceName")
    def service_name(self) -> pulumi.Output[str]:
        return pulumi.get(self, "service_name")

    @property
    @pulumi.getter(name="subnetIds")
    def subnet_ids(self) -> pulumi.Output[Optional[Sequence[str]]]:
        return pulumi.get(self, "subnet_ids")

    @property
    @pulumi.getter(name="vpcEndpointType")
    def vpc_endpoint_type(self) -> pulumi.Output[Optional[str]]:
        return pulumi.get(self, "vpc_endpoint_type")

    @property
    @pulumi.getter(name="vpcId")
    def vpc_id(self) -> pulumi.Output[str]:
        return pulumi.get(self, "vpc_id")

