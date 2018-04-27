﻿#region License

//   Copyright 2014 Elton FAN
//
//   Licensed under the Apache License, Version 2.0 (the "License");
//   you may not use this file except in compliance with the License.
//   You may obtain a copy of the License at
//
//     http://www.apache.org/licenses/LICENSE-2.0
//
//   Unless required by applicable law or agreed to in writing, software
//   distributed under the License is distributed on an "AS IS" BASIS,
//   WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
//   See the License for the specific language governing permissions and
//   limitations under the License. 

#endregion

using Elton.Phantom.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elton.Phantom
{
    partial class PhantomApi
    {
        /// <summary>
        /// door_sensor
        /// </summary>
        /// <param name="device_type"></param>
        /// <returns></returns>
        public List<UserLog> GetUserLog(string cursor, int count, out string nextCursor)
        {
            var list = new Dictionary<string, string>();
            list.Add("count", count.ToString());

            var data = Get<dynamic>(2, $"user_log.json?count={count}&next_cursor={cursor}", list.ToArray());

            List<UserLog> result = new List<UserLog>();
            foreach(var item in data.data)
            {
                result.Add(new UserLog {
                    Message = item.message,
                    Timestamp = item.timestamp,
                });
            }

            nextCursor = data.next_cursor;
            return result;
        }
/*
{
  "data": [
    {
      "message": "---",
      "timestamp": 1477455511715
    },
    {
      "message": "---",
      "timestamp": 1477455511000
    },
  ],
  "next_cursor": "1477442148000-12857765"
}
*/
    }
}