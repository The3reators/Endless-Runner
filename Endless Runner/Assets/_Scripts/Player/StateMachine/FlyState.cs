using UnityEngine;

namespace TheCreators.Player.StateMachine
{
    public class FlyState : State
    {
        public FlyState(StateMachine currentContext, StateFactory stateFactory) : base(currentContext, stateFactory) { }

        public override void EnterState()
        {
            throw new System.NotImplementedException();
        }
        public override void UpdateState()
        {
            throw new System.NotImplementedException();
        }
        public override void ExitState()
        {
            throw new System.NotImplementedException();
        }
        public override void CheckSwitchState()
        {
            throw new System.NotImplementedException();
        }
    }
}
