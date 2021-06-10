﻿using System;
using JetBrains.Annotations;
using UnityEngine.Scripting;

namespace BrunoMikoski.DebugTools.Core.Attributes
{
    [AttributeUsage(AttributeTargets.Method)]
    [MeansImplicitUse(ImplicitUseKindFlags.Access)]
    public sealed class DebuggableActionAttribute : PreserveAttribute
    {
        private string caption;
        public string Caption => caption;

        private string hotkey = string.Empty;
        public string Hotkey => hotkey;

        public DebuggableActionAttribute()
        {
        }
        
        public DebuggableActionAttribute(string caption)
        {
            this.caption = caption;
        }

        public DebuggableActionAttribute(string caption, string hotKey)
        {
            this.caption = caption;
            this.hotkey = hotKey;
        }
    }
}