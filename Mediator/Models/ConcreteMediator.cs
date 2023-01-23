namespace Mediator.Models
{
    // Concrete Mediators implement cooperative behavior by coordinating several
    // components.
    public class ConcreteMediator : IMediator
    {
        private readonly PaymentGateWay _paymentGateWay;

        private readonly PaymentResultNotifyHandler _paymentResultNotifyHandler;

        public ConcreteMediator(PaymentGateWay paymentGateWay, PaymentResultNotifyHandler paymentResultNotifyHandler)
        {
            _paymentGateWay = paymentGateWay;
            _paymentGateWay.SetMediator(this);
            _paymentResultNotifyHandler = paymentResultNotifyHandler;
            _paymentResultNotifyHandler.SetMediator(this);
        }

        public void Notify(BaseComponent sender, OperationResult operationResult)
        {
            switch (operationResult)
            {
                case OperationResult.Success:
                    _paymentResultNotifyHandler.SendSuccessNotify();
                    break;
                case OperationResult.Canceled:
                    _paymentResultNotifyHandler.SendCancelNotify();
                    break;
                case OperationResult.Cancel:
                    _paymentGateWay.CancelPurchase();
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(operationResult), operationResult, null);
            }
        }
    }
}
