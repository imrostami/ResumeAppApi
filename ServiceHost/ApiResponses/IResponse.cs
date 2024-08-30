namespace ServiceHost.Responses
{
	public interface IResponse
	{
        public bool Ok { get; }
        public string Message { get; }
    }

    public interface IResponse<TModel>
    {
        public bool Ok { get; }
        public TModel Result { get; }
        public string Message { get;  }

    }
}
