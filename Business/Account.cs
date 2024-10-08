using Data;
using Microsoft.Extensions.Configuration;

namespace Business
{
	public class Account : Base, IAccount
	{
		public Account(IConfiguration configuration, IData data)
			: base(configuration, data)
		{
		}
	}
}