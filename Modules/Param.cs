﻿using AutoRenderingWorkingStandard.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoRenderingWorkingStandard.Modules
{
    public static class Param
    {
        public static string PortSetting = @"C:\Stock";
        public static string Buffer = @"C:\Stock\bin";
        public static string SectionCode = string.Empty;
       
        public static Pattern Patterns = new Pattern() { TotalLength = 28, Start = 10, Length = 9 };

      

        public static string Permition = "on";
    }
}