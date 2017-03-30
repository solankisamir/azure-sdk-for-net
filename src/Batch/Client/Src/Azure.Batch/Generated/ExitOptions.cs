// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

//
// This file was autogenerated by a tool.
// Do not modify it.
//

namespace Microsoft.Azure.Batch
{
    using Models = Microsoft.Azure.Batch.Protocol.Models;
    using System;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// How the Batch service should respond to a particular exit condition.
    /// </summary>
    public partial class ExitOptions : ITransportObjectProvider<Models.ExitOptions>, IPropertyMetadata
    {
        private class PropertyContainer : PropertyCollection
        {
            public readonly PropertyAccessor<Common.DependencyAction?> DependencyActionProperty;
            public readonly PropertyAccessor<Common.JobAction?> JobActionProperty;

            public PropertyContainer() : base(BindingState.Unbound)
            {
                this.DependencyActionProperty = this.CreatePropertyAccessor<Common.DependencyAction?>("DependencyAction", BindingAccess.Read | BindingAccess.Write);
                this.JobActionProperty = this.CreatePropertyAccessor<Common.JobAction?>("JobAction", BindingAccess.Read | BindingAccess.Write);
            }

            public PropertyContainer(Models.ExitOptions protocolObject) : base(BindingState.Bound)
            {
                this.DependencyActionProperty = this.CreatePropertyAccessor(
                    UtilitiesInternal.MapNullableEnum<Models.DependencyAction, Common.DependencyAction>(protocolObject.DependencyAction),
                    "DependencyAction",
                    BindingAccess.Read);
                this.JobActionProperty = this.CreatePropertyAccessor(
                    UtilitiesInternal.MapNullableEnum<Models.JobAction, Common.JobAction>(protocolObject.JobAction),
                    "JobAction",
                    BindingAccess.Read);
            }
        }

        private readonly PropertyContainer propertyContainer;

        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="ExitOptions"/> class.
        /// </summary>
        public ExitOptions()
        {
            this.propertyContainer = new PropertyContainer();
        }

        internal ExitOptions(Models.ExitOptions protocolObject)
        {
            this.propertyContainer = new PropertyContainer(protocolObject);
        }

        #endregion Constructors

        #region ExitOptions

        /// <summary>
        /// Gets or sets an action that the Batch service should take on tasks that depend on this task.
        /// </summary>
        /// <remarks>
        /// The default is <see cref="Common.DependencyAction.Satisfy"/> for exit code 0, and <see cref="Common.DependencyAction.Block"/> 
        /// for all other exit conditions. If the job's <see cref="CloudJob.UsesTaskDependencies"/> is false, you cannot 
        /// add a task with this property set.
        /// </remarks>
        public Common.DependencyAction? DependencyAction
        {
            get { return this.propertyContainer.DependencyActionProperty.Value; }
            set { this.propertyContainer.DependencyActionProperty.Value = value; }
        }

        /// <summary>
        /// Gets or sets an action to take on the job containing the task, if the task completes with the given exit condition 
        /// and the job's <see cref="CloudJob.OnTaskFailure"/> property is <see cref="Common.OnTaskFailure.PerformExitOptionsJobAction"/>.
        /// </summary>
        public Common.JobAction? JobAction
        {
            get { return this.propertyContainer.JobActionProperty.Value; }
            set { this.propertyContainer.JobActionProperty.Value = value; }
        }

        #endregion // ExitOptions

        #region IPropertyMetadata

        bool IModifiable.HasBeenModified
        {
            get { return this.propertyContainer.HasBeenModified; }
        }

        bool IReadOnly.IsReadOnly
        {
            get { return this.propertyContainer.IsReadOnly; }
            set { this.propertyContainer.IsReadOnly = value; }
        }

        #endregion //IPropertyMetadata

        #region Internal/private methods
        /// <summary>
        /// Return a protocol object of the requested type.
        /// </summary>
        /// <returns>The protocol object of the requested type.</returns>
        Models.ExitOptions ITransportObjectProvider<Models.ExitOptions>.GetTransportObject()
        {
            Models.ExitOptions result = new Models.ExitOptions()
            {
                DependencyAction = UtilitiesInternal.MapNullableEnum<Common.DependencyAction, Models.DependencyAction>(this.DependencyAction),
                JobAction = UtilitiesInternal.MapNullableEnum<Common.JobAction, Models.JobAction>(this.JobAction),
            };

            return result;
        }

        /// <summary>
        /// Converts a collection of protocol layer objects to object layer collection objects.
        /// </summary>
        internal static IList<ExitOptions> ConvertFromProtocolCollection(IEnumerable<Models.ExitOptions> protoCollection)
        {
            ConcurrentChangeTrackedModifiableList<ExitOptions> converted = UtilitiesInternal.CollectionToThreadSafeCollectionIModifiable(
                items: protoCollection,
                objectCreationFunc: o => new ExitOptions(o));

            return converted;
        }

        /// <summary>
        /// Converts a collection of protocol layer objects to object layer collection objects, in a frozen state.
        /// </summary>
        internal static IList<ExitOptions> ConvertFromProtocolCollectionAndFreeze(IEnumerable<Models.ExitOptions> protoCollection)
        {
            ConcurrentChangeTrackedModifiableList<ExitOptions> converted = UtilitiesInternal.CollectionToThreadSafeCollectionIModifiable(
                items: protoCollection,
                objectCreationFunc: o => new ExitOptions(o).Freeze());

            converted = UtilitiesInternal.CreateObjectWithNullCheck(converted, o => o.Freeze());

            return converted;
        }

        /// <summary>
        /// Converts a collection of protocol layer objects to object layer collection objects, with each object marked readonly
        /// and returned as a readonly collection.
        /// </summary>
        internal static IReadOnlyList<ExitOptions> ConvertFromProtocolCollectionReadOnly(IEnumerable<Models.ExitOptions> protoCollection)
        {
            IReadOnlyList<ExitOptions> converted =
                UtilitiesInternal.CreateObjectWithNullCheck(
                    UtilitiesInternal.CollectionToNonThreadSafeCollection(
                        items: protoCollection,
                        objectCreationFunc: o => new ExitOptions(o).Freeze()), o => o.AsReadOnly());

            return converted;
        }

        #endregion // Internal/private methods
    }
}