﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DcadToolBar
{
    public class DcDocument
    {
        public string Name { get; set; }

        public CabinModel? Model { get; set; }

        public MaterialType? Type { get; set; }

        public DcDocument(string name, CabinModel model, MaterialType material)
        {
            Name = name;
            Model = model;
            Type = material;
        }

        public DcDocument(string name)
        {
            Name = name;
            Model = null;
            Type = null;
        }
    }
}
