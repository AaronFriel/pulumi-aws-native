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

__all__ = ['TrafficMirrorFilterArgs', 'TrafficMirrorFilter']

@pulumi.input_type
class TrafficMirrorFilterArgs:
    def __init__(__self__, *,
                 description: Optional[pulumi.Input[str]] = None,
                 network_services: Optional[pulumi.Input[Sequence[pulumi.Input[str]]]] = None,
                 tags: Optional[pulumi.Input[Sequence[pulumi.Input['TrafficMirrorFilterTagArgs']]]] = None):
        """
        The set of arguments for constructing a TrafficMirrorFilter resource.
        """
        if description is not None:
            pulumi.set(__self__, "description", description)
        if network_services is not None:
            pulumi.set(__self__, "network_services", network_services)
        if tags is not None:
            pulumi.set(__self__, "tags", tags)

    @property
    @pulumi.getter
    def description(self) -> Optional[pulumi.Input[str]]:
        return pulumi.get(self, "description")

    @description.setter
    def description(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "description", value)

    @property
    @pulumi.getter(name="networkServices")
    def network_services(self) -> Optional[pulumi.Input[Sequence[pulumi.Input[str]]]]:
        return pulumi.get(self, "network_services")

    @network_services.setter
    def network_services(self, value: Optional[pulumi.Input[Sequence[pulumi.Input[str]]]]):
        pulumi.set(self, "network_services", value)

    @property
    @pulumi.getter
    def tags(self) -> Optional[pulumi.Input[Sequence[pulumi.Input['TrafficMirrorFilterTagArgs']]]]:
        return pulumi.get(self, "tags")

    @tags.setter
    def tags(self, value: Optional[pulumi.Input[Sequence[pulumi.Input['TrafficMirrorFilterTagArgs']]]]):
        pulumi.set(self, "tags", value)


warnings.warn("""TrafficMirrorFilter is not yet supported by AWS Cloud Control API, so its creation will currently fail. Please use the classic AWS provider, if possible.""", DeprecationWarning)


class TrafficMirrorFilter(pulumi.CustomResource):
    warnings.warn("""TrafficMirrorFilter is not yet supported by AWS Cloud Control API, so its creation will currently fail. Please use the classic AWS provider, if possible.""", DeprecationWarning)

    @overload
    def __init__(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 description: Optional[pulumi.Input[str]] = None,
                 network_services: Optional[pulumi.Input[Sequence[pulumi.Input[str]]]] = None,
                 tags: Optional[pulumi.Input[Sequence[pulumi.Input[pulumi.InputType['TrafficMirrorFilterTagArgs']]]]] = None,
                 __props__=None):
        """
        Resource Type definition for AWS::EC2::TrafficMirrorFilter

        :param str resource_name: The name of the resource.
        :param pulumi.ResourceOptions opts: Options for the resource.
        """
        ...
    @overload
    def __init__(__self__,
                 resource_name: str,
                 args: Optional[TrafficMirrorFilterArgs] = None,
                 opts: Optional[pulumi.ResourceOptions] = None):
        """
        Resource Type definition for AWS::EC2::TrafficMirrorFilter

        :param str resource_name: The name of the resource.
        :param TrafficMirrorFilterArgs args: The arguments to use to populate this resource's properties.
        :param pulumi.ResourceOptions opts: Options for the resource.
        """
        ...
    def __init__(__self__, resource_name: str, *args, **kwargs):
        resource_args, opts = _utilities.get_resource_args_opts(TrafficMirrorFilterArgs, pulumi.ResourceOptions, *args, **kwargs)
        if resource_args is not None:
            __self__._internal_init(resource_name, opts, **resource_args.__dict__)
        else:
            __self__._internal_init(resource_name, *args, **kwargs)

    def _internal_init(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 description: Optional[pulumi.Input[str]] = None,
                 network_services: Optional[pulumi.Input[Sequence[pulumi.Input[str]]]] = None,
                 tags: Optional[pulumi.Input[Sequence[pulumi.Input[pulumi.InputType['TrafficMirrorFilterTagArgs']]]]] = None,
                 __props__=None):
        pulumi.log.warn("""TrafficMirrorFilter is deprecated: TrafficMirrorFilter is not yet supported by AWS Cloud Control API, so its creation will currently fail. Please use the classic AWS provider, if possible.""")
        if opts is None:
            opts = pulumi.ResourceOptions()
        if not isinstance(opts, pulumi.ResourceOptions):
            raise TypeError('Expected resource options to be a ResourceOptions instance')
        if opts.version is None:
            opts.version = _utilities.get_version()
        if opts.id is None:
            if __props__ is not None:
                raise TypeError('__props__ is only valid when passed in combination with a valid opts.id to get an existing resource')
            __props__ = TrafficMirrorFilterArgs.__new__(TrafficMirrorFilterArgs)

            __props__.__dict__["description"] = description
            __props__.__dict__["network_services"] = network_services
            __props__.__dict__["tags"] = tags
        super(TrafficMirrorFilter, __self__).__init__(
            'aws-native:ec2:TrafficMirrorFilter',
            resource_name,
            __props__,
            opts)

    @staticmethod
    def get(resource_name: str,
            id: pulumi.Input[str],
            opts: Optional[pulumi.ResourceOptions] = None) -> 'TrafficMirrorFilter':
        """
        Get an existing TrafficMirrorFilter resource's state with the given name, id, and optional extra
        properties used to qualify the lookup.

        :param str resource_name: The unique name of the resulting resource.
        :param pulumi.Input[str] id: The unique provider ID of the resource to lookup.
        :param pulumi.ResourceOptions opts: Options for the resource.
        """
        opts = pulumi.ResourceOptions.merge(opts, pulumi.ResourceOptions(id=id))

        __props__ = TrafficMirrorFilterArgs.__new__(TrafficMirrorFilterArgs)

        __props__.__dict__["description"] = None
        __props__.__dict__["network_services"] = None
        __props__.__dict__["tags"] = None
        return TrafficMirrorFilter(resource_name, opts=opts, __props__=__props__)

    @property
    @pulumi.getter
    def description(self) -> pulumi.Output[Optional[str]]:
        return pulumi.get(self, "description")

    @property
    @pulumi.getter(name="networkServices")
    def network_services(self) -> pulumi.Output[Optional[Sequence[str]]]:
        return pulumi.get(self, "network_services")

    @property
    @pulumi.getter
    def tags(self) -> pulumi.Output[Optional[Sequence['outputs.TrafficMirrorFilterTag']]]:
        return pulumi.get(self, "tags")

