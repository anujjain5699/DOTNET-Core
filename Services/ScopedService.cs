namespace practice_core.Services
{
	public class ScopedService : IScopedGuidService
	{
		private readonly Guid _guid;
        public ScopedService()
        {
            _guid = Guid.NewGuid();
        }
        public string GetGuid()
		{
			return _guid.ToString();
		}
	}
}
