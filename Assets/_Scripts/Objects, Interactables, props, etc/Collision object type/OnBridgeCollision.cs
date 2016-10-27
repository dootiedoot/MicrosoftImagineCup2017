﻿using UnityEngine;
using System.Collections;

public class OnBridgeCollision : OnPlayerCollision
{
    public float ForceMultiplier;

    public override void OnPlayerHit(ControllerColliderHit hit, Vector3 pushDir)
    {
        hit.rigidbody.velocity = pushDir * ForceMultiplier;
    }
}
