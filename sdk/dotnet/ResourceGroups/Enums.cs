// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.ComponentModel;
using Pulumi;

namespace Pulumi.AwsNative.ResourceGroups
{
    [EnumType]
    public readonly struct GroupResourceQueryType : IEquatable<GroupResourceQueryType>
    {
        private readonly string _value;

        private GroupResourceQueryType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        public static GroupResourceQueryType TagFilters10 { get; } = new GroupResourceQueryType("TAG_FILTERS_1_0");
        public static GroupResourceQueryType CloudformationStack10 { get; } = new GroupResourceQueryType("CLOUDFORMATION_STACK_1_0");

        public static bool operator ==(GroupResourceQueryType left, GroupResourceQueryType right) => left.Equals(right);
        public static bool operator !=(GroupResourceQueryType left, GroupResourceQueryType right) => !left.Equals(right);

        public static explicit operator string(GroupResourceQueryType value) => value._value;

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object? obj) => obj is GroupResourceQueryType other && Equals(other);
        public bool Equals(GroupResourceQueryType other) => string.Equals(_value, other._value, StringComparison.Ordinal);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;

        public override string ToString() => _value;
    }
}
