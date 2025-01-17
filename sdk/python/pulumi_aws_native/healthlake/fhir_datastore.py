# coding=utf-8
# *** WARNING: this file was generated by the Pulumi SDK Generator. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import warnings
import pulumi
import pulumi.runtime
from typing import Any, Mapping, Optional, Sequence, Union, overload
from .. import _utilities
from . import outputs
from ._enums import *
from ._inputs import *

__all__ = ['FHIRDatastoreArgs', 'FHIRDatastore']

@pulumi.input_type
class FHIRDatastoreArgs:
    def __init__(__self__, *,
                 datastore_type_version: pulumi.Input['FHIRDatastoreDatastoreTypeVersion'],
                 datastore_name: Optional[pulumi.Input[str]] = None,
                 preload_data_config: Optional[pulumi.Input['FHIRDatastorePreloadDataConfigArgs']] = None,
                 sse_configuration: Optional[pulumi.Input['FHIRDatastoreSseConfigurationArgs']] = None,
                 tags: Optional[pulumi.Input[Sequence[pulumi.Input['FHIRDatastoreTagArgs']]]] = None):
        """
        The set of arguments for constructing a FHIRDatastore resource.
        """
        pulumi.set(__self__, "datastore_type_version", datastore_type_version)
        if datastore_name is not None:
            pulumi.set(__self__, "datastore_name", datastore_name)
        if preload_data_config is not None:
            pulumi.set(__self__, "preload_data_config", preload_data_config)
        if sse_configuration is not None:
            pulumi.set(__self__, "sse_configuration", sse_configuration)
        if tags is not None:
            pulumi.set(__self__, "tags", tags)

    @property
    @pulumi.getter(name="datastoreTypeVersion")
    def datastore_type_version(self) -> pulumi.Input['FHIRDatastoreDatastoreTypeVersion']:
        return pulumi.get(self, "datastore_type_version")

    @datastore_type_version.setter
    def datastore_type_version(self, value: pulumi.Input['FHIRDatastoreDatastoreTypeVersion']):
        pulumi.set(self, "datastore_type_version", value)

    @property
    @pulumi.getter(name="datastoreName")
    def datastore_name(self) -> Optional[pulumi.Input[str]]:
        return pulumi.get(self, "datastore_name")

    @datastore_name.setter
    def datastore_name(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "datastore_name", value)

    @property
    @pulumi.getter(name="preloadDataConfig")
    def preload_data_config(self) -> Optional[pulumi.Input['FHIRDatastorePreloadDataConfigArgs']]:
        return pulumi.get(self, "preload_data_config")

    @preload_data_config.setter
    def preload_data_config(self, value: Optional[pulumi.Input['FHIRDatastorePreloadDataConfigArgs']]):
        pulumi.set(self, "preload_data_config", value)

    @property
    @pulumi.getter(name="sseConfiguration")
    def sse_configuration(self) -> Optional[pulumi.Input['FHIRDatastoreSseConfigurationArgs']]:
        return pulumi.get(self, "sse_configuration")

    @sse_configuration.setter
    def sse_configuration(self, value: Optional[pulumi.Input['FHIRDatastoreSseConfigurationArgs']]):
        pulumi.set(self, "sse_configuration", value)

    @property
    @pulumi.getter
    def tags(self) -> Optional[pulumi.Input[Sequence[pulumi.Input['FHIRDatastoreTagArgs']]]]:
        return pulumi.get(self, "tags")

    @tags.setter
    def tags(self, value: Optional[pulumi.Input[Sequence[pulumi.Input['FHIRDatastoreTagArgs']]]]):
        pulumi.set(self, "tags", value)


class FHIRDatastore(pulumi.CustomResource):
    @overload
    def __init__(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 datastore_name: Optional[pulumi.Input[str]] = None,
                 datastore_type_version: Optional[pulumi.Input['FHIRDatastoreDatastoreTypeVersion']] = None,
                 preload_data_config: Optional[pulumi.Input[pulumi.InputType['FHIRDatastorePreloadDataConfigArgs']]] = None,
                 sse_configuration: Optional[pulumi.Input[pulumi.InputType['FHIRDatastoreSseConfigurationArgs']]] = None,
                 tags: Optional[pulumi.Input[Sequence[pulumi.Input[pulumi.InputType['FHIRDatastoreTagArgs']]]]] = None,
                 __props__=None):
        """
        HealthLake FHIR Datastore

        :param str resource_name: The name of the resource.
        :param pulumi.ResourceOptions opts: Options for the resource.
        """
        ...
    @overload
    def __init__(__self__,
                 resource_name: str,
                 args: FHIRDatastoreArgs,
                 opts: Optional[pulumi.ResourceOptions] = None):
        """
        HealthLake FHIR Datastore

        :param str resource_name: The name of the resource.
        :param FHIRDatastoreArgs args: The arguments to use to populate this resource's properties.
        :param pulumi.ResourceOptions opts: Options for the resource.
        """
        ...
    def __init__(__self__, resource_name: str, *args, **kwargs):
        resource_args, opts = _utilities.get_resource_args_opts(FHIRDatastoreArgs, pulumi.ResourceOptions, *args, **kwargs)
        if resource_args is not None:
            __self__._internal_init(resource_name, opts, **resource_args.__dict__)
        else:
            __self__._internal_init(resource_name, *args, **kwargs)

    def _internal_init(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 datastore_name: Optional[pulumi.Input[str]] = None,
                 datastore_type_version: Optional[pulumi.Input['FHIRDatastoreDatastoreTypeVersion']] = None,
                 preload_data_config: Optional[pulumi.Input[pulumi.InputType['FHIRDatastorePreloadDataConfigArgs']]] = None,
                 sse_configuration: Optional[pulumi.Input[pulumi.InputType['FHIRDatastoreSseConfigurationArgs']]] = None,
                 tags: Optional[pulumi.Input[Sequence[pulumi.Input[pulumi.InputType['FHIRDatastoreTagArgs']]]]] = None,
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
            __props__ = FHIRDatastoreArgs.__new__(FHIRDatastoreArgs)

            __props__.__dict__["datastore_name"] = datastore_name
            if datastore_type_version is None and not opts.urn:
                raise TypeError("Missing required property 'datastore_type_version'")
            __props__.__dict__["datastore_type_version"] = datastore_type_version
            __props__.__dict__["preload_data_config"] = preload_data_config
            __props__.__dict__["sse_configuration"] = sse_configuration
            __props__.__dict__["tags"] = tags
            __props__.__dict__["created_at"] = None
            __props__.__dict__["datastore_arn"] = None
            __props__.__dict__["datastore_endpoint"] = None
            __props__.__dict__["datastore_id"] = None
            __props__.__dict__["datastore_status"] = None
        super(FHIRDatastore, __self__).__init__(
            'aws-native:healthlake:FHIRDatastore',
            resource_name,
            __props__,
            opts)

    @staticmethod
    def get(resource_name: str,
            id: pulumi.Input[str],
            opts: Optional[pulumi.ResourceOptions] = None) -> 'FHIRDatastore':
        """
        Get an existing FHIRDatastore resource's state with the given name, id, and optional extra
        properties used to qualify the lookup.

        :param str resource_name: The unique name of the resulting resource.
        :param pulumi.Input[str] id: The unique provider ID of the resource to lookup.
        :param pulumi.ResourceOptions opts: Options for the resource.
        """
        opts = pulumi.ResourceOptions.merge(opts, pulumi.ResourceOptions(id=id))

        __props__ = FHIRDatastoreArgs.__new__(FHIRDatastoreArgs)

        __props__.__dict__["created_at"] = None
        __props__.__dict__["datastore_arn"] = None
        __props__.__dict__["datastore_endpoint"] = None
        __props__.__dict__["datastore_id"] = None
        __props__.__dict__["datastore_name"] = None
        __props__.__dict__["datastore_status"] = None
        __props__.__dict__["datastore_type_version"] = None
        __props__.__dict__["preload_data_config"] = None
        __props__.__dict__["sse_configuration"] = None
        __props__.__dict__["tags"] = None
        return FHIRDatastore(resource_name, opts=opts, __props__=__props__)

    @property
    @pulumi.getter(name="createdAt")
    def created_at(self) -> pulumi.Output['outputs.FHIRDatastoreCreatedAt']:
        return pulumi.get(self, "created_at")

    @property
    @pulumi.getter(name="datastoreArn")
    def datastore_arn(self) -> pulumi.Output[str]:
        return pulumi.get(self, "datastore_arn")

    @property
    @pulumi.getter(name="datastoreEndpoint")
    def datastore_endpoint(self) -> pulumi.Output[str]:
        return pulumi.get(self, "datastore_endpoint")

    @property
    @pulumi.getter(name="datastoreId")
    def datastore_id(self) -> pulumi.Output[str]:
        return pulumi.get(self, "datastore_id")

    @property
    @pulumi.getter(name="datastoreName")
    def datastore_name(self) -> pulumi.Output[Optional[str]]:
        return pulumi.get(self, "datastore_name")

    @property
    @pulumi.getter(name="datastoreStatus")
    def datastore_status(self) -> pulumi.Output['FHIRDatastoreDatastoreStatus']:
        return pulumi.get(self, "datastore_status")

    @property
    @pulumi.getter(name="datastoreTypeVersion")
    def datastore_type_version(self) -> pulumi.Output['FHIRDatastoreDatastoreTypeVersion']:
        return pulumi.get(self, "datastore_type_version")

    @property
    @pulumi.getter(name="preloadDataConfig")
    def preload_data_config(self) -> pulumi.Output[Optional['outputs.FHIRDatastorePreloadDataConfig']]:
        return pulumi.get(self, "preload_data_config")

    @property
    @pulumi.getter(name="sseConfiguration")
    def sse_configuration(self) -> pulumi.Output[Optional['outputs.FHIRDatastoreSseConfiguration']]:
        return pulumi.get(self, "sse_configuration")

    @property
    @pulumi.getter
    def tags(self) -> pulumi.Output[Optional[Sequence['outputs.FHIRDatastoreTag']]]:
        return pulumi.get(self, "tags")

