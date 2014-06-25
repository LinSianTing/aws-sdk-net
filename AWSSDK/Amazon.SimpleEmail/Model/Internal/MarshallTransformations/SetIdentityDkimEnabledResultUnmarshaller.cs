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
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.SimpleEmail.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;

namespace Amazon.SimpleEmail.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for SetIdentityDkimEnabled Object
    /// </summary>  
    public class SetIdentityDkimEnabledResultUnmarshaller : IUnmarshaller<SetIdentityDkimEnabledResult, XmlUnmarshallerContext>
    {
        public SetIdentityDkimEnabledResult Unmarshall(XmlUnmarshallerContext context) 
        {
            SetIdentityDkimEnabledResult result = new SetIdentityDkimEnabledResult();

            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            if (context.IsStartOfDocument) 
               targetDepth += 2;

            while (context.Read())
            {
                if (context.IsStartElement || context.IsAttribute)
                {

                } 
                else if (context.IsEndElement && context.CurrentDepth < originalDepth)
                {
                    return result;
                }
            }

            return result;
        }


        private static SetIdentityDkimEnabledResultUnmarshaller instance;
        public static SetIdentityDkimEnabledResultUnmarshaller GetInstance()
        {
            if (instance == null)
            {
                instance = new SetIdentityDkimEnabledResultUnmarshaller();
            }
            return instance;
        }

    }
}