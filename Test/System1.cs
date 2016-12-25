﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ECS;

namespace Test
{

public class System1 : System<Comp1>
{
    protected override void Update(Comp1 component)
    {
        Console.WriteLine("Updating Comp1 of " + component.EntityID);

        Console.WriteLine("System1 sends event. EntityID = " + component.EntityID);
        SendEvent(0, component.EntityID, null);
    }
}

}
