namespace AltexSoftWork1.Application.Base
{
   public abstract class StateBase
{
        protected ApplicationContext _stateMachine;
        public void SetStateMachine(ApplicationContext StateMachine) => _stateMachine = StateMachine;
        public abstract void Enter();
        public abstract void UpdateState();
        public abstract void Exit();
    }
}
