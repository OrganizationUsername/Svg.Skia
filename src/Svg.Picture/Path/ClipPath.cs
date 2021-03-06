﻿using System;
using System.Collections.Generic;

namespace Svg.Picture
{
    public class ClipPath : IDisposable
    {
        public IList<PathClip>? Clips { get; set; }
        public Matrix? Transform { get; set; }
        public ClipPath? Clip { get; set; }

        public bool IsEmpty => Clips == null || Clips.Count == 0;

        public ClipPath()
        {
            Clips = new List<PathClip>();
        }

        public void Dispose()
        {
        }
    }
}
