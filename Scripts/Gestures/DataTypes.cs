﻿/**
* Copyright 2015 IBM Corp. All Rights Reserved.
*
* Licensed under the Apache License, Version 2.0 (the "License");
* you may not use this file except in compliance with the License.
* You may obtain a copy of the License at
*
*      http://www.apache.org/licenses/LICENSE-2.0
*
* Unless required by applicable law or agreed to in writing, software
* distributed under the License is distributed on an "AS IS" BASIS,
* WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
* See the License for the specific language governing permissions and
* limitations under the License.
*
*/

using IBM.Watson.DeveloperCloud.Widgets;

namespace IBM.Watson.Self.Gestures
{
    /// <summary>
    /// This data class is for status data output by the SelfStatusGesture.
    /// </summary>
    public class StatusData : Widget.Data
    {
        /// <summary>
        /// Default constructor.
        /// </summary>
        public StatusData()
        { }
        /// <summary>
        /// String constructor.
        /// </summary>
        /// <param name="text"></param>
        public StatusData(string status)
        {
            Status = status;
        }
        /// <summary>
        /// Name of this data type.
        /// </summary>
        /// <returns>A human readable name for this data type.</returns>
        public override string GetName()
        {
            return "StatusData";
        }

        /// <summary>
        /// The text to convert to speech.
        /// </summary>
        public string Status { get; set; }
    };
}