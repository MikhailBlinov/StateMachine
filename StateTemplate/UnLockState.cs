namespace StateTemplate
{
    public class UnLockState : IState
    {
        public void Coin(Context context)
        {
            context.ThankYou();
        }

        public void Pass(Context context)
        {
            context.Lock();
            context.SetLockState();
        }
    }
}