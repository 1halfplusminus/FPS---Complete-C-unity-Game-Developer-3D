
using System;
using UnityAtoms.BaseAtoms;

[Serializable]
public struct HealthCreated : IEquatable<int>, IEquatable<HealthCreated>
{
    public int ID;
    public IntVariable Health;

    public bool Equals(int other)
    {
        return other == ID;
    }

    public bool Equals(HealthCreated other)
    {
        return Equals(other.ID);
    }
}