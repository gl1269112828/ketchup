﻿//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Reflection;
//using System.Text;
//using Ketchup.Core.Attributes;
//using Ketchup.Core.Gateway.Attribute;

//namespace Ketchup.Core.Gateway.Implementation
//{
//    public class GatewayProvider : IGatewayProvider
//    {
//        public Dictionary<string, Type> RequesType { get; set; }

//        private readonly Type[] _types;

//        public GatewayProvider(Type[] types)
//        {
//            _types = _types = types.Where(type =>
//            {
//                var typeInfo = type.GetTypeInfo();
//                return typeInfo.IsClass && typeInfo.GetCustomAttribute<ServiceAttribute>() != null;
//            }).Distinct().ToArray();

//            RequesType = new Dictionary<string, Type>();
//        }

//        public void InitGatewaySetting()
//        {
//            foreach (var service in _types)
//            {
//                foreach (var methodInfo in service.GetMethods())
//                {
//                    var attribute = methodInfo.GetCustomAttribute<GatewayAttribute>();
//                    var parameterInfo = methodInfo.GetParameters().FirstOrDefault(item => item.ParameterType.Name == attribute?.RequestName);

//                    if (attribute == null || parameterInfo == null)
//                        return;
//                    RequesType.Add(methodInfo.Name, parameterInfo.ParameterType);
//                }
//            }
//        }
//    }
//}