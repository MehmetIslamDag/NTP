﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetSetUygulaması2
{
    class Person
    {
        //name özelliği
        private string name;
        //name için getve set metotları
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
    }
}
