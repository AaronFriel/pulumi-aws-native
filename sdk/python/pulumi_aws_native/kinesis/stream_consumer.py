# coding=utf-8
# *** WARNING: this file was generated by the Pulumi SDK Generator. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import warnings
import pulumi
import pulumi.runtime
from typing import Any, Mapping, Optional, Sequence, Union, overload
from .. import _utilities

__all__ = ['StreamConsumerArgs', 'StreamConsumer']

@pulumi.input_type
class StreamConsumerArgs:
    def __init__(__self__, *,
                 consumer_name: pulumi.Input[str],
                 stream_arn: pulumi.Input[str]):
        """
        The set of arguments for constructing a StreamConsumer resource.
        """
        pulumi.set(__self__, "consumer_name", consumer_name)
        pulumi.set(__self__, "stream_arn", stream_arn)

    @property
    @pulumi.getter(name="consumerName")
    def consumer_name(self) -> pulumi.Input[str]:
        return pulumi.get(self, "consumer_name")

    @consumer_name.setter
    def consumer_name(self, value: pulumi.Input[str]):
        pulumi.set(self, "consumer_name", value)

    @property
    @pulumi.getter(name="streamARN")
    def stream_arn(self) -> pulumi.Input[str]:
        return pulumi.get(self, "stream_arn")

    @stream_arn.setter
    def stream_arn(self, value: pulumi.Input[str]):
        pulumi.set(self, "stream_arn", value)


warnings.warn("""StreamConsumer is not yet supported by AWS Native, so its creation will currently fail. Please use the classic AWS provider, if possible.""", DeprecationWarning)


class StreamConsumer(pulumi.CustomResource):
    warnings.warn("""StreamConsumer is not yet supported by AWS Native, so its creation will currently fail. Please use the classic AWS provider, if possible.""", DeprecationWarning)

    @overload
    def __init__(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 consumer_name: Optional[pulumi.Input[str]] = None,
                 stream_arn: Optional[pulumi.Input[str]] = None,
                 __props__=None):
        """
        Resource Type definition for AWS::Kinesis::StreamConsumer

        :param str resource_name: The name of the resource.
        :param pulumi.ResourceOptions opts: Options for the resource.
        """
        ...
    @overload
    def __init__(__self__,
                 resource_name: str,
                 args: StreamConsumerArgs,
                 opts: Optional[pulumi.ResourceOptions] = None):
        """
        Resource Type definition for AWS::Kinesis::StreamConsumer

        :param str resource_name: The name of the resource.
        :param StreamConsumerArgs args: The arguments to use to populate this resource's properties.
        :param pulumi.ResourceOptions opts: Options for the resource.
        """
        ...
    def __init__(__self__, resource_name: str, *args, **kwargs):
        resource_args, opts = _utilities.get_resource_args_opts(StreamConsumerArgs, pulumi.ResourceOptions, *args, **kwargs)
        if resource_args is not None:
            __self__._internal_init(resource_name, opts, **resource_args.__dict__)
        else:
            __self__._internal_init(resource_name, *args, **kwargs)

    def _internal_init(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 consumer_name: Optional[pulumi.Input[str]] = None,
                 stream_arn: Optional[pulumi.Input[str]] = None,
                 __props__=None):
        pulumi.log.warn("""StreamConsumer is deprecated: StreamConsumer is not yet supported by AWS Native, so its creation will currently fail. Please use the classic AWS provider, if possible.""")
        if opts is None:
            opts = pulumi.ResourceOptions()
        if not isinstance(opts, pulumi.ResourceOptions):
            raise TypeError('Expected resource options to be a ResourceOptions instance')
        if opts.version is None:
            opts.version = _utilities.get_version()
        if opts.id is None:
            if __props__ is not None:
                raise TypeError('__props__ is only valid when passed in combination with a valid opts.id to get an existing resource')
            __props__ = StreamConsumerArgs.__new__(StreamConsumerArgs)

            if consumer_name is None and not opts.urn:
                raise TypeError("Missing required property 'consumer_name'")
            __props__.__dict__["consumer_name"] = consumer_name
            if stream_arn is None and not opts.urn:
                raise TypeError("Missing required property 'stream_arn'")
            __props__.__dict__["stream_arn"] = stream_arn
            __props__.__dict__["consumer_arn"] = None
            __props__.__dict__["consumer_creation_timestamp"] = None
            __props__.__dict__["consumer_status"] = None
        super(StreamConsumer, __self__).__init__(
            'aws-native:kinesis:StreamConsumer',
            resource_name,
            __props__,
            opts)

    @staticmethod
    def get(resource_name: str,
            id: pulumi.Input[str],
            opts: Optional[pulumi.ResourceOptions] = None) -> 'StreamConsumer':
        """
        Get an existing StreamConsumer resource's state with the given name, id, and optional extra
        properties used to qualify the lookup.

        :param str resource_name: The unique name of the resulting resource.
        :param pulumi.Input[str] id: The unique provider ID of the resource to lookup.
        :param pulumi.ResourceOptions opts: Options for the resource.
        """
        opts = pulumi.ResourceOptions.merge(opts, pulumi.ResourceOptions(id=id))

        __props__ = StreamConsumerArgs.__new__(StreamConsumerArgs)

        __props__.__dict__["consumer_arn"] = None
        __props__.__dict__["consumer_creation_timestamp"] = None
        __props__.__dict__["consumer_name"] = None
        __props__.__dict__["consumer_status"] = None
        __props__.__dict__["stream_arn"] = None
        return StreamConsumer(resource_name, opts=opts, __props__=__props__)

    @property
    @pulumi.getter(name="consumerARN")
    def consumer_arn(self) -> pulumi.Output[str]:
        return pulumi.get(self, "consumer_arn")

    @property
    @pulumi.getter(name="consumerCreationTimestamp")
    def consumer_creation_timestamp(self) -> pulumi.Output[str]:
        return pulumi.get(self, "consumer_creation_timestamp")

    @property
    @pulumi.getter(name="consumerName")
    def consumer_name(self) -> pulumi.Output[str]:
        return pulumi.get(self, "consumer_name")

    @property
    @pulumi.getter(name="consumerStatus")
    def consumer_status(self) -> pulumi.Output[str]:
        return pulumi.get(self, "consumer_status")

    @property
    @pulumi.getter(name="streamARN")
    def stream_arn(self) -> pulumi.Output[str]:
        return pulumi.get(self, "stream_arn")

