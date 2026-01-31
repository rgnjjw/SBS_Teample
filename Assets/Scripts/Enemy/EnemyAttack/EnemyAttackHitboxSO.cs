using UnityEngine;

namespace Enemy.EnemyAttack
{
    [CreateAssetMenu(fileName = "EnemyAttackHitboxSO", menuName = "JJW/Enemy/EnemyAttack/EnemyAttackHitboxSO", order = 0)]
    public class EnemyAttackHitboxSO : ScriptableObject
    {
        [field: SerializeField] public Vector3 Size {get;private set;}
        [field: SerializeField] public Vector3 Offset {get;private set;}
        [field: SerializeField] public Color Color {get;private set;}
    }
}