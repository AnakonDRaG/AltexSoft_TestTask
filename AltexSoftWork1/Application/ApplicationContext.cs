using AltexSoftWork1.Application.Base;

namespace AltexSoftWork1.Application
{
    public class ApplicationContext
    {
        private StateBase _currentState;

        public ApplicationContext(StateBase startState) => SetState(startState);

        public void ChangeState(StateBase state)
        {
            _currentState.Exit();
            SetState(state);
        }

        private void SetState(StateBase state) 
        {
            _currentState = state;
            _currentState.SetStateMachine(this);
            _currentState.Enter();
        }

        public void StateUpdate() => _currentState.UpdateState();



    }
}
