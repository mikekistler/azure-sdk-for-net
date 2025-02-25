// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.ResourceMover.Models
{
    /// <summary> Defines the MoveResource states. </summary>
    public readonly partial struct MoveResourceState : IEquatable<MoveResourceState>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="MoveResourceState"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public MoveResourceState(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string AssignmentPendingValue = "AssignmentPending";
        private const string PreparePendingValue = "PreparePending";
        private const string PrepareInProgressValue = "PrepareInProgress";
        private const string PrepareFailedValue = "PrepareFailed";
        private const string MovePendingValue = "MovePending";
        private const string MoveInProgressValue = "MoveInProgress";
        private const string MoveFailedValue = "MoveFailed";
        private const string DiscardInProgressValue = "DiscardInProgress";
        private const string DiscardFailedValue = "DiscardFailed";
        private const string CommitPendingValue = "CommitPending";
        private const string CommitInProgressValue = "CommitInProgress";
        private const string CommitFailedValue = "CommitFailed";
        private const string CommittedValue = "Committed";
        private const string DeleteSourcePendingValue = "DeleteSourcePending";
        private const string ResourceMoveCompletedValue = "ResourceMoveCompleted";

        /// <summary> AssignmentPending. </summary>
        public static MoveResourceState AssignmentPending { get; } = new MoveResourceState(AssignmentPendingValue);
        /// <summary> PreparePending. </summary>
        public static MoveResourceState PreparePending { get; } = new MoveResourceState(PreparePendingValue);
        /// <summary> PrepareInProgress. </summary>
        public static MoveResourceState PrepareInProgress { get; } = new MoveResourceState(PrepareInProgressValue);
        /// <summary> PrepareFailed. </summary>
        public static MoveResourceState PrepareFailed { get; } = new MoveResourceState(PrepareFailedValue);
        /// <summary> MovePending. </summary>
        public static MoveResourceState MovePending { get; } = new MoveResourceState(MovePendingValue);
        /// <summary> MoveInProgress. </summary>
        public static MoveResourceState MoveInProgress { get; } = new MoveResourceState(MoveInProgressValue);
        /// <summary> MoveFailed. </summary>
        public static MoveResourceState MoveFailed { get; } = new MoveResourceState(MoveFailedValue);
        /// <summary> DiscardInProgress. </summary>
        public static MoveResourceState DiscardInProgress { get; } = new MoveResourceState(DiscardInProgressValue);
        /// <summary> DiscardFailed. </summary>
        public static MoveResourceState DiscardFailed { get; } = new MoveResourceState(DiscardFailedValue);
        /// <summary> CommitPending. </summary>
        public static MoveResourceState CommitPending { get; } = new MoveResourceState(CommitPendingValue);
        /// <summary> CommitInProgress. </summary>
        public static MoveResourceState CommitInProgress { get; } = new MoveResourceState(CommitInProgressValue);
        /// <summary> CommitFailed. </summary>
        public static MoveResourceState CommitFailed { get; } = new MoveResourceState(CommitFailedValue);
        /// <summary> Committed. </summary>
        public static MoveResourceState Committed { get; } = new MoveResourceState(CommittedValue);
        /// <summary> DeleteSourcePending. </summary>
        public static MoveResourceState DeleteSourcePending { get; } = new MoveResourceState(DeleteSourcePendingValue);
        /// <summary> ResourceMoveCompleted. </summary>
        public static MoveResourceState ResourceMoveCompleted { get; } = new MoveResourceState(ResourceMoveCompletedValue);
        /// <summary> Determines if two <see cref="MoveResourceState"/> values are the same. </summary>
        public static bool operator ==(MoveResourceState left, MoveResourceState right) => left.Equals(right);
        /// <summary> Determines if two <see cref="MoveResourceState"/> values are not the same. </summary>
        public static bool operator !=(MoveResourceState left, MoveResourceState right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="MoveResourceState"/>. </summary>
        public static implicit operator MoveResourceState(string value) => new MoveResourceState(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is MoveResourceState other && Equals(other);
        /// <inheritdoc />
        public bool Equals(MoveResourceState other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
