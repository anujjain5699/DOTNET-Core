namespace practice_core.Services
{
	public class TransientService : ITransientGuidService
	{
		private readonly Guid _guid;
        public TransientService()
        {
            _guid = Guid.NewGuid();	
        }
        public string GetGuid()
		{
			return _guid.ToString();
		}
	}
}
