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

__all__ = ['LocationEFSArgs', 'LocationEFS']

@pulumi.input_type
class LocationEFSArgs:
    def __init__(__self__, *,
                 ec2_config: pulumi.Input['LocationEFSEc2ConfigArgs'],
                 efs_filesystem_arn: pulumi.Input[str],
                 subdirectory: Optional[pulumi.Input[str]] = None,
                 tags: Optional[pulumi.Input[Sequence[pulumi.Input['LocationEFSTagArgs']]]] = None):
        """
        The set of arguments for constructing a LocationEFS resource.
        :param pulumi.Input[str] efs_filesystem_arn: The Amazon Resource Name (ARN) for the Amazon EFS file system.
        :param pulumi.Input[str] subdirectory: A subdirectory in the location's path. This subdirectory in the EFS file system is used to read data from the EFS source location or write data to the EFS destination.
        :param pulumi.Input[Sequence[pulumi.Input['LocationEFSTagArgs']]] tags: An array of key-value pairs to apply to this resource.
        """
        pulumi.set(__self__, "ec2_config", ec2_config)
        pulumi.set(__self__, "efs_filesystem_arn", efs_filesystem_arn)
        if subdirectory is not None:
            pulumi.set(__self__, "subdirectory", subdirectory)
        if tags is not None:
            pulumi.set(__self__, "tags", tags)

    @property
    @pulumi.getter(name="ec2Config")
    def ec2_config(self) -> pulumi.Input['LocationEFSEc2ConfigArgs']:
        return pulumi.get(self, "ec2_config")

    @ec2_config.setter
    def ec2_config(self, value: pulumi.Input['LocationEFSEc2ConfigArgs']):
        pulumi.set(self, "ec2_config", value)

    @property
    @pulumi.getter(name="efsFilesystemArn")
    def efs_filesystem_arn(self) -> pulumi.Input[str]:
        """
        The Amazon Resource Name (ARN) for the Amazon EFS file system.
        """
        return pulumi.get(self, "efs_filesystem_arn")

    @efs_filesystem_arn.setter
    def efs_filesystem_arn(self, value: pulumi.Input[str]):
        pulumi.set(self, "efs_filesystem_arn", value)

    @property
    @pulumi.getter
    def subdirectory(self) -> Optional[pulumi.Input[str]]:
        """
        A subdirectory in the location's path. This subdirectory in the EFS file system is used to read data from the EFS source location or write data to the EFS destination.
        """
        return pulumi.get(self, "subdirectory")

    @subdirectory.setter
    def subdirectory(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "subdirectory", value)

    @property
    @pulumi.getter
    def tags(self) -> Optional[pulumi.Input[Sequence[pulumi.Input['LocationEFSTagArgs']]]]:
        """
        An array of key-value pairs to apply to this resource.
        """
        return pulumi.get(self, "tags")

    @tags.setter
    def tags(self, value: Optional[pulumi.Input[Sequence[pulumi.Input['LocationEFSTagArgs']]]]):
        pulumi.set(self, "tags", value)


class LocationEFS(pulumi.CustomResource):
    @overload
    def __init__(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 ec2_config: Optional[pulumi.Input[pulumi.InputType['LocationEFSEc2ConfigArgs']]] = None,
                 efs_filesystem_arn: Optional[pulumi.Input[str]] = None,
                 subdirectory: Optional[pulumi.Input[str]] = None,
                 tags: Optional[pulumi.Input[Sequence[pulumi.Input[pulumi.InputType['LocationEFSTagArgs']]]]] = None,
                 __props__=None):
        """
        Resource schema for AWS::DataSync::LocationEFS.

        :param str resource_name: The name of the resource.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[str] efs_filesystem_arn: The Amazon Resource Name (ARN) for the Amazon EFS file system.
        :param pulumi.Input[str] subdirectory: A subdirectory in the location's path. This subdirectory in the EFS file system is used to read data from the EFS source location or write data to the EFS destination.
        :param pulumi.Input[Sequence[pulumi.Input[pulumi.InputType['LocationEFSTagArgs']]]] tags: An array of key-value pairs to apply to this resource.
        """
        ...
    @overload
    def __init__(__self__,
                 resource_name: str,
                 args: LocationEFSArgs,
                 opts: Optional[pulumi.ResourceOptions] = None):
        """
        Resource schema for AWS::DataSync::LocationEFS.

        :param str resource_name: The name of the resource.
        :param LocationEFSArgs args: The arguments to use to populate this resource's properties.
        :param pulumi.ResourceOptions opts: Options for the resource.
        """
        ...
    def __init__(__self__, resource_name: str, *args, **kwargs):
        resource_args, opts = _utilities.get_resource_args_opts(LocationEFSArgs, pulumi.ResourceOptions, *args, **kwargs)
        if resource_args is not None:
            __self__._internal_init(resource_name, opts, **resource_args.__dict__)
        else:
            __self__._internal_init(resource_name, *args, **kwargs)

    def _internal_init(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 ec2_config: Optional[pulumi.Input[pulumi.InputType['LocationEFSEc2ConfigArgs']]] = None,
                 efs_filesystem_arn: Optional[pulumi.Input[str]] = None,
                 subdirectory: Optional[pulumi.Input[str]] = None,
                 tags: Optional[pulumi.Input[Sequence[pulumi.Input[pulumi.InputType['LocationEFSTagArgs']]]]] = None,
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
            __props__ = LocationEFSArgs.__new__(LocationEFSArgs)

            if ec2_config is None and not opts.urn:
                raise TypeError("Missing required property 'ec2_config'")
            __props__.__dict__["ec2_config"] = ec2_config
            if efs_filesystem_arn is None and not opts.urn:
                raise TypeError("Missing required property 'efs_filesystem_arn'")
            __props__.__dict__["efs_filesystem_arn"] = efs_filesystem_arn
            __props__.__dict__["subdirectory"] = subdirectory
            __props__.__dict__["tags"] = tags
            __props__.__dict__["location_arn"] = None
            __props__.__dict__["location_uri"] = None
        super(LocationEFS, __self__).__init__(
            'aws-native:datasync:LocationEFS',
            resource_name,
            __props__,
            opts)

    @staticmethod
    def get(resource_name: str,
            id: pulumi.Input[str],
            opts: Optional[pulumi.ResourceOptions] = None) -> 'LocationEFS':
        """
        Get an existing LocationEFS resource's state with the given name, id, and optional extra
        properties used to qualify the lookup.

        :param str resource_name: The unique name of the resulting resource.
        :param pulumi.Input[str] id: The unique provider ID of the resource to lookup.
        :param pulumi.ResourceOptions opts: Options for the resource.
        """
        opts = pulumi.ResourceOptions.merge(opts, pulumi.ResourceOptions(id=id))

        __props__ = LocationEFSArgs.__new__(LocationEFSArgs)

        __props__.__dict__["ec2_config"] = None
        __props__.__dict__["efs_filesystem_arn"] = None
        __props__.__dict__["location_arn"] = None
        __props__.__dict__["location_uri"] = None
        __props__.__dict__["subdirectory"] = None
        __props__.__dict__["tags"] = None
        return LocationEFS(resource_name, opts=opts, __props__=__props__)

    @property
    @pulumi.getter(name="ec2Config")
    def ec2_config(self) -> pulumi.Output['outputs.LocationEFSEc2Config']:
        return pulumi.get(self, "ec2_config")

    @property
    @pulumi.getter(name="efsFilesystemArn")
    def efs_filesystem_arn(self) -> pulumi.Output[str]:
        """
        The Amazon Resource Name (ARN) for the Amazon EFS file system.
        """
        return pulumi.get(self, "efs_filesystem_arn")

    @property
    @pulumi.getter(name="locationArn")
    def location_arn(self) -> pulumi.Output[str]:
        """
        The Amazon Resource Name (ARN) of the Amazon EFS file system location that is created.
        """
        return pulumi.get(self, "location_arn")

    @property
    @pulumi.getter(name="locationUri")
    def location_uri(self) -> pulumi.Output[str]:
        """
        The URL of the EFS location that was described.
        """
        return pulumi.get(self, "location_uri")

    @property
    @pulumi.getter
    def subdirectory(self) -> pulumi.Output[Optional[str]]:
        """
        A subdirectory in the location's path. This subdirectory in the EFS file system is used to read data from the EFS source location or write data to the EFS destination.
        """
        return pulumi.get(self, "subdirectory")

    @property
    @pulumi.getter
    def tags(self) -> pulumi.Output[Optional[Sequence['outputs.LocationEFSTag']]]:
        """
        An array of key-value pairs to apply to this resource.
        """
        return pulumi.get(self, "tags")

