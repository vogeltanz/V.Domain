using System;
namespace V.Domain.Base.Entities.Abstraction
{
	public interface IEntityDateTime
	{
		DateTime Created { get; set; }
		DateTime Modified { get; set; }
	}
}

