﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype_Design_Pattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ConcretePrototype1 p1 = new ConcretePrototype1("I");
            ConcretePrototype1 c1 = (ConcretePrototype1)p1.Clone();
            Console.WriteLine("Cloned: {0}", c1.Id);
            ConcretePrototype2 p2 = new ConcretePrototype2("II");
            ConcretePrototype2 c2 = (ConcretePrototype2)p2.Clone();
            Console.WriteLine("Cloned: {0}", c2.Id);
            // Wait for user
            Console.ReadKey();
        }
    }
    public abstract class Prototype
    {
        string id;
        // Constructor
        public Prototype(string id)
        {
            this.id = id;
        }
        // Gets id
        public string Id
        {
            get { return id; }
        }
        public abstract Prototype Clone();
    }
    /// <summary>
    /// A 'ConcretePrototype' class 
    /// </summary>
    public class ConcretePrototype1 : Prototype
    {
        // Constructor
        public ConcretePrototype1(string id)
            : base(id)
        {
        }
        // Returns a shallow copy
        public override Prototype Clone()
        {
            return (Prototype)this.MemberwiseClone();
        }
    }
    /// <summary>
    /// A 'ConcretePrototype' class 
    /// </summary>
    public class ConcretePrototype2 : Prototype
    {
        // Constructor
        public ConcretePrototype2(string id)
            : base(id)
        {
        }
        // Returns a shallow copy
        public override Prototype Clone()
        {
            return (Prototype)this.MemberwiseClone();
        }
    }
}
