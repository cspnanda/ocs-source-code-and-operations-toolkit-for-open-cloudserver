// Copyright (c) Microsoft Corporation
// All rights reserved. 
//
// MIT License
//
// Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated 
// documentation files (the "Software"), to deal in the Software without restriction, including without limitation 
// the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and 
// to permit persons to whom the Software is furnished to do so, subject to the following conditions:
// The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED *AS IS*, WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING 
// BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND 
// NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, 
// DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, 
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE. 

namespace Microsoft.GFS.WCS.ChassisManager.Ipmi
{
    using System;

    /// <summary>
    /// Defines data with an IPMI message.
    /// </summary>
    [AttributeUsage(AttributeTargets.Property, AllowMultiple = false)]
    internal sealed class IpmiMessageDataAttribute : Attribute
    {
        /// <summary>
        /// Byte offset into the IPMI message data stream this property begins at.
        /// </summary>
        private readonly int offset;

        /// <summary>
        /// Length of the data item or 0 to based on the property's type.
        /// </summary>
        private readonly int length;

        /// <summary>
        /// Initializes a new instance of the IpmiMessageDataAttribute class.
        /// </summary>
        /// <param name="offset">Byte offset into the IPMI message data stream.</param>
        public IpmiMessageDataAttribute(int offset)
            : this(offset, 0)
        {
        }

        /// <summary>
        /// Initializes a new instance of the IpmiMessageDataAttribute class.
        /// </summary>
        /// <param name="offset">Byte offset into the IPMI message data stream.</param>
        /// <param name="length">Length of the data item or 0 to based on the property's type.</param>
        public IpmiMessageDataAttribute(int offset, int length)
        {
            this.offset = offset;
            this.length = length;
        }

        /// <summary>
        /// Gets the byte offset into the IPMI message data stream.
        /// </summary>
        public int Offset
        {
            get { return this.offset; }
        }

        /// <summary>
        /// Gets the length of the data or 0 to based on the property's type.
        /// </summary>
        public int Length
        {
            get { return this.length; }
        }
    }
}
