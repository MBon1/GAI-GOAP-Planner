using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class WorldState
{
    public string key;
    public int value;
}

public class WorldStates
{
    public Dictionary<string, int> states;

    public WorldStates()
    {
        states = new Dictionary<string, int> ();
    }

    public bool HasState(string key)
    {
        return states.ContainsKey(key);
    }

    void AddState(string key, int val)
    {
        states.Add(key, val);
    }

    public void ModifyState(string key, int val)
    {
        if (HasState(key))
        {
            states[key] += val;
            if (states[key] <= 0)
            {
                RemoveStates(key);
            }
        }
        else
        {
            AddState(key, val);
        }
    }

    public void RemoveStates(string key)
    {
        if (HasState(key))
        {
            states.Remove(key);
        }
    }

    public void SetState(string key, int val)
    {
        if (HasState(key))
        {
            states[key] = val;
        }
        else
        {
            AddState(key, val);
        }
    }

    public Dictionary<string, int> GetStates()
    {
        return states;
    }
}
