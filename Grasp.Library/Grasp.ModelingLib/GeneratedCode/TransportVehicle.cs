﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool
//     Changes to this file will be lost if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System;

public abstract class TransportVehicle : ITransportable, IChoosable
{
	public virtual int Year { get; set; }

    public virtual string ModelName { get; set; }

    public virtual string BrandName { get; set; }

    public virtual ETransportationType TypeOfTransportation { get; set;}

    public virtual string Buy() {
        return "You chosee " + Enum.GetName(typeof(ETransportationType), TypeOfTransportation);
    }

}

