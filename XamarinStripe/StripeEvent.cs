﻿/*
 * Copyright 2012 Xamarin, Inc.
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *      http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Dynamic;
using Newtonsoft.Json.Linq;

namespace Xamarin.Payments.Stripe {
    public class StripeEvent : StripeObject {
        [JsonProperty (PropertyName = "livemode")]
        bool LiveMode { get; set; }
        [JsonProperty (PropertyName = "created")]
        [JsonConverter (typeof (UnixDateTimeConverter))]
        public DateTime? Created { get; set; }
        [JsonProperty (PropertyName = "type")]
        public string type { get; set; }
    
        [JsonProperty (PropertyName= "data")]
        public EventData Data { get; set; }

        public class EventData {
            [JsonProperty (PropertyName = "object")]
            [JsonConverter (typeof (StripeObjectConverter))]
            public StripeObject Object { get; set; }
        }
    }
}
