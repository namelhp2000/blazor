﻿// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

namespace Microsoft.Blazor.UITree
{
    /// <summary>
    /// Supplies information about an event that is being raised.
    /// </summary>
    public class UIEventInfo
    {
        /// <summary>
        /// Gets or sets the type of the event.
        /// </summary>
        public string Type { get; set; }
    }

    /// <summary>
    /// Supplies information about a mouse event that is being raised.
    /// </summary>
    public class UIMouseEventInfo : UIEventInfo
    {
    }

    /// <summary>
    /// Supplies information about a keyboard event that is being raised.
    /// </summary>
    public class UIKeyboardEventInfo : UIEventInfo
    {
        /// <summary>
        /// If applicable, gets or sets the key that produced the event.
        /// </summary>
        public string Key { get; set; }
    }
}
