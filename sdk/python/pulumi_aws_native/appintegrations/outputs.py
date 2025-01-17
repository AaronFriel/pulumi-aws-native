# coding=utf-8
# *** WARNING: this file was generated by the Pulumi SDK Generator. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import warnings
import pulumi
import pulumi.runtime
from typing import Any, Mapping, Optional, Sequence, Union, overload
from .. import _utilities
from . import outputs

__all__ = [
    'EventIntegrationAssociation',
    'EventIntegrationEventFilter',
    'EventIntegrationMetadata',
    'EventIntegrationTag',
]

@pulumi.output_type
class EventIntegrationAssociation(dict):
    @staticmethod
    def __key_warning(key: str):
        suggest = None
        if key == "clientAssociationMetadata":
            suggest = "client_association_metadata"
        elif key == "clientId":
            suggest = "client_id"
        elif key == "eventBridgeRuleName":
            suggest = "event_bridge_rule_name"
        elif key == "eventIntegrationAssociationArn":
            suggest = "event_integration_association_arn"
        elif key == "eventIntegrationAssociationId":
            suggest = "event_integration_association_id"

        if suggest:
            pulumi.log.warn(f"Key '{key}' not found in EventIntegrationAssociation. Access the value via the '{suggest}' property getter instead.")

    def __getitem__(self, key: str) -> Any:
        EventIntegrationAssociation.__key_warning(key)
        return super().__getitem__(key)

    def get(self, key: str, default = None) -> Any:
        EventIntegrationAssociation.__key_warning(key)
        return super().get(key, default)

    def __init__(__self__, *,
                 client_association_metadata: Optional[Sequence['outputs.EventIntegrationMetadata']] = None,
                 client_id: Optional[str] = None,
                 event_bridge_rule_name: Optional[str] = None,
                 event_integration_association_arn: Optional[str] = None,
                 event_integration_association_id: Optional[str] = None):
        """
        :param Sequence['EventIntegrationMetadata'] client_association_metadata: The metadata associated with the client.
        :param str client_id: The identifier for the client that is associated with the event integration.
        :param str event_bridge_rule_name: The name of the Eventbridge rule.
        :param str event_integration_association_arn: The Amazon Resource Name (ARN) for the event integration association.
        :param str event_integration_association_id: The identifier for the event integration association.
        """
        if client_association_metadata is not None:
            pulumi.set(__self__, "client_association_metadata", client_association_metadata)
        if client_id is not None:
            pulumi.set(__self__, "client_id", client_id)
        if event_bridge_rule_name is not None:
            pulumi.set(__self__, "event_bridge_rule_name", event_bridge_rule_name)
        if event_integration_association_arn is not None:
            pulumi.set(__self__, "event_integration_association_arn", event_integration_association_arn)
        if event_integration_association_id is not None:
            pulumi.set(__self__, "event_integration_association_id", event_integration_association_id)

    @property
    @pulumi.getter(name="clientAssociationMetadata")
    def client_association_metadata(self) -> Optional[Sequence['outputs.EventIntegrationMetadata']]:
        """
        The metadata associated with the client.
        """
        return pulumi.get(self, "client_association_metadata")

    @property
    @pulumi.getter(name="clientId")
    def client_id(self) -> Optional[str]:
        """
        The identifier for the client that is associated with the event integration.
        """
        return pulumi.get(self, "client_id")

    @property
    @pulumi.getter(name="eventBridgeRuleName")
    def event_bridge_rule_name(self) -> Optional[str]:
        """
        The name of the Eventbridge rule.
        """
        return pulumi.get(self, "event_bridge_rule_name")

    @property
    @pulumi.getter(name="eventIntegrationAssociationArn")
    def event_integration_association_arn(self) -> Optional[str]:
        """
        The Amazon Resource Name (ARN) for the event integration association.
        """
        return pulumi.get(self, "event_integration_association_arn")

    @property
    @pulumi.getter(name="eventIntegrationAssociationId")
    def event_integration_association_id(self) -> Optional[str]:
        """
        The identifier for the event integration association.
        """
        return pulumi.get(self, "event_integration_association_id")


@pulumi.output_type
class EventIntegrationEventFilter(dict):
    def __init__(__self__, *,
                 source: str):
        """
        :param str source: The source of the events.
        """
        pulumi.set(__self__, "source", source)

    @property
    @pulumi.getter
    def source(self) -> str:
        """
        The source of the events.
        """
        return pulumi.get(self, "source")


@pulumi.output_type
class EventIntegrationMetadata(dict):
    def __init__(__self__, *,
                 key: str,
                 value: str):
        """
        :param str key: A key to identify the metadata.
        :param str value: Corresponding metadata value for the key.
        """
        pulumi.set(__self__, "key", key)
        pulumi.set(__self__, "value", value)

    @property
    @pulumi.getter
    def key(self) -> str:
        """
        A key to identify the metadata.
        """
        return pulumi.get(self, "key")

    @property
    @pulumi.getter
    def value(self) -> str:
        """
        Corresponding metadata value for the key.
        """
        return pulumi.get(self, "value")


@pulumi.output_type
class EventIntegrationTag(dict):
    def __init__(__self__, *,
                 key: str,
                 value: str):
        """
        :param str key: A key to identify the tag.
        :param str value: Corresponding tag value for the key.
        """
        pulumi.set(__self__, "key", key)
        pulumi.set(__self__, "value", value)

    @property
    @pulumi.getter
    def key(self) -> str:
        """
        A key to identify the tag.
        """
        return pulumi.get(self, "key")

    @property
    @pulumi.getter
    def value(self) -> str:
        """
        Corresponding tag value for the key.
        """
        return pulumi.get(self, "value")


