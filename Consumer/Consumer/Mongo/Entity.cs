﻿using MongoDB.Bson;

namespace Consumer.Mongo
{
    public abstract class EntityWithTypedId<TId>
    {
        public TId Id { get; set; }
    }

    public abstract class Entity : EntityWithTypedId<ObjectId>
    {

    }
}