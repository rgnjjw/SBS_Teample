using System;
using System.Collections.Generic;
using JJW._02_Code.Enemy;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.Serialization;

namespace JJW._02_Code
{
    public abstract class GoalAgent : MonoBehaviour
    {
        public EnemyInfo EnemyInfo => enemyInfo;
        public NavMeshAgent NavMeshAgent {get; private set;}
        public Transform Target {get; private set;}
        
        [SerializeField] private EnemyInfo enemyInfo;
        [SerializeField] private List<AgentGoal> goals;
        
        private AgentGoal _currentGoal;

        private void Awake()
        {
            Target = GameObject.Find("Player").transform;
            NavMeshAgent = GetComponent<NavMeshAgent>();
            foreach (var goal in  goals)
            {
                goal.Init(this);
            }
        }

        private void Update()
        {
            Tick();
        }

        private void Tick()
        {
            foreach (var goal in goals)
            {
                if (goal == _currentGoal && _currentGoal.CanContinue())
                {
                    _currentGoal.Tick();
                    return;
                }

                if (goal.CanExecute())
                {
                    _currentGoal = goal;
                    _currentGoal.Tick();
                    return;
                }
            }
        }
    }
}