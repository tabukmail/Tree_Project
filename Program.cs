using ConsoleApp1.NStree;

namespace ConsoleApp1;

class Program
{
    static void Main()
    {   
        
       // Tree tree = new Tree();
        
    
       // tree.AddNode(1, "1-1");
       // tree.AddNode(1, "1-2");
       // tree.AddNode(1, "1-3");
       // tree.AddNode(3, "1-2-1");
       // tree.AddNode(3, "1-2-2");
       // tree.AddNode(3, "1-2-3");
       // tree.AddNode(4, "1-3-1");
       // tree.AddNode(7, "1-2-3-1");



       ///////find index by ID
       // int cntr = 0;
       // foreach (Node element in tree.GetTree())
       // {
       //     if (element.GetId() == 4)
       //     {
       //         break;
       //     }
       //     cntr++;
       // }
       // Console.WriteLine($"cntr --- {cntr}");


       // //retrieve value by index
       // var nodara = (Node)tree.GetTree().ToArray()[7]!;
       // nodara.GetNodeValues().SetValues(0,142);
       // Console.WriteLine($"value of nodara : --- {nodara.GetNodeValues().GetValues()[0]} ---{nodara.GetParentId()}");

       

       
       // foreach (Node element in tree.GetTree())
       // {
       //     if (element.GetId() == 6 )
       //     {
       //         element.GetNodeValues().SetValues(0, 68);
       //     }
       //     Console.WriteLine($"{element.GetParentId()}, {element.GetId()}, {element.GetLeft_Key()}, {element.GetRight_Key()}, {element.GetLevel()}, {element.GetName()}, == >>  {element.GetNodeValues().GetValues()[0]}");
       // }

       //=============================== test
       
       
       Node2.Tree2 tree2 = new Node2.Tree2();
       tree2.AddNode(1, "1-1");
       tree2.AddNode(1, "1-2");
       tree2.AddNode(1, "1-3");
       tree2.AddNode(3, "1-2-1");
       tree2.AddNode(3, "1-2-2");
       tree2.AddNode(3, "1-2-3");
       tree2.AddNode(4, "1-3-1");
       tree2.AddNode(7, "1-2-3-1");
       
       
       foreach (Node2 element in tree2.GetTree())
       {
           if (element.GetId() == 6 )
           {
               element.GetNodeValues().SetValues(0, 68);
               int nodeval = element.GetNodeValues().GetValues()[0];
               Console.WriteLine($" nod val {nodeval}");
           }
           Console.WriteLine($"{element.GetParentId()}, {element.GetId()}, {element.GetLeft_Key()}, {element.GetRight_Key()}, {element.GetLevel()}, {element.GetName()}, == >>  {element.GetNodeValues().GetValues()[0]}");
       }

       var nodara = (Node2)tree2.GetTree()[7]!;
            

    }
}