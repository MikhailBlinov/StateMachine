using System.Globalization;

namespace StateTemplate
{
    public class Context
    {
        private Controller _controller;
        private IState _currentState;

        private LockState lockState = new LockState();
        private UnLockState unlockState = new UnLockState();


        public Context(IState state)
        {
            _controller = new Controller();
            _currentState = state;
        }

        public void Coin()
        {
            _currentState.Coin(this);
        }

        public void Pass()
        {
            _currentState.Pass(this);
        }

        public void Lock()
        {
            _controller.Lock();
        }

        public void UnLock()
        {
            _controller.UnLock();
        }
        public void Alarm()
        {
            _controller.Alarm();
        }
        public void ThankYou()
        {
            _controller.TankYou();
        }

        public void SetLockState()
        {
            _currentState = lockState;
        }

        public void SetUnLockState()
        {
            _currentState = unlockState;
        }

    }
}