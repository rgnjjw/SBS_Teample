using UnityEngine;

namespace Enemy.EnemyAttack
{
    public abstract class AttackActionSO : ScriptableObject
    {
        [field:SerializeField] public string Name {get; private set;}
        [field: SerializeField] public string Desc {get; private set; }
        [field: SerializeField] public int AdditionalMeleeAttackDamage {get; private set; }
        [field: SerializeField] public LayerMask AttackTargetLayerMask {get; private set; }
        [field: SerializeField] public EnemyAttackHitboxSO HitboxSO {get; private set;}
        
        public abstract void Attack(GoalAgent.GoalAgent goalAgent);
    }
}