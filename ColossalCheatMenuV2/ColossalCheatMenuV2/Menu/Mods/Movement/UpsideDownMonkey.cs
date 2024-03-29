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
    public class UpsideDownMonkey : MonoBehaviour
    {
        public void Update()
        {
            if (PluginConfig.upsidedownmonkey)
            {
                if(GorillaLocomotion.Player.Instance.transform.rotation == Quaternion.Euler(0f, 0f, 0f))
                    GorillaLocomotion.Player.Instance.transform.rotation = Quaternion.Euler(0f, 0f, 180f);
            }
            else
            {
                if (GorillaLocomotion.Player.Instance.transform.rotation != Quaternion.Euler(0f, 0f, 0f))
                    GorillaLocomotion.Player.Instance.transform.rotation = Quaternion.Euler(0f, 0f, 0f);

                UnityEngine.Object.Destroy(GorillaTagger.Instance.GetComponent<UpsideDownMonkey>());
            }
        }
    }
}
