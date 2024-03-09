namespace practice_core.Services
{
	public class SingletonService : ISingletonGuidService
	{
		private readonly Guid _guid;
        public SingletonService()
        {
            _guid = Guid.NewGuid();
        }
        public string GetGuid()
		{
			return _guid.ToString();
		}
	}
}
