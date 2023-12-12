namespace Mediator.Mediators
{
    // Interface do Mediador: ICombatMediator
    public interface ICombatMediator
    {
        void RegisterParticipant(Character participant);
        void SendAction(Character sender, string action);
    }
}