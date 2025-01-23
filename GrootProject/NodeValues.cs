using System;
using System.Collections;
using System.Collections.Generic;

namespace Groot;

public class NodeValues
{
    //TODO 
    // 1. Agregate values according to the tree 
    // 2. Change List to ArrayList and make it possible to to choose type of value by index[] in a Tree Class constructor
    // 3. possibility to add NUMERICAL values to node_values if IsLeaf() is TRUE
    // 4. possibility to add STRING and CHAR values to node_values.
    // 5. split tree and agregate separately
    // 6. the print() method of the node values for the node 
    //xxx
    
    
    private ArrayList _values = new ArrayList (1){0};
    private Dictionary<string, ValueColumnType> _types = new Dictionary<string, ValueColumnType>(){};
    
    
    
    

    public  ArrayList GetValues()
    {
        return _values;
    }
    
    public void SetValueByIndex(int index, int value)
    {
        _values[index] = value;
    }
    
    public  Dictionary<string, ValueColumnType> GetTypes()
    {
        return _types;
    }
    
    public void SetValueType(string name, ValueColumnType type)
    {
        _types.Add(name, type);
    }
    
    public Dictionary<string,ValueColumnType> GetValueTypes()
    {
        return _types;
    }
    
    
    
    
}