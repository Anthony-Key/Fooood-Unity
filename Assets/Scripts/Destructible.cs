using System;
using System.Collections;
using UnityEngine;

namespace DefaultNamespace
{
    public class Destructible : GameItem
    {
        private void Update()
        {
            if (selfDestruct)
            {
                StartCoroutine(Kill());
                selfDestruct = false;
            }
        }

        public override IEnumerator Kill()
        {
            AudioController.Instance.PlayAudio(destructibleType, killSound);
            particleSystem.Play();
            yield return new WaitForSeconds(timeToKill);
            Destroy(gameObject);
        }
    }
}