﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace AffinityUI
{
    /// <summary>
    /// A layout panel whose children are stacked horizontally.
    /// </summary>
    public class HorizontalPanel : Composite<HorizontalPanel>
    {
        /// <summary>
        /// Called when layout begins when using GUILayout.
        /// </summary>
        protected override void OnBeginLayout_GUILayout()
        {
            GUILayout.BeginHorizontal(Content(), Style(), LayoutOptions());
        }

        /// <summary>
        /// Called when layout ends when using GUILayout.
        /// </summary>
        protected override void OnEndLayout_GUILayout()
        {
            GUILayout.EndHorizontal();
        }
    }
}