﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_5_2
{
    public enum Type { Teatcher, Student }
    public abstract class Human
    {
        public Type type;
        public string Name { get; set; }
    }
    
    
}
