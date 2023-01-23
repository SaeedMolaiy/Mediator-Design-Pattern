namespace Mediator.Models
{
    // The Mediator interface declares a method used by components to notify the
    // mediator about various events. The Mediator may react to these events and
    // pass the execution to other components.
    public interface IMediator
    {
        void Notify(BaseComponent sender, OperationResult operationResult);
    }
}
