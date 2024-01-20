using System;
using V.Domain.Base.Entities.Abstraction;

namespace V.Domain.Base.Entities
{
	public abstract class EntityTimeInfo<TKey> : Entity<TKey>, IEntityCreated, IEntityModified
	{
		public DateTime Created { get; set; }
		public DateTime Modified { get; set; }
	}
}

