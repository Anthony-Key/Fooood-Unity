using System;
using System.Collections;
using UnityEngine;

namespace DefaultNamespace
{
    public class Destructible : GameItem
    {
        private void OnMouseDown()
        {
            StartCoroutine(Kill());
        }

        public override IEnumerator Kill()
        {
            Instantiate(destructibleMesh, transform.position, transform.rotation);
            AudioController.Instance.PlayAudio(destructibleType, killSound);
            SetColorAndPlayParticle();
            yield return new WaitForSeconds(0f);
        }

        private void SetColorAndPlayParticle()
        {
            var p = particleSystem;
            var mainModule = p.main;
            var mainModuleStartColor = mainModule.startColor;
            mainModuleStartColor.gradient = killGradient;
            particleSystem.Play();
        }
    }
}