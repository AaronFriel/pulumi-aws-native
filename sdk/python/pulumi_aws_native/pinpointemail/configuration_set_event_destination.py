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

__all__ = ['ConfigurationSetEventDestinationArgs', 'ConfigurationSetEventDestination']

@pulumi.input_type
class ConfigurationSetEventDestinationArgs:
    def __init__(__self__, *,
                 configuration_set_name: pulumi.Input[str],
                 event_destination_name: pulumi.Input[str],
                 event_destination: Optional[pulumi.Input['ConfigurationSetEventDestinationEventDestinationArgs']] = None):
        """
        The set of arguments for constructing a ConfigurationSetEventDestination resource.
        """
        pulumi.set(__self__, "configuration_set_name", configuration_set_name)
        pulumi.set(__self__, "event_destination_name", event_destination_name)
        if event_destination is not None:
            pulumi.set(__self__, "event_destination", event_destination)

    @property
    @pulumi.getter(name="configurationSetName")
    def configuration_set_name(self) -> pulumi.Input[str]:
        return pulumi.get(self, "configuration_set_name")

    @configuration_set_name.setter
    def configuration_set_name(self, value: pulumi.Input[str]):
        pulumi.set(self, "configuration_set_name", value)

    @property
    @pulumi.getter(name="eventDestinationName")
    def event_destination_name(self) -> pulumi.Input[str]:
        return pulumi.get(self, "event_destination_name")

    @event_destination_name.setter
    def event_destination_name(self, value: pulumi.Input[str]):
        pulumi.set(self, "event_destination_name", value)

    @property
    @pulumi.getter(name="eventDestination")
    def event_destination(self) -> Optional[pulumi.Input['ConfigurationSetEventDestinationEventDestinationArgs']]:
        return pulumi.get(self, "event_destination")

    @event_destination.setter
    def event_destination(self, value: Optional[pulumi.Input['ConfigurationSetEventDestinationEventDestinationArgs']]):
        pulumi.set(self, "event_destination", value)


warnings.warn("""ConfigurationSetEventDestination is not yet supported by AWS Cloud Control API, so its creation will currently fail. Please use the classic AWS provider, if possible.""", DeprecationWarning)


class ConfigurationSetEventDestination(pulumi.CustomResource):
    warnings.warn("""ConfigurationSetEventDestination is not yet supported by AWS Cloud Control API, so its creation will currently fail. Please use the classic AWS provider, if possible.""", DeprecationWarning)

    @overload
    def __init__(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 configuration_set_name: Optional[pulumi.Input[str]] = None,
                 event_destination: Optional[pulumi.Input[pulumi.InputType['ConfigurationSetEventDestinationEventDestinationArgs']]] = None,
                 event_destination_name: Optional[pulumi.Input[str]] = None,
                 __props__=None):
        """
        Resource Type definition for AWS::PinpointEmail::ConfigurationSetEventDestination

        :param str resource_name: The name of the resource.
        :param pulumi.ResourceOptions opts: Options for the resource.
        """
        ...
    @overload
    def __init__(__self__,
                 resource_name: str,
                 args: ConfigurationSetEventDestinationArgs,
                 opts: Optional[pulumi.ResourceOptions] = None):
        """
        Resource Type definition for AWS::PinpointEmail::ConfigurationSetEventDestination

        :param str resource_name: The name of the resource.
        :param ConfigurationSetEventDestinationArgs args: The arguments to use to populate this resource's properties.
        :param pulumi.ResourceOptions opts: Options for the resource.
        """
        ...
    def __init__(__self__, resource_name: str, *args, **kwargs):
        resource_args, opts = _utilities.get_resource_args_opts(ConfigurationSetEventDestinationArgs, pulumi.ResourceOptions, *args, **kwargs)
        if resource_args is not None:
            __self__._internal_init(resource_name, opts, **resource_args.__dict__)
        else:
            __self__._internal_init(resource_name, *args, **kwargs)

    def _internal_init(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 configuration_set_name: Optional[pulumi.Input[str]] = None,
                 event_destination: Optional[pulumi.Input[pulumi.InputType['ConfigurationSetEventDestinationEventDestinationArgs']]] = None,
                 event_destination_name: Optional[pulumi.Input[str]] = None,
                 __props__=None):
        pulumi.log.warn("""ConfigurationSetEventDestination is deprecated: ConfigurationSetEventDestination is not yet supported by AWS Cloud Control API, so its creation will currently fail. Please use the classic AWS provider, if possible.""")
        if opts is None:
            opts = pulumi.ResourceOptions()
        if not isinstance(opts, pulumi.ResourceOptions):
            raise TypeError('Expected resource options to be a ResourceOptions instance')
        if opts.version is None:
            opts.version = _utilities.get_version()
        if opts.id is None:
            if __props__ is not None:
                raise TypeError('__props__ is only valid when passed in combination with a valid opts.id to get an existing resource')
            __props__ = ConfigurationSetEventDestinationArgs.__new__(ConfigurationSetEventDestinationArgs)

            if configuration_set_name is None and not opts.urn:
                raise TypeError("Missing required property 'configuration_set_name'")
            __props__.__dict__["configuration_set_name"] = configuration_set_name
            __props__.__dict__["event_destination"] = event_destination
            if event_destination_name is None and not opts.urn:
                raise TypeError("Missing required property 'event_destination_name'")
            __props__.__dict__["event_destination_name"] = event_destination_name
        super(ConfigurationSetEventDestination, __self__).__init__(
            'aws-native:pinpointemail:ConfigurationSetEventDestination',
            resource_name,
            __props__,
            opts)

    @staticmethod
    def get(resource_name: str,
            id: pulumi.Input[str],
            opts: Optional[pulumi.ResourceOptions] = None) -> 'ConfigurationSetEventDestination':
        """
        Get an existing ConfigurationSetEventDestination resource's state with the given name, id, and optional extra
        properties used to qualify the lookup.

        :param str resource_name: The unique name of the resulting resource.
        :param pulumi.Input[str] id: The unique provider ID of the resource to lookup.
        :param pulumi.ResourceOptions opts: Options for the resource.
        """
        opts = pulumi.ResourceOptions.merge(opts, pulumi.ResourceOptions(id=id))

        __props__ = ConfigurationSetEventDestinationArgs.__new__(ConfigurationSetEventDestinationArgs)

        __props__.__dict__["configuration_set_name"] = None
        __props__.__dict__["event_destination"] = None
        __props__.__dict__["event_destination_name"] = None
        return ConfigurationSetEventDestination(resource_name, opts=opts, __props__=__props__)

    @property
    @pulumi.getter(name="configurationSetName")
    def configuration_set_name(self) -> pulumi.Output[str]:
        return pulumi.get(self, "configuration_set_name")

    @property
    @pulumi.getter(name="eventDestination")
    def event_destination(self) -> pulumi.Output[Optional['outputs.ConfigurationSetEventDestinationEventDestination']]:
        return pulumi.get(self, "event_destination")

    @property
    @pulumi.getter(name="eventDestinationName")
    def event_destination_name(self) -> pulumi.Output[str]:
        return pulumi.get(self, "event_destination_name")

