using System.Collections.Generic;

namespace AltV.Net.EntitySync.Events
{
    /// <summary>
    /// This event is used to notify about a data update of a entity
    /// </summary>
    public readonly struct EntityDataChangeEvent
    {
        public readonly IEntity Entity;

        public readonly IEnumerable<object> Data;

        public EntityDataChangeEvent(IEntity entity, IEnumerable<object> data)
        {
            Entity = entity;
            Data = data;
        }
    }
}