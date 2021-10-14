﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Sd = System.Drawing;
using Rg = Rhino.Geometry;
using Af = Accord.Imaging.Filters;

namespace BitmapPlus.Filters.Dither
{
    public class Ordered : Filter
    {

        #region members



        #endregion

        #region constructors

        public Ordered()
        {
            ImageType = ImageTypes.GrayscaleBT709;

            Af.OrderedDithering newFilter = new Af.OrderedDithering();

            this.filterObject = newFilter;
        }

        public Ordered(Ordered filter) : base(filter)
        {
            this.ImageType = filter.ImageType;
            this.filterObject = filter.filterObject;
        }

        #endregion

        #region properties



        #endregion

        #region methods



        #endregion

        #region override

        public override string ToString()
        {
            return "Filter: Ordered";
        }

        #endregion

    }
}