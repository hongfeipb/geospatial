﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GIS.Framework
{
    public interface ISupportsGISFields
    {
        IGISFields GetGISFields();
    }
}
