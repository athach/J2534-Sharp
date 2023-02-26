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
    [Flags]
    public enum ConnectFlag
    {        
        /// <summary>
        /// No flag
        /// </summary>
        NONE                        = 0x0000,
        
        /// <summary>
        /// CAN ID type for CAN and ISO 15765 (also see CAN_ID_BOTH)
        /// <para>0 = Receive standard CAN ID (11 bit)</para>
        /// <para>1 = Receive extended CAN ID (29 bit)</para>
        /// </summary>
        CAN_29BIT_ID                = 0x0100,
        
        /// <summary>
        /// Checksum control for ISO9141 and ISO14230
        /// <para></para>
        /// <para></para>
        /// </summary>
        ISO9141_NO_CHECKSUM         = 0x0200,
        
        /// <summary>
        /// CAN ID support type for CAN and ISO 15765 (also see CAN_29BIT_ID)
        /// <para>0 = either standard or extended CAN ID types used – CAN ID type defined by CAN_29BIT_ID</para>
        /// <para>1 = both standard and extended CAN ID types used – if the CAN controller allows prioritizing either standard (11 bit) or extended (29 bit) CAN ID's then CAN_29BIT_ID will determine the higher priority ID type</para>
        /// </summary>
        CAN_ID_BOTH                 = 0x0800,
        
        /// <summary>
        /// L line usage for ISO9141 and ISO14230 Initialization address
        /// <para>0 = use L-line and K-line for initialization address</para>
        /// <para>1 = use K-line only line for initialization address</para>
        /// </summary>
        ISO9141_K_LINE_ONLY         = 0x1000,
        
        DT_ISO9141_LISTEN_L_LINE    = 0x08000000,
        SNIFF_MODE                  = 0x10000000,       //Drewtech only
        ISO9141_FORD_HEADER         = 0x20000000,       //Drewtech only
        ISO9141_NO_CHECKSUM_DT      = 0x40000000        //Drewtech only
    }
}
