# coding=utf-8
# *** WARNING: this file was generated by the Pulumi SDK Generator. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import warnings
import pulumi
import pulumi.runtime
from typing import Any, Mapping, Optional, Sequence, Union, overload
from .. import _utilities

__all__ = ['ThingPrincipalAttachmentArgs', 'ThingPrincipalAttachment']

@pulumi.input_type
class ThingPrincipalAttachmentArgs:
    def __init__(__self__, *,
                 principal: pulumi.Input[str],
                 thing_name: pulumi.Input[str]):
        """
        The set of arguments for constructing a ThingPrincipalAttachment resource.
        """
        pulumi.set(__self__, "principal", principal)
        pulumi.set(__self__, "thing_name", thing_name)

    @property
    @pulumi.getter
    def principal(self) -> pulumi.Input[str]:
        return pulumi.get(self, "principal")

    @principal.setter
    def principal(self, value: pulumi.Input[str]):
        pulumi.set(self, "principal", value)

    @property
    @pulumi.getter(name="thingName")
    def thing_name(self) -> pulumi.Input[str]:
        return pulumi.get(self, "thing_name")

    @thing_name.setter
    def thing_name(self, value: pulumi.Input[str]):
        pulumi.set(self, "thing_name", value)


warnings.warn("""ThingPrincipalAttachment is not yet supported by AWS Native, so its creation will currently fail. Please use the classic AWS provider, if possible.""", DeprecationWarning)


class ThingPrincipalAttachment(pulumi.CustomResource):
    warnings.warn("""ThingPrincipalAttachment is not yet supported by AWS Native, so its creation will currently fail. Please use the classic AWS provider, if possible.""", DeprecationWarning)

    @overload
    def __init__(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 principal: Optional[pulumi.Input[str]] = None,
                 thing_name: Optional[pulumi.Input[str]] = None,
                 __props__=None):
        """
        Resource Type definition for AWS::IoT::ThingPrincipalAttachment

        :param str resource_name: The name of the resource.
        :param pulumi.ResourceOptions opts: Options for the resource.
        """
        ...
    @overload
    def __init__(__self__,
                 resource_name: str,
                 args: ThingPrincipalAttachmentArgs,
                 opts: Optional[pulumi.ResourceOptions] = None):
        """
        Resource Type definition for AWS::IoT::ThingPrincipalAttachment

        :param str resource_name: The name of the resource.
        :param ThingPrincipalAttachmentArgs args: The arguments to use to populate this resource's properties.
        :param pulumi.ResourceOptions opts: Options for the resource.
        """
        ...
    def __init__(__self__, resource_name: str, *args, **kwargs):
        resource_args, opts = _utilities.get_resource_args_opts(ThingPrincipalAttachmentArgs, pulumi.ResourceOptions, *args, **kwargs)
        if resource_args is not None:
            __self__._internal_init(resource_name, opts, **resource_args.__dict__)
        else:
            __self__._internal_init(resource_name, *args, **kwargs)

    def _internal_init(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 principal: Optional[pulumi.Input[str]] = None,
                 thing_name: Optional[pulumi.Input[str]] = None,
                 __props__=None):
        pulumi.log.warn("""ThingPrincipalAttachment is deprecated: ThingPrincipalAttachment is not yet supported by AWS Native, so its creation will currently fail. Please use the classic AWS provider, if possible.""")
        if opts is None:
            opts = pulumi.ResourceOptions()
        if not isinstance(opts, pulumi.ResourceOptions):
            raise TypeError('Expected resource options to be a ResourceOptions instance')
        if opts.version is None:
            opts.version = _utilities.get_version()
        if opts.id is None:
            if __props__ is not None:
                raise TypeError('__props__ is only valid when passed in combination with a valid opts.id to get an existing resource')
            __props__ = ThingPrincipalAttachmentArgs.__new__(ThingPrincipalAttachmentArgs)

            if principal is None and not opts.urn:
                raise TypeError("Missing required property 'principal'")
            __props__.__dict__["principal"] = principal
            if thing_name is None and not opts.urn:
                raise TypeError("Missing required property 'thing_name'")
            __props__.__dict__["thing_name"] = thing_name
        super(ThingPrincipalAttachment, __self__).__init__(
            'aws-native:iot:ThingPrincipalAttachment',
            resource_name,
            __props__,
            opts)

    @staticmethod
    def get(resource_name: str,
            id: pulumi.Input[str],
            opts: Optional[pulumi.ResourceOptions] = None) -> 'ThingPrincipalAttachment':
        """
        Get an existing ThingPrincipalAttachment resource's state with the given name, id, and optional extra
        properties used to qualify the lookup.

        :param str resource_name: The unique name of the resulting resource.
        :param pulumi.Input[str] id: The unique provider ID of the resource to lookup.
        :param pulumi.ResourceOptions opts: Options for the resource.
        """
        opts = pulumi.ResourceOptions.merge(opts, pulumi.ResourceOptions(id=id))

        __props__ = ThingPrincipalAttachmentArgs.__new__(ThingPrincipalAttachmentArgs)

        __props__.__dict__["principal"] = None
        __props__.__dict__["thing_name"] = None
        return ThingPrincipalAttachment(resource_name, opts=opts, __props__=__props__)

    @property
    @pulumi.getter
    def principal(self) -> pulumi.Output[str]:
        return pulumi.get(self, "principal")

    @property
    @pulumi.getter(name="thingName")
    def thing_name(self) -> pulumi.Output[str]:
        return pulumi.get(self, "thing_name")

