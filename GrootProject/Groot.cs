using System;
using System.Collections;


namespace Groot;

//TODO 
// 1. DeleteNode() - option to lock node from deletion if it hes NodeValues
// 2. MoveNode()
// 3. IsLeaf()
// 4. CountNodes()
// 5. options to plug-in data source  : JSON or DB option 
// 6. name automation according parents last digit
// 7. create PrintTree() method after GetTree() method
// DONE - 8. AddValueToNode() create method to add value directly from tree
// DONE - 9. GetValueOf() create method to get value directly from tree by value index.
// 10. options to export(): XLSX, CSV, XML, JSON or DB option 






public class Groot : IComparable
{
    private int _parentId;
    private int _id;
    private int _leftKey;
    private int _rightKey;
    private int _level;
    private string _name;
    private NodeValues _nodeValues= new NodeValues();
    

    public int GetParentId() => _parentId;
    public int GetId() => _id;
    public int GetLevel() => _level;
    public string GetName() => _name;
    public void SetName(string name) => _name = name;
    public int GetLeft_Key() => _leftKey;
    private void setLeft_Key(int key) => _leftKey = key;
    public int GetRight_Key() => _rightKey;
    private void setRight_Key(int key) => _rightKey = key;
    public NodeValues GetNodeValues() => _nodeValues;
   


    private Groot(int parentId, int id, int leftKey, int rightKey, int level, string name)
    {
        _parentId = parentId;
        _id = id;
        _leftKey = leftKey;
        _rightKey = rightKey;
        _level = level;
        _name = name;
    }

    
    private Groot(int parentId, string name)
    {
        _parentId = parentId;
        _name = name;
    }

   


    public int CompareTo(object? incomingobject) 
    { 
        Groot incomingNode = incomingobject as Groot ?? throw new InvalidOperationException(); 
        return this._leftKey.CompareTo(incomingNode._leftKey); 
    } 
        
        /// ===================================== nested class Tree ==============================
        public class Tree 
        {
                private readonly ArrayList _tree = [new Groot(0, 1, 1, 2, 0, "root")];  
                
                public  ArrayList GetTree()
                {
                    return _tree;
                }
            
                public void AddNode(int parentId, string newNodeName)
                {
                    
                    if ((parentId > _tree.Count) || (parentId  <= 0)){
                        Console.WriteLine($":: -> {parentId } is out of possible range");
                        return;
                    }
                    
                    var lefthKey = 0;
                    var rightKey = 0;
                    var level = 0;
                    var parentRightKey = 0;
                    var parentLefthKey = 0;
                    
                   foreach (Groot? node_i in _tree.ToArray())
                    {
                        if (node_i != null && parentId == node_i.GetId())
                        {
                            parentRightKey = node_i.GetRight_Key();
                            parentLefthKey = node_i.GetLeft_Key();
                            lefthKey = node_i.GetRight_Key();
                            rightKey = lefthKey + 1;
                            level = node_i.GetLevel() + 1;
                            node_i.setRight_Key(node_i.GetRight_Key() + 2);
                            
                        }
                    }
                   
                    foreach (Groot? node_j in _tree.ToArray())
                    {
                        if (node_j != null && node_j.GetLeft_Key() > parentRightKey)
                        {
                            node_j.setRight_Key(node_j.GetRight_Key() + 2);
                            node_j.setLeft_Key(node_j.GetLeft_Key() + 2);
                        }
                        
                        if (node_j != null && node_j.GetRight_Key() > parentRightKey && node_j.GetLeft_Key() < parentLefthKey)
                        {
                            node_j.setRight_Key(node_j.GetRight_Key() + 2);
                        }
                    }
                   
                    _tree.Add (new Groot(parentId, _tree.Count + 1, lefthKey, rightKey, level, newNodeName));
                    
                   
                   _tree.Sort();
                        
                   }

                public void AddValueToNode(string nodeName, int valueIndex, int value)
                {
                    
                    foreach (Groot node in _tree)
                    {
                        if (node.GetName() == nodeName)
                        {
                            node.GetNodeValues().GetValues().Add(value);
                            //Console.WriteLine(value);
                        }
                        
                    }

                }
                
                
                
                
                public object GetValueOfNode(string nodeName, int valueIndex)
                {
                    object? value = 0;
                    foreach (Groot node in _tree)
                    {
                        if (node.GetName() == nodeName)
                        {
                            value = node.GetNodeValues().GetValues()[valueIndex];
                            //Console.WriteLine(value);
                        }
                        
                    }

                    return value!;
                }
                
            
                public string PrintAllValuesOfNode(string nodeName)
                {
                    string? value = "";
                    foreach (Groot node in _tree)
                    {
                        if (node.GetName() == nodeName)
                        {
                              var nodeValues = node.GetNodeValues()?.GetValues();
                              if (nodeValues != null)
                              {
                                  value = string.Join(", ", nodeValues.ToArray().Select(item => item.ToString()));
                              }
                              else
                              {
                                  value = "No values found for this node.";
                              }
                        break; 
                        }
                        
                    }

                    return value;
                }
               
                
                
                
                
                
                
                
        }


}

