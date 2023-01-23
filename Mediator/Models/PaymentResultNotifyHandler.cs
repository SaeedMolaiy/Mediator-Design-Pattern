namespace Mediator.Models
{
    // Concrete Components implement various functionality. They don't depend on
    // other components. They also don't depend on any concrete mediator
    // classes.
    public class PaymentResultNotifyHandler : BaseComponent
    {
        public void SendSuccessNotify()
        {
            Console.WriteLine();
            Console.WriteLine("PaymentResultNotifyHandler : i sent success message to user but user canceled the purchase");

            CanceledPayment();
        }

        public void SendCancelNotify()
        {
            Console.WriteLine();
            Console.WriteLine("PaymentResultNotifyHandler : i sent canceling message to user");
        }

        public void CanceledPayment()
        {
            Mediator.Notify(this, OperationResult.Cancel);
        }

    }
}