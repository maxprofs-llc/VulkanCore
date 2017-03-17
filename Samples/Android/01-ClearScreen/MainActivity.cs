﻿using Android.App;
using Android.OS;

namespace VulkanCore.Samples.ClearScreen
{
    [Activity(Label = "ClearScreen", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            var surfaceView = new VulkanSurfaceView(this, new ClearScreenApp());
            SetContentView(surfaceView);
        }
    }
}

