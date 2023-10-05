using System;
using UnityEngine;

namespace DefaultNamespace
{
    public class FollowPlayer : MonoBehaviour
    {
        private void LateUpdate()
        {
            GameObject player = GameObject.Find("Player");
            Vector3 target = player.transform.position + new Vector3(0, 1.38f, -4.83f);
            transform.position = target;
        }
    }
}