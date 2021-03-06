/*
 * Licensed to the Apache Software Foundation (ASF) under one
 * or more contributor license agreements.  See the NOTICE file
 * distributed with this work for additional information
 * regarding copyright ownership.  The ASF licenses this file
 * to you under the Apache License, Version 2.0 (the
 * "License"); you may not use this file except in compliance
 * with the License.  You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing,
 * software distributed under the License is distributed on an
 * "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
 * KIND, either express or implied.  See the License for the
 * specific language governing permissions and limitations
 * under the License.
 */
using System;
using System.Collections.Generic;

using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.geoip.Model.V20200101;

namespace Aliyun.Acs.geoip.Transform.V20200101
{
    public class DescribeGeoipInstancesResponseUnmarshaller
    {
        public static DescribeGeoipInstancesResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeGeoipInstancesResponse describeGeoipInstancesResponse = new DescribeGeoipInstancesResponse();

			describeGeoipInstancesResponse.HttpResponse = context.HttpResponse;
			describeGeoipInstancesResponse.RequestId = context.StringValue("DescribeGeoipInstances.RequestId");

			List<DescribeGeoipInstancesResponse.DescribeGeoipInstances_GeoipInstance> describeGeoipInstancesResponse_geoipInstances = new List<DescribeGeoipInstancesResponse.DescribeGeoipInstances_GeoipInstance>();
			for (int i = 0; i < context.Length("DescribeGeoipInstances.GeoipInstances.Length"); i++) {
				DescribeGeoipInstancesResponse.DescribeGeoipInstances_GeoipInstance geoipInstance = new DescribeGeoipInstancesResponse.DescribeGeoipInstances_GeoipInstance();
				geoipInstance.ProductCode = context.StringValue("DescribeGeoipInstances.GeoipInstances["+ i +"].ProductCode");
				geoipInstance.InstanceId = context.StringValue("DescribeGeoipInstances.GeoipInstances["+ i +"].InstanceId");
				geoipInstance.VersionCode = context.StringValue("DescribeGeoipInstances.GeoipInstances["+ i +"].VersionCode");
				geoipInstance.Status = context.StringValue("DescribeGeoipInstances.GeoipInstances["+ i +"].Status");
				geoipInstance.CreateTime = context.StringValue("DescribeGeoipInstances.GeoipInstances["+ i +"].CreateTime");
				geoipInstance.CreateTimestamp = context.LongValue("DescribeGeoipInstances.GeoipInstances["+ i +"].CreateTimestamp");
				geoipInstance.ExpireTime = context.StringValue("DescribeGeoipInstances.GeoipInstances["+ i +"].ExpireTime");
				geoipInstance.ExpireTimestamp = context.LongValue("DescribeGeoipInstances.GeoipInstances["+ i +"].ExpireTimestamp");
				geoipInstance.MaxQps = context.LongValue("DescribeGeoipInstances.GeoipInstances["+ i +"].MaxQps");
				geoipInstance.MaxQpd = context.LongValue("DescribeGeoipInstances.GeoipInstances["+ i +"].MaxQpd");

				describeGeoipInstancesResponse_geoipInstances.Add(geoipInstance);
			}
			describeGeoipInstancesResponse.GeoipInstances = describeGeoipInstancesResponse_geoipInstances;
        
			return describeGeoipInstancesResponse;
        }
    }
}
