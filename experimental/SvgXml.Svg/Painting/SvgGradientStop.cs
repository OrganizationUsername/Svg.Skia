﻿using System;
using Xml;

namespace Svg
{
    [Element("stop")]
    public class SvgGradientStop : SvgStylableElement,
        ISvgCommonAttributes,
        ISvgPresentationAttributes,
        ISvgStylableAttributes
    {
        [Attribute("offset", SvgNamespace)]
        public string? Offset
        {
            get => this.GetAttribute("offset", false, null);
            set => this.SetAttribute("offset", value);
        }

        public override void SetPropertyValue(string key, string? value)
        {
            base.SetPropertyValue(key, value);
            switch (key)
            {
                case "offset":
                    Offset = value;
                    break;
            }
        }
    }
}
