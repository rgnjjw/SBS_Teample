using Member.JJW.Code.GoalAgent;
using UnityEngine;

namespace JJW._02_Code
{
    public abstract class AgentGoal : ScriptableObject
    {
        protected GoalAgent OwnerAgent;

        public void Init(GoalAgent agent)
        {
            OwnerAgent = agent;
        }

        public abstract bool CanExecute();
        public abstract bool CanContinue();
        public abstract void Tick();
    }
}