﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace exercise.main
{
    public class BasketEntry
    {
        private BaseItem _baseItem;
        private int _count;
        private List<AddOn> _addOns;


        public BasketEntry()
        {
            throw new NotImplementedException();
        }

        public BaseItem BaseItem { get => _baseItem; }
        public int Count { get => _count; }
        public List<AddOn> AddOns { get => _addOns; }
    }
}