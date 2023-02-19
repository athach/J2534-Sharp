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
    /// Message receive flags
    /// </summary>
    [Flags]
    public enum RxFlag
    {
        /// <summary>No flag</summary>
        NONE                    = 0x0,

        /// <summary>
        /// Receive Indication/Transmit Loopback
        /// <para>0 = received i.e. this message was transmitted on the bus by another node</para>
        /// <para>1 = transmitted i.e. this is the echo of the message transmitted by the PassThru device</para>
        /// </summary>
        TX_MSG_TYPE             = 0x1,

        /// <summary>
        /// Indicates the reception of the first byte of an ISO9141 or ISO14230 message or first frame of an ISO15765 multiframe message
        /// <para>0 = Not a start of message indication </para>
        /// <para>1 = First byte or frame received</para>
        /// </summary>
        START_OF_MESSAGE        = 0x2,

        /// <summary>
        /// Break indication received – SAE J2610 and SAE J1850 VPW only
        /// <para>0 = No break received</para>
        /// <para>1 = Break received</para>
        /// </summary>
        RX_BREAK                = 0x4,

        /// <summary>
        /// ISO 15765 TxDone indicationCANID and extended address, if present, shall be included in the message structure
        /// <para>0 = No TxDone </para>
        /// <para>1 = TxDone</para>
        /// </summary>
        TX_INDICATION           = 0x8,

        /// <summary>
        /// For ProtocolID ISO 15765 a CAN frame was received with less than 8 data bytes
        /// <para>0 = No Error </para>
        /// <para>1 = Padding Error</para>
        /// </summary>
        ISO15765_PADDING_ERROR  = 0x10,

        /// <summary>
        /// ISO 15765-2 Addressing Method
        /// <para>0 = no extended address</para>
        /// <para>1 = extended address is first byte after the CAN ID</para>
        /// </summary>
        ISO15765_ADDR_TYPE      = 0x80,

        /// <summary>
        /// CAN ID Type for CAN and ISO 15765
        /// <para>0 = 11-bit Identifier </para>
        /// <para>1 = 29-bit Identifier</para>
        /// </summary>
        CAN_29BIT_ID            = 0x100
    }
}
