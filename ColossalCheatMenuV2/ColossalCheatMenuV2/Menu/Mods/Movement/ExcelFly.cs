﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.XR;
using static Colossal.Plugin;

namespace Colossal.Mods
{
    public class ExcelFly : MonoBehaviour
    {
        public void Update()
        {
            if (Plugin.excelfly)
            {
                bool excelL;
                bool excelR;
                InputDevices.GetDeviceAtXRNode(XRNode.LeftHand).TryGetFeatureValue(UnityEngine.XR.CommonUsages.primaryButton, out excelL);
                InputDevices.GetDeviceAtXRNode(XRNode.RightHand).TryGetFeatureValue(UnityEngine.XR.CommonUsages.primaryButton, out excelR);
                if (excelL)
                {
                    GorillaLocomotion.Player.Instance.bodyCollider.attachedRigidbody.velocity += -GorillaLocomotion.Player.Instance.leftControllerTransform.right / 2f;
                }
                if (excelR)
                {
                    GorillaLocomotion.Player.Instance.bodyCollider.attachedRigidbody.velocity += GorillaLocomotion.Player.Instance.rightControllerTransform.right / 2f;
                }
            }
            else
            {
                Destroy(GorillaTagger.Instance.GetComponent<ExcelFly>());
            }
        }
    }
}
