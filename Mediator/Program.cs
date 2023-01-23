// The client code.
using Mediator.Models;

var paymentGateWay = new PaymentGateWay();
var paymentResultNotifyHandler = new PaymentResultNotifyHandler();

new ConcreteMediator(paymentGateWay, paymentResultNotifyHandler);

Console.WriteLine("Client Triggered RedirectPaymentToGateWay() method.");
paymentGateWay.RedirectPaymentToGateWay();

Console.ReadKey();