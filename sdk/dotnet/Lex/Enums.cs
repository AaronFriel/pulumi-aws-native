// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.ComponentModel;
using Pulumi;

namespace Pulumi.AwsNative.Lex
{
    [EnumType]
    public readonly struct BotAliasStatus : IEquatable<BotAliasStatus>
    {
        private readonly string _value;

        private BotAliasStatus(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        public static BotAliasStatus Creating { get; } = new BotAliasStatus("Creating");
        public static BotAliasStatus Available { get; } = new BotAliasStatus("Available");
        public static BotAliasStatus Deleting { get; } = new BotAliasStatus("Deleting");
        public static BotAliasStatus Failed { get; } = new BotAliasStatus("Failed");

        public static bool operator ==(BotAliasStatus left, BotAliasStatus right) => left.Equals(right);
        public static bool operator !=(BotAliasStatus left, BotAliasStatus right) => !left.Equals(right);

        public static explicit operator string(BotAliasStatus value) => value._value;

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object? obj) => obj is BotAliasStatus other && Equals(other);
        public bool Equals(BotAliasStatus other) => string.Equals(_value, other._value, StringComparison.Ordinal);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;

        public override string ToString() => _value;
    }

    /// <summary>
    /// Value that determines whether Amazon Lex obscures slot values in conversation logs. The default is to obscure the values.
    /// </summary>
    [EnumType]
    public readonly struct BotObfuscationSettingObfuscationSettingType : IEquatable<BotObfuscationSettingObfuscationSettingType>
    {
        private readonly string _value;

        private BotObfuscationSettingObfuscationSettingType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        public static BotObfuscationSettingObfuscationSettingType None { get; } = new BotObfuscationSettingObfuscationSettingType("None");
        public static BotObfuscationSettingObfuscationSettingType DefaultObfuscation { get; } = new BotObfuscationSettingObfuscationSettingType("DefaultObfuscation");

        public static bool operator ==(BotObfuscationSettingObfuscationSettingType left, BotObfuscationSettingObfuscationSettingType right) => left.Equals(right);
        public static bool operator !=(BotObfuscationSettingObfuscationSettingType left, BotObfuscationSettingObfuscationSettingType right) => !left.Equals(right);

        public static explicit operator string(BotObfuscationSettingObfuscationSettingType value) => value._value;

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object? obj) => obj is BotObfuscationSettingObfuscationSettingType other && Equals(other);
        public bool Equals(BotObfuscationSettingObfuscationSettingType other) => string.Equals(_value, other._value, StringComparison.Ordinal);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;

        public override string ToString() => _value;
    }

    [EnumType]
    public readonly struct BotSlotConstraint : IEquatable<BotSlotConstraint>
    {
        private readonly string _value;

        private BotSlotConstraint(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        public static BotSlotConstraint Required { get; } = new BotSlotConstraint("Required");
        public static BotSlotConstraint Optional { get; } = new BotSlotConstraint("Optional");

        public static bool operator ==(BotSlotConstraint left, BotSlotConstraint right) => left.Equals(right);
        public static bool operator !=(BotSlotConstraint left, BotSlotConstraint right) => !left.Equals(right);

        public static explicit operator string(BotSlotConstraint value) => value._value;

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object? obj) => obj is BotSlotConstraint other && Equals(other);
        public bool Equals(BotSlotConstraint other) => string.Equals(_value, other._value, StringComparison.Ordinal);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;

        public override string ToString() => _value;
    }

    [EnumType]
    public readonly struct BotSlotValueResolutionStrategy : IEquatable<BotSlotValueResolutionStrategy>
    {
        private readonly string _value;

        private BotSlotValueResolutionStrategy(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        public static BotSlotValueResolutionStrategy OriginalValue { get; } = new BotSlotValueResolutionStrategy("ORIGINAL_VALUE");
        public static BotSlotValueResolutionStrategy TopResolution { get; } = new BotSlotValueResolutionStrategy("TOP_RESOLUTION");

        public static bool operator ==(BotSlotValueResolutionStrategy left, BotSlotValueResolutionStrategy right) => left.Equals(right);
        public static bool operator !=(BotSlotValueResolutionStrategy left, BotSlotValueResolutionStrategy right) => !left.Equals(right);

        public static explicit operator string(BotSlotValueResolutionStrategy value) => value._value;

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object? obj) => obj is BotSlotValueResolutionStrategy other && Equals(other);
        public bool Equals(BotSlotValueResolutionStrategy other) => string.Equals(_value, other._value, StringComparison.Ordinal);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;

        public override string ToString() => _value;
    }
}
