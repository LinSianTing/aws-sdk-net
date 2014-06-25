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

using Amazon.ElasticTranscoder.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;

namespace Amazon.ElasticTranscoder.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for TestRole Object
    /// </summary>  
    public class TestRoleResultUnmarshaller : IUnmarshaller<TestRoleResult, XmlUnmarshallerContext>, IUnmarshaller<TestRoleResult, JsonUnmarshallerContext>
    {
        TestRoleResult IUnmarshaller<TestRoleResult, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        public TestRoleResult Unmarshall(JsonUnmarshallerContext context)
        {
            if (context.CurrentTokenType == JsonUnmarshallerContext.TokenType.Null)
                return null;
            
            var unmarshalledObject = new TestRoleResult();
            unmarshalledObject.Messages = null;
                    
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;

            while (context.Read())
            {
                if ((context.IsKey) && (context.CurrentDepth == targetDepth))
                {
                    context.Read();
                    context.Read();
                    if (context.TestExpression("Messages", targetDepth))
                    {
                        if (context.CurrentTokenType == JsonUnmarshallerContext.TokenType.Null)
                        {
                            unmarshalledObject.Messages =  null;
                            continue;
                        }
                        unmarshalledObject.Messages = new List<string>();
                        var unmarshaller = StringUnmarshaller.GetInstance();
                        while (context.Read())
                        {
                          if ((context.IsArrayElement) && (context.CurrentDepth == targetDepth))
                          {
                             unmarshalledObject.Messages.Add(unmarshaller.Unmarshall(context));
                          }
                          else if (context.IsEndArray)
                          {
                            break;
                          }
                        }
                        continue;
                    }
                    if (context.TestExpression("Success", targetDepth))
                    {
                        if (context.CurrentTokenType == JsonUnmarshallerContext.TokenType.Null)
                        {
                            unmarshalledObject.Success = null;
                            continue;
                        }
                        unmarshalledObject.Success = StringUnmarshaller.GetInstance().Unmarshall(context);
                        continue;
                    }
                }
                else if (context.IsEndElement && context.CurrentDepth <= originalDepth)
                {
                    return unmarshalledObject;
                }
            }   
                           
            return unmarshalledObject;
        }


        private static TestRoleResultUnmarshaller instance;
        public static TestRoleResultUnmarshaller GetInstance()
        {
            if (instance == null)
            {
                instance = new TestRoleResultUnmarshaller();
            }
            return instance;
        }

    }
}