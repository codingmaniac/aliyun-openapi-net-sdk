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
using System.Collections.Generic;

using Aliyun.Acs.Core;

namespace Aliyun.Acs.digitalstore.Model.V20200107
{
	public class CheckTagsResponse : AcsResponse
	{

		private string requestId;

		private bool? success;

		private List<CheckTags_CheckTagResultBiz> checkResult;

		public string RequestId
		{
			get
			{
				return requestId;
			}
			set	
			{
				requestId = value;
			}
		}

		public bool? Success
		{
			get
			{
				return success;
			}
			set	
			{
				success = value;
			}
		}

		public List<CheckTags_CheckTagResultBiz> CheckResult
		{
			get
			{
				return checkResult;
			}
			set	
			{
				checkResult = value;
			}
		}

		public class CheckTags_CheckTagResultBiz
		{

			private string tagValue;

			private string tagId;

			private string barcode;

			private int? isExist;

			public string TagValue
			{
				get
				{
					return tagValue;
				}
				set	
				{
					tagValue = value;
				}
			}

			public string TagId
			{
				get
				{
					return tagId;
				}
				set	
				{
					tagId = value;
				}
			}

			public string Barcode
			{
				get
				{
					return barcode;
				}
				set	
				{
					barcode = value;
				}
			}

			public int? IsExist
			{
				get
				{
					return isExist;
				}
				set	
				{
					isExist = value;
				}
			}
		}
	}
}
