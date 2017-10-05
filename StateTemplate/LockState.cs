namespace StateTemplate
{
    public class LockState : IState
    {
        public void Coin(Context context)
        {
            context.UnLock();
            context.SetUnLockState();
        }

        public void Pass(Context context)
        {
            context.Alarm();
        }
    }
}