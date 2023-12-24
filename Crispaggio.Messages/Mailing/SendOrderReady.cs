namespace Crispaggio.Messages.Mailing;

public interface SendOrderReady
{
    public string Email { get; }
    
    public Guid OrderId { get; }
}