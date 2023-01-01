using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletBehaviour : MonoBehaviour
{
    private float _onScrreeenDelay = 3f;

    private void Start()
    {
        Destroy(this.gameObject, _onScrreeenDelay);
    }
}
