using Enemy.EnemyAttack;
using GoalAgent;
using UnityEngine;

namespace Enemy.EnemyGoal
{
    [CreateAssetMenu(fileName = "MeleeAttack", menuName = "JJW/Enemy/Goal/MeleeAttack", order = 0)]
    public class EnemyMeleeAttackSO : AgentGoal
    {
        [field: SerializeField] public float DetectionRange {get;private set; }
        [field: SerializeField] public float AttackCoolTime {get; private set; }
        [field: SerializeField] public AttackActionSO AttackAction {get; private set; }
        

        private float _lastAttackTime;
        
        public override bool CanExecute()
        {
            return ownerAgent.Target && Vector3.Distance(ownerAgent.Target.position,ownerAgent.transform.position) <= DetectionRange && Time.time > _lastAttackTime + AttackCoolTime;
        }

        public override bool CanContinue() => CanExecute();

        public override void Tick()
        {
            AttackAction.Attack(ownerAgent);
            _lastAttackTime = Time.time;
        }
    }
}