namespace Dependency_Inversion_Principle.Models
{
    public interface IInfo
    {
        public Task<IEnumerable<JsonData>> GetInfoAsync();
    }
}
