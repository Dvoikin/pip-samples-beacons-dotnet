﻿using PipServices.Commons.Validate;
using System;

namespace Interface.Data.Version1
{
    public class BeaconV1Schema: ObjectSchema
    {
        public BeaconV1Schema()
        {
            this.WithOptionalProperty("id", TypeCode.String);
            this.WithRequiredProperty("site_id", TypeCode.String);
            this.WithOptionalProperty("type", TypeCode.String);
            this.WithRequiredProperty("udi", TypeCode.String);
            this.WithOptionalProperty("label", TypeCode.String);
            this.WithOptionalProperty("center", null);
            this.WithOptionalProperty("radius", TypeCode.Double);
        }
    }
}
