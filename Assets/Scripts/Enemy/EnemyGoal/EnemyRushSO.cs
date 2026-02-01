using System.Collections;
using Enemy.EnemyAttack;
using GoalAgent;
using UnityEngine;

namespace Enemy.EnemyGoal
{
    public class EnemyRushSO : AgentGoal
    {
        [field: SerializeField] public float DetectionRange {get;private set; }
        [field: SerializeField] public float AttackCoolTime {get; private set; }
        [field: SerializeField] public float WaitTime {get; private set; }
        [field: SerializeField] public float RushSpeed {get; private set; }
        [field: SerializeField] public float RushLength {get; private set; }
        public override bool CanExecute()
        {
            return ownerAgent.Target&&Vector3.Distance(ownerAgent.Target.position, ownerAgent.transform.position) <= DetectionRange;
        }
        public override bool CanContinue() => CanExecute();

        public override void Tick()
        {
            
        }

        private IEnumerator Rush()
        {
            yield return new WaitForSeconds(WaitTime);
        }

    }
}