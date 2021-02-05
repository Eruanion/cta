﻿using NUnit.Framework;
using System;
using System.Reflection;

namespace CTA.Rules.Test
{
    public class TestUtils
    {
        public static MethodInfo GetPrivateMethod(Type type, string methodName)
        {
            if (string.IsNullOrWhiteSpace(methodName))
                Assert.Fail("methodName cannot be null or whitespace");

            var method = type.GetMethod(methodName, BindingFlags.NonPublic | BindingFlags.Instance);

            if (method == null)
                Assert.Fail("{0} method not found", methodName);

            return method;
        }
    }
}