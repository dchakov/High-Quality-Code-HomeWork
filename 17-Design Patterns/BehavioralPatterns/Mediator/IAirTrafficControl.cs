
namespace Mediator
{
    public interface IAirTrafficControl
    {
        void RegistrerAircraft(Aircraft aircraft);

        void SendWarningMessage(Aircraft aircraft);
    }
}
