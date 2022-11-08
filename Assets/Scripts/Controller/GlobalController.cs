﻿using System;
using Model;
using UnityEngine;

namespace Controller
{
    public class GlobalController: MonoBehaviour
    {
        [SerializeField] private ModelController _modelController;

        private void Start()
        {
            _modelController.Setup();
        }
    }
}