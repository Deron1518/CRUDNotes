using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// Namespaces are default when creating Class files. With .Net6, VSCode assumes the namespace and it should be removed.
// namespace PopsSodaPop.Data.POCOs
// { 
public class Vendor
{
    public Vendor(){}
    public Vendor(string name)
    {
        Name = name;
    }
    public int ID { get; set; }
    public string Name { get; set; }
}
// }