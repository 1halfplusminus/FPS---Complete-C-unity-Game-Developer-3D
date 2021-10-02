

using System;
using UnityAtoms;

public interface IEntity
{
    public string Id { get; }

}
public class VariableEntity : AtomBaseVariable<IEntity>
{
    public VariableEntity(IEntity e) { _value = e; }
}
[Serializable]
public struct Entity : IEntity, IEquatable<Entity>
{
    public string Id;

    string IEntity.Id => Id;

    public bool Equals(IEntity other)
    {
        return other.Id == Id;
    }

    public bool Equals(Entity other)
    {
        return Equals(other);
    }
}