#region License
/*Copyright(c) 2018, Brian Humlicek
* https://github.com/BrianHumlicek
* 
*Permission is hereby granted, free of charge, to any person obtaining a copy
*of this software and associated documentation files (the "Software"), to deal
*in the Software without restriction, including without limitation the rights
*to use, copy, modify, merge, publish, distribute, sub-license, and/or sell
*copies of the Software, and to permit persons to whom the Software is
*furnished to do so, subject to the following conditions:
*The above copyright notice and this permission notice shall be included in all
*copies or substantial portions of the Software.
*
*THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
*IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
*FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
*AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
*LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
*OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
*SOFTWARE.
*/
/* 
 * Copyright (c) 2010, Michael Kelly
 * michael.e.kelly@gmail.com
 * http://michael-kelly.com/
 * 
 * All rights reserved.
 * Redistribution and use in source and binary forms, with or without modification, are permitted provided that the following conditions are met:
 * Redistributions of source code must retain the above copyright notice, this list of conditions and the following disclaimer.
 * Redistributions in binary form must reproduce the above copyright notice, this list of conditions and the following disclaimer in the documentation and/or other materials provided with the distribution.
 * Neither the name of the organization nor the names of its contributors may be used to endorse or promote products derived from this software without specific prior written permission.
 * 
 * THIS SOFTWARE IS PROVIDED BY THE COPYRIGHT HOLDERS AND CONTRIBUTORS
 * "AS IS" AND ANY EXPRESS OR IMPLIED WARRANTIES, INCLUDING, BUT NOT
 * LIMITED TO, THE IMPLIED WARRANTIES OF MERCHANTABILITY AND FITNESS FOR
 * A PARTICULAR PURPOSE ARE DISCLAIMED. IN NO EVENT SHALL THE COPYRIGHT OWNER OR
 * CONTRIBUTORS BE LIABLE FOR ANY DIRECT, INDIRECT, INCIDENTAL, SPECIAL,
 * EXEMPLARY, OR CONSEQUENTIAL DAMAGES (INCLUDING, BUT NOT LIMITED TO,
 * PROCUREMENT OF SUBSTITUTE GOODS OR SERVICES; LOSS OF USE, DATA, OR
 * PROFITS; OR BUSINESS INTERRUPTION) HOWEVER CAUSED AND ON ANY THEORY OF
 * LIABILITY, WHETHER IN CONTRACT, STRICT LIABILITY, OR TORT (INCLUDING
 * NEGLIGENCE OR OTHERWISE) ARISING IN ANY WAY OUT OF THE USE OF THIS
 * SOFTWARE, EVEN IF ADVISED OF THE POSSIBILITY OF SUCH DAMAGE.
 * 
 */
#endregion License
using System;

namespace SAE.J2534
{
    /// <summary>
    /// Message transmit flags
    /// </summary>
    [Flags]
    public enum TxFlag
    {
        /// <summary>No flag</summary>
        NONE                = 0x0,

        /// <summary>
        /// SCI programming voltage
        /// <para>0 = no voltage after message transmit</para>
        /// <para>1 = apply 20V after message transmit</para>
        /// </summary>
        SCI_TX_VOLTAGE      = 0x800000,

        /// <summary>
        /// SCI transmit mode
        /// <para>0 = Transmit using SCI Full duplex mode</para>
        /// <para>1 = Transmit using SCI Half duplex mode</para>
        /// </summary>
        SCI_MODE            = 0x400000,

        /// <summary>
        /// Modified message timing for ISO 14230-used to decrease programming time if application knows only one response will be received
        /// <para>0 = Interface message timing as specified in ISO 14230</para>
        /// <para>1 = After a response is received for a physical request, the wait time shall be reduced to P3_MIN. Does not affect timing on Responses to functional requests</para>
        /// </summary>
        WAIT_P3_MIN_ONLY    = 0x200,

        /// <summary>
        /// The can 29 bit identifier
        /// <para>0 = 11-bit</para>
        /// <para>1 = 29-bit</para>
        /// </summary>
        CAN_29BIT_ID        = 0x100,

        /// <summary>
        /// ISO 15765-2 Addressing Method
        /// <para>0 = no extended address</para>
        /// <para>1 =extended address is first byte after the CAN ID</para>
        /// </summary>
        ISO15765_ADDR_TYPE  = 0x80,

        /// <summary>
        /// ISO 15765-2 Frame Padding
        /// <para>0 = no padding</para>
        /// <para>1 = pad all flow controlled messages to a full CAN frame using zeroes</para>
        /// </summary>
        ISO15765_FRAME_PAD  = 0x40,
    }
}
