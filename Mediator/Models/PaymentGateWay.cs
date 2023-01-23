namespace Mediator.Models
{
    // Concrete Components implement various functionality. They don't depend on
    // other components. They also don't depend on any concrete mediator
    // classes.
    public class PaymentGateWay : BaseComponent
    {
        public void RedirectPaymentToGateWay()
        {
            Console.WriteLine();
            Console.WriteLine("PaymentGateWay :User Redirected To Payment GateWay And Payment was Success.");

            Mediator.Notify(this, OperationResult.Success);
        }

        public void CancelPurchase()
        {
            Console.WriteLine();
            Console.WriteLine("PaymentGateWay : I will return Purchase Amount to user bank account");

            Mediator.Notify(this, OperationResult.Canceled);
        }
    }
}
