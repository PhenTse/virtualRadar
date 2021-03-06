﻿// Copyright © 2013 onwards, Andrew Whewell
// All rights reserved.
//
// Redistribution and use of this software in source and binary forms, with or without modification, are permitted provided that the following conditions are met:
//    * Redistributions of source code must retain the above copyright notice, this list of conditions and the following disclaimer.
//    * Redistributions in binary form must reproduce the above copyright notice, this list of conditions and the following disclaimer in the documentation and/or other materials provided with the distribution.
//    * Neither the name of the author nor the names of the program's contributors may be used to endorse or promote products derived from this software without specific prior written permission.
//
// THIS SOFTWARE IS PROVIDED BY THE COPYRIGHT HOLDERS AND CONTRIBUTORS "AS IS" AND ANY EXPRESS OR IMPLIED WARRANTIES, INCLUDING, BUT NOT LIMITED TO, THE IMPLIED WARRANTIES OF MERCHANTABILITY AND FITNESS FOR A PARTICULAR PURPOSE ARE DISCLAIMED. IN NO EVENT SHALL THE AUTHORS OF THE SOFTWARE BE LIABLE FOR ANY DIRECT, INDIRECT, INCIDENTAL, SPECIAL, EXEMPLARY, OR CONSEQUENTIAL DAMAGES (INCLUDING, BUT NOT LIMITED TO, PROCUREMENT OF SUBSTITUTE GOODS OR SERVICES; LOSS OF USE, DATA, OR PROFITS; OR BUSINESS INTERRUPTION) HOWEVER CAUSED AND ON ANY THEORY OF LIABILITY, WHETHER IN CONTRACT, STRICT LIABILITY, OR TORT (INCLUDING NEGLIGENCE OR OTHERWISE) ARISING IN ANY WAY OUT OF THE USE OF THIS SOFTWARE, EVEN IF ADVISED OF THE POSSIBILITY OF SUCH DAMAGE.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace VirtualRadar.Interface.WebServer
{
    /// <summary>
    /// An exception that is thrown when an exception occurs during the handling of a web server request.
    /// </summary>
    [Serializable]
    public class RequestException : Exception
    {
        /// <summary>
        /// See base docs.
        /// </summary>
        public RequestException() { }

        /// <summary>
        /// See base docs.
        /// </summary>
        /// <param name="message"></param>
        public RequestException(string message) : base(message) { }

        /// <summary>
        /// See base docs.
        /// </summary>
        /// <param name="message"></param>
        /// <param name="inner"></param>
        public RequestException(string message, Exception inner) : base(message, inner) { }

        /// <summary>
        /// See base docs.
        /// </summary>
        /// <param name="info"></param>
        /// <param name="context"></param>
        protected RequestException(SerializationInfo info, StreamingContext context) : base(info, context) { }

        /// <summary>
        /// Wraps an exception that was thrown while a request was being processed. Gives a little more information
        /// about the request that triggered the exception.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="inner"></param>
        public RequestException(IRequest request, Exception inner) : base(String.Format("Exception {{{0}: {1}}} caught during request for {{{2}}} - see inner exception for details", inner.GetType().FullName, inner.Message, request.RawUrl), inner) { }
    }
}
