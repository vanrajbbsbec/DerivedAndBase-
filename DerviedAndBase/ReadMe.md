Did you know?
You cannot create an object of a Base class with derived class reference, but the opposite is valid. Here is an example to understand:
Two classes with public constructor are considered name clsBase, clsDerived


class clsBase
    {
        public clsBase()
        {
            Console.WriteLine("Base\n");
        }
    }

    class clsDerived : clsBase
    {
        public clsDerived()
        {
            Console.WriteLine("Derived\n");
        }
 

In Main function declare two objects one of Derived class another of Base class.

 

Initiate the Derived class object with Base Class memory and Base class object with Derived class memory.

 

Try this and you will see that you cannot initialize the derived class object with Base class but the other is true. For the other case first the Base class Constructor will be called and then the Derived class constructor.

Try this code to understand more.
Source Code @ 
