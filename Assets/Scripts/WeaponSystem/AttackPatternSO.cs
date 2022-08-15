using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MINH.WeaponSystem
{
    public abstract class AttackPatternSO : ScriptableObject
    {
        [SerializeField]
        protected float attackDelay = 0.2f;
        [SerializeField]
        protected GameObject projectile;
        public float AttackDelay => attackDelay;
        [SerializeField]
        protected AudioClip weaponSFX;
        public AudioClip AudioSFX => weaponSFX;
        public abstract void Perform(Transform shootingStartPoint);
    }
}