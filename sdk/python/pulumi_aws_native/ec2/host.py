# coding=utf-8
# *** WARNING: this file was generated by the Pulumi SDK Generator. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import warnings
import pulumi
import pulumi.runtime
from typing import Any, Mapping, Optional, Sequence, Union, overload
from .. import _utilities

__all__ = ['HostArgs', 'Host']

@pulumi.input_type
class HostArgs:
    def __init__(__self__, *,
                 availability_zone: pulumi.Input[str],
                 instance_type: pulumi.Input[str],
                 auto_placement: Optional[pulumi.Input[str]] = None,
                 host_recovery: Optional[pulumi.Input[str]] = None):
        """
        The set of arguments for constructing a Host resource.
        """
        pulumi.set(__self__, "availability_zone", availability_zone)
        pulumi.set(__self__, "instance_type", instance_type)
        if auto_placement is not None:
            pulumi.set(__self__, "auto_placement", auto_placement)
        if host_recovery is not None:
            pulumi.set(__self__, "host_recovery", host_recovery)

    @property
    @pulumi.getter(name="availabilityZone")
    def availability_zone(self) -> pulumi.Input[str]:
        return pulumi.get(self, "availability_zone")

    @availability_zone.setter
    def availability_zone(self, value: pulumi.Input[str]):
        pulumi.set(self, "availability_zone", value)

    @property
    @pulumi.getter(name="instanceType")
    def instance_type(self) -> pulumi.Input[str]:
        return pulumi.get(self, "instance_type")

    @instance_type.setter
    def instance_type(self, value: pulumi.Input[str]):
        pulumi.set(self, "instance_type", value)

    @property
    @pulumi.getter(name="autoPlacement")
    def auto_placement(self) -> Optional[pulumi.Input[str]]:
        return pulumi.get(self, "auto_placement")

    @auto_placement.setter
    def auto_placement(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "auto_placement", value)

    @property
    @pulumi.getter(name="hostRecovery")
    def host_recovery(self) -> Optional[pulumi.Input[str]]:
        return pulumi.get(self, "host_recovery")

    @host_recovery.setter
    def host_recovery(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "host_recovery", value)


warnings.warn("""Host is not yet supported by AWS Native, so its creation will currently fail. Please use the classic AWS provider, if possible.""", DeprecationWarning)


class Host(pulumi.CustomResource):
    warnings.warn("""Host is not yet supported by AWS Native, so its creation will currently fail. Please use the classic AWS provider, if possible.""", DeprecationWarning)

    @overload
    def __init__(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 auto_placement: Optional[pulumi.Input[str]] = None,
                 availability_zone: Optional[pulumi.Input[str]] = None,
                 host_recovery: Optional[pulumi.Input[str]] = None,
                 instance_type: Optional[pulumi.Input[str]] = None,
                 __props__=None):
        """
        Resource Type definition for AWS::EC2::Host

        :param str resource_name: The name of the resource.
        :param pulumi.ResourceOptions opts: Options for the resource.
        """
        ...
    @overload
    def __init__(__self__,
                 resource_name: str,
                 args: HostArgs,
                 opts: Optional[pulumi.ResourceOptions] = None):
        """
        Resource Type definition for AWS::EC2::Host

        :param str resource_name: The name of the resource.
        :param HostArgs args: The arguments to use to populate this resource's properties.
        :param pulumi.ResourceOptions opts: Options for the resource.
        """
        ...
    def __init__(__self__, resource_name: str, *args, **kwargs):
        resource_args, opts = _utilities.get_resource_args_opts(HostArgs, pulumi.ResourceOptions, *args, **kwargs)
        if resource_args is not None:
            __self__._internal_init(resource_name, opts, **resource_args.__dict__)
        else:
            __self__._internal_init(resource_name, *args, **kwargs)

    def _internal_init(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 auto_placement: Optional[pulumi.Input[str]] = None,
                 availability_zone: Optional[pulumi.Input[str]] = None,
                 host_recovery: Optional[pulumi.Input[str]] = None,
                 instance_type: Optional[pulumi.Input[str]] = None,
                 __props__=None):
        pulumi.log.warn("""Host is deprecated: Host is not yet supported by AWS Native, so its creation will currently fail. Please use the classic AWS provider, if possible.""")
        if opts is None:
            opts = pulumi.ResourceOptions()
        if not isinstance(opts, pulumi.ResourceOptions):
            raise TypeError('Expected resource options to be a ResourceOptions instance')
        if opts.version is None:
            opts.version = _utilities.get_version()
        if opts.id is None:
            if __props__ is not None:
                raise TypeError('__props__ is only valid when passed in combination with a valid opts.id to get an existing resource')
            __props__ = HostArgs.__new__(HostArgs)

            __props__.__dict__["auto_placement"] = auto_placement
            if availability_zone is None and not opts.urn:
                raise TypeError("Missing required property 'availability_zone'")
            __props__.__dict__["availability_zone"] = availability_zone
            __props__.__dict__["host_recovery"] = host_recovery
            if instance_type is None and not opts.urn:
                raise TypeError("Missing required property 'instance_type'")
            __props__.__dict__["instance_type"] = instance_type
        super(Host, __self__).__init__(
            'aws-native:ec2:Host',
            resource_name,
            __props__,
            opts)

    @staticmethod
    def get(resource_name: str,
            id: pulumi.Input[str],
            opts: Optional[pulumi.ResourceOptions] = None) -> 'Host':
        """
        Get an existing Host resource's state with the given name, id, and optional extra
        properties used to qualify the lookup.

        :param str resource_name: The unique name of the resulting resource.
        :param pulumi.Input[str] id: The unique provider ID of the resource to lookup.
        :param pulumi.ResourceOptions opts: Options for the resource.
        """
        opts = pulumi.ResourceOptions.merge(opts, pulumi.ResourceOptions(id=id))

        __props__ = HostArgs.__new__(HostArgs)

        __props__.__dict__["auto_placement"] = None
        __props__.__dict__["availability_zone"] = None
        __props__.__dict__["host_recovery"] = None
        __props__.__dict__["instance_type"] = None
        return Host(resource_name, opts=opts, __props__=__props__)

    @property
    @pulumi.getter(name="autoPlacement")
    def auto_placement(self) -> pulumi.Output[Optional[str]]:
        return pulumi.get(self, "auto_placement")

    @property
    @pulumi.getter(name="availabilityZone")
    def availability_zone(self) -> pulumi.Output[str]:
        return pulumi.get(self, "availability_zone")

    @property
    @pulumi.getter(name="hostRecovery")
    def host_recovery(self) -> pulumi.Output[Optional[str]]:
        return pulumi.get(self, "host_recovery")

    @property
    @pulumi.getter(name="instanceType")
    def instance_type(self) -> pulumi.Output[str]:
        return pulumi.get(self, "instance_type")

