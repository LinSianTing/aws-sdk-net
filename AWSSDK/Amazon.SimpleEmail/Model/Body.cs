/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SimpleEmail.Model
{
    /// <summary>
    /// Represents the body of the message. You can specify text, HTML, or both. If you use
    /// both, then            the message should display correctly in the widest variety of
    /// email clients.
    /// </summary>
    public partial class Body
    {
        private Content _html;
        private Content _text;


        /// <summary>
        /// Gets and sets the property Html. 
        /// <para>
        /// The content of the message, in HTML format. Use this for email clients that can process
        /// HTML. You can include clickable links, formatted            text, and much more in
        /// an HTML message.        
        /// </para>
        /// </summary>
        public Content Html
        {
            get { return this._html; }
            set { this._html = value; }
        }


        /// <summary>
        /// Sets the Html property
        /// </summary>
        /// <param name="html">The value to set for the Html property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public Body WithHtml(Content html)
        {
            this._html = html;
            return this;
        }

        // Check to see if Html property is set
        internal bool IsSetHtml()
        {
            return this._html != null;
        }


        /// <summary>
        /// Gets and sets the property Text. 
        /// <para>
        /// The content of the message, in text format. Use this for text-based email clients,
        /// or clients on high-latency networks (such as mobile            devices).        
        /// </para>
        /// </summary>
        public Content Text
        {
            get { return this._text; }
            set { this._text = value; }
        }


        /// <summary>
        /// Sets the Text property
        /// </summary>
        /// <param name="text">The value to set for the Text property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public Body WithText(Content text)
        {
            this._text = text;
            return this;
        }

        // Check to see if Text property is set
        internal bool IsSetText()
        {
            return this._text != null;
        }

    }
}