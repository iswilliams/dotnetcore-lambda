using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Xunit;
using Amazon.Lambda.Core;
using Amazon.Lambda.TestUtilities;

using AWSLambda1;
using Amazon.Lambda.APIGatewayEvents;

namespace AWSLambda1.Tests
{
    public class FunctionTest
    {
        [Fact]
        public void TestToUpperFunction()
        {

            // Invoke the lambda function and confirm the string was upper cased.
            var function = new Function();
            var context = new TestLambdaContext();
            var evnt = new APIGatewayProxyRequest();
            var upperCase = function.FunctionHandler(evnt, context);

            Assert.Equal("", upperCase);
        }
    }
}
