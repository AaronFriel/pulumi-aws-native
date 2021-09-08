# coding=utf-8
# *** WARNING: this file was generated by pulumigen. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import warnings
import pulumi
import pulumi.runtime
from typing import Any, Mapping, Optional, Sequence, Union, overload
from .. import _utilities
from . import outputs
from ._inputs import *

__all__ = ['AnomalyDetectorArgs', 'AnomalyDetector']

@pulumi.input_type
class AnomalyDetectorArgs:
    def __init__(__self__, *,
                 metric_name: pulumi.Input[str],
                 namespace: pulumi.Input[str],
                 stat: pulumi.Input[str],
                 configuration: Optional[pulumi.Input['AnomalyDetectorConfigurationArgs']] = None,
                 dimensions: Optional[pulumi.Input[Sequence[pulumi.Input['AnomalyDetectorDimensionArgs']]]] = None):
        """
        The set of arguments for constructing a AnomalyDetector resource.
        :param pulumi.Input[str] metric_name: http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cloudwatch-anomalydetector.html#cfn-cloudwatch-anomalydetector-metricname
        :param pulumi.Input[str] namespace: http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cloudwatch-anomalydetector.html#cfn-cloudwatch-anomalydetector-namespace
        :param pulumi.Input[str] stat: http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cloudwatch-anomalydetector.html#cfn-cloudwatch-anomalydetector-stat
        :param pulumi.Input['AnomalyDetectorConfigurationArgs'] configuration: http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cloudwatch-anomalydetector.html#cfn-cloudwatch-anomalydetector-configuration
        :param pulumi.Input[Sequence[pulumi.Input['AnomalyDetectorDimensionArgs']]] dimensions: http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cloudwatch-anomalydetector.html#cfn-cloudwatch-anomalydetector-dimensions
        """
        pulumi.set(__self__, "metric_name", metric_name)
        pulumi.set(__self__, "namespace", namespace)
        pulumi.set(__self__, "stat", stat)
        if configuration is not None:
            pulumi.set(__self__, "configuration", configuration)
        if dimensions is not None:
            pulumi.set(__self__, "dimensions", dimensions)

    @property
    @pulumi.getter(name="metricName")
    def metric_name(self) -> pulumi.Input[str]:
        """
        http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cloudwatch-anomalydetector.html#cfn-cloudwatch-anomalydetector-metricname
        """
        return pulumi.get(self, "metric_name")

    @metric_name.setter
    def metric_name(self, value: pulumi.Input[str]):
        pulumi.set(self, "metric_name", value)

    @property
    @pulumi.getter
    def namespace(self) -> pulumi.Input[str]:
        """
        http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cloudwatch-anomalydetector.html#cfn-cloudwatch-anomalydetector-namespace
        """
        return pulumi.get(self, "namespace")

    @namespace.setter
    def namespace(self, value: pulumi.Input[str]):
        pulumi.set(self, "namespace", value)

    @property
    @pulumi.getter
    def stat(self) -> pulumi.Input[str]:
        """
        http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cloudwatch-anomalydetector.html#cfn-cloudwatch-anomalydetector-stat
        """
        return pulumi.get(self, "stat")

    @stat.setter
    def stat(self, value: pulumi.Input[str]):
        pulumi.set(self, "stat", value)

    @property
    @pulumi.getter
    def configuration(self) -> Optional[pulumi.Input['AnomalyDetectorConfigurationArgs']]:
        """
        http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cloudwatch-anomalydetector.html#cfn-cloudwatch-anomalydetector-configuration
        """
        return pulumi.get(self, "configuration")

    @configuration.setter
    def configuration(self, value: Optional[pulumi.Input['AnomalyDetectorConfigurationArgs']]):
        pulumi.set(self, "configuration", value)

    @property
    @pulumi.getter
    def dimensions(self) -> Optional[pulumi.Input[Sequence[pulumi.Input['AnomalyDetectorDimensionArgs']]]]:
        """
        http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cloudwatch-anomalydetector.html#cfn-cloudwatch-anomalydetector-dimensions
        """
        return pulumi.get(self, "dimensions")

    @dimensions.setter
    def dimensions(self, value: Optional[pulumi.Input[Sequence[pulumi.Input['AnomalyDetectorDimensionArgs']]]]):
        pulumi.set(self, "dimensions", value)


class AnomalyDetector(pulumi.CustomResource):
    @overload
    def __init__(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 configuration: Optional[pulumi.Input[pulumi.InputType['AnomalyDetectorConfigurationArgs']]] = None,
                 dimensions: Optional[pulumi.Input[Sequence[pulumi.Input[pulumi.InputType['AnomalyDetectorDimensionArgs']]]]] = None,
                 metric_name: Optional[pulumi.Input[str]] = None,
                 namespace: Optional[pulumi.Input[str]] = None,
                 stat: Optional[pulumi.Input[str]] = None,
                 __props__=None):
        """
        http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cloudwatch-anomalydetector.html

        :param str resource_name: The name of the resource.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[pulumi.InputType['AnomalyDetectorConfigurationArgs']] configuration: http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cloudwatch-anomalydetector.html#cfn-cloudwatch-anomalydetector-configuration
        :param pulumi.Input[Sequence[pulumi.Input[pulumi.InputType['AnomalyDetectorDimensionArgs']]]] dimensions: http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cloudwatch-anomalydetector.html#cfn-cloudwatch-anomalydetector-dimensions
        :param pulumi.Input[str] metric_name: http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cloudwatch-anomalydetector.html#cfn-cloudwatch-anomalydetector-metricname
        :param pulumi.Input[str] namespace: http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cloudwatch-anomalydetector.html#cfn-cloudwatch-anomalydetector-namespace
        :param pulumi.Input[str] stat: http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cloudwatch-anomalydetector.html#cfn-cloudwatch-anomalydetector-stat
        """
        ...
    @overload
    def __init__(__self__,
                 resource_name: str,
                 args: AnomalyDetectorArgs,
                 opts: Optional[pulumi.ResourceOptions] = None):
        """
        http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cloudwatch-anomalydetector.html

        :param str resource_name: The name of the resource.
        :param AnomalyDetectorArgs args: The arguments to use to populate this resource's properties.
        :param pulumi.ResourceOptions opts: Options for the resource.
        """
        ...
    def __init__(__self__, resource_name: str, *args, **kwargs):
        resource_args, opts = _utilities.get_resource_args_opts(AnomalyDetectorArgs, pulumi.ResourceOptions, *args, **kwargs)
        if resource_args is not None:
            __self__._internal_init(resource_name, opts, **resource_args.__dict__)
        else:
            __self__._internal_init(resource_name, *args, **kwargs)

    def _internal_init(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 configuration: Optional[pulumi.Input[pulumi.InputType['AnomalyDetectorConfigurationArgs']]] = None,
                 dimensions: Optional[pulumi.Input[Sequence[pulumi.Input[pulumi.InputType['AnomalyDetectorDimensionArgs']]]]] = None,
                 metric_name: Optional[pulumi.Input[str]] = None,
                 namespace: Optional[pulumi.Input[str]] = None,
                 stat: Optional[pulumi.Input[str]] = None,
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
            __props__ = AnomalyDetectorArgs.__new__(AnomalyDetectorArgs)

            __props__.__dict__["configuration"] = configuration
            __props__.__dict__["dimensions"] = dimensions
            if metric_name is None and not opts.urn:
                raise TypeError("Missing required property 'metric_name'")
            __props__.__dict__["metric_name"] = metric_name
            if namespace is None and not opts.urn:
                raise TypeError("Missing required property 'namespace'")
            __props__.__dict__["namespace"] = namespace
            if stat is None and not opts.urn:
                raise TypeError("Missing required property 'stat'")
            __props__.__dict__["stat"] = stat
        super(AnomalyDetector, __self__).__init__(
            'aws-native:cloudwatch:AnomalyDetector',
            resource_name,
            __props__,
            opts)

    @staticmethod
    def get(resource_name: str,
            id: pulumi.Input[str],
            opts: Optional[pulumi.ResourceOptions] = None) -> 'AnomalyDetector':
        """
        Get an existing AnomalyDetector resource's state with the given name, id, and optional extra
        properties used to qualify the lookup.

        :param str resource_name: The unique name of the resulting resource.
        :param pulumi.Input[str] id: The unique provider ID of the resource to lookup.
        :param pulumi.ResourceOptions opts: Options for the resource.
        """
        opts = pulumi.ResourceOptions.merge(opts, pulumi.ResourceOptions(id=id))

        __props__ = AnomalyDetectorArgs.__new__(AnomalyDetectorArgs)

        __props__.__dict__["configuration"] = None
        __props__.__dict__["dimensions"] = None
        __props__.__dict__["metric_name"] = None
        __props__.__dict__["namespace"] = None
        __props__.__dict__["stat"] = None
        return AnomalyDetector(resource_name, opts=opts, __props__=__props__)

    @property
    @pulumi.getter
    def configuration(self) -> pulumi.Output[Optional['outputs.AnomalyDetectorConfiguration']]:
        """
        http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cloudwatch-anomalydetector.html#cfn-cloudwatch-anomalydetector-configuration
        """
        return pulumi.get(self, "configuration")

    @property
    @pulumi.getter
    def dimensions(self) -> pulumi.Output[Optional[Sequence['outputs.AnomalyDetectorDimension']]]:
        """
        http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cloudwatch-anomalydetector.html#cfn-cloudwatch-anomalydetector-dimensions
        """
        return pulumi.get(self, "dimensions")

    @property
    @pulumi.getter(name="metricName")
    def metric_name(self) -> pulumi.Output[str]:
        """
        http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cloudwatch-anomalydetector.html#cfn-cloudwatch-anomalydetector-metricname
        """
        return pulumi.get(self, "metric_name")

    @property
    @pulumi.getter
    def namespace(self) -> pulumi.Output[str]:
        """
        http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cloudwatch-anomalydetector.html#cfn-cloudwatch-anomalydetector-namespace
        """
        return pulumi.get(self, "namespace")

    @property
    @pulumi.getter
    def stat(self) -> pulumi.Output[str]:
        """
        http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cloudwatch-anomalydetector.html#cfn-cloudwatch-anomalydetector-stat
        """
        return pulumi.get(self, "stat")
