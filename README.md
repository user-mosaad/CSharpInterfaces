# C# Interfaces

Interfaces define a contract: a group of related methods, properties, events and indexers that a class or struct must implement.

Features of interfaces:
- Interfaces can inherit from other interfaces.
- Interfaces can have a default method body. Implementing types can override it.
- If you need methods not to appear in the implementing types' API, you can use explicit implementation, which looks like: <code>IInterface.Method() => Console.WriteLine("Something");</code>.

## Declare an Interface
Use the <code>interface</code> keyword. By convention, interface names begin with a capital I.

Interfaces can contain methods, properties, events and indexers.

## Inherit an Interface
The class or struct must implement all members of the interface it's implementing.

## Interfaces Vs. Abstract Classes
Both interfaces and abstract classes define contracts that derived types must fulfill.

The use cases for both are a little bit confusing right now, so I'll skip them for now.
