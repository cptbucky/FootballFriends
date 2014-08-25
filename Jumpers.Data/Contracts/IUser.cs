namespace Jumpers.Data.Contracts
{
    public interface IUser
    {
        int? Id { get; }

        string Email { get; set; }
    }
}