using System;
using V.Domain.Base.Entities.Abstraction;

namespace V.Domain.Base.Entities
{
	public abstract class EntityAdvanced<TKey> : Entity<TKey>, IEntityDateTime
	{
		public DateTime Created { get; set; }
		public DateTime Modified { get; set; }
	}
}

