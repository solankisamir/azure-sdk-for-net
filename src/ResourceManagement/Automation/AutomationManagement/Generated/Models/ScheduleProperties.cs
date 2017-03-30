// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.

// Warning: This code was generated by a tool.
// 
// Changes to this file may cause incorrect behavior and will be lost if the
// code is regenerated.

using System;
using System.Linq;
using Microsoft.Azure.Management.Automation.Models;

namespace Microsoft.Azure.Management.Automation.Models
{
    /// <summary>
    /// Definition of schedule parameters.
    /// </summary>
    public partial class ScheduleProperties : ResourceCommonPropertiesBase
    {
        private DateTimeOffset _expiryTime;
        
        /// <summary>
        /// Optional. Gets or sets the end time of the schedule.
        /// </summary>
        public DateTimeOffset ExpiryTime
        {
            get { return this._expiryTime; }
            set { this._expiryTime = value; }
        }
        
        private string _frequency;
        
        /// <summary>
        /// Optional. Gets or sets the frequency of the schedule.
        /// </summary>
        public string Frequency
        {
            get { return this._frequency; }
            set { this._frequency = value; }
        }
        
        private byte? _interval;
        
        /// <summary>
        /// Optional. Gets or sets the interval of the schedule.
        /// </summary>
        public byte? Interval
        {
            get { return this._interval; }
            set { this._interval = value; }
        }
        
        private bool _isEnabled;
        
        /// <summary>
        /// Optional. Gets or sets a value indicating whether this schedule is
        /// enabled.
        /// </summary>
        public bool IsEnabled
        {
            get { return this._isEnabled; }
            set { this._isEnabled = value; }
        }
        
        private System.DateTimeOffset? _nextRun;
        
        /// <summary>
        /// Optional. Gets or sets the next run time of the schedule.
        /// </summary>
        public System.DateTimeOffset? NextRun
        {
            get { return this._nextRun; }
            set { this._nextRun = value; }
        }
        
        private DateTimeOffset _startTime;
        
        /// <summary>
        /// Optional. Gets or sets the start time of the schedule.
        /// </summary>
        public DateTimeOffset StartTime
        {
            get { return this._startTime; }
            set { this._startTime = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the ScheduleProperties class.
        /// </summary>
        public ScheduleProperties()
        {
        }
    }
}
