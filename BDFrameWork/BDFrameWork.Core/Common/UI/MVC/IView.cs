﻿using System.Runtime.InteropServices.ComTypes;
using UnityEngine;

namespace BDFramework.UI
{
    public interface IView
    {
        DataDrive_Service Model { get; }
 
        Transform Transform { get; }

        void Show();
        void Hide();
        void BindModel();

        void Destory();
    }
}