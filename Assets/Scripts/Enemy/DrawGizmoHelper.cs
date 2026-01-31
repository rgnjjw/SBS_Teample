using Enemy.EnemyAttack;
using UnityEngine;

namespace Enemy
{
    public class DrawGizmoHelper : MonoBehaviour
    {
        [SerializeField] private EnemyAttackHitboxSO[] enemyAttackHitboxSO;

        private void OnDrawGizmos()
        {
            if (enemyAttackHitboxSO == null || enemyAttackHitboxSO.Length == 0)
                return;

            Gizmos.matrix = transform.localToWorldMatrix;

            foreach (var hitbox in enemyAttackHitboxSO)
            {
                if (hitbox == null) continue;

                Gizmos.color = hitbox.Color;
                Gizmos.DrawWireCube(hitbox.Offset, hitbox.Size);
            }
        }
    }
}