using System;

namespace TPPatrones {
    
    class Program {
        
        static void Main() {
            
            // Create ConcreteComponent and two Decorators

            Mati c = new Mati();
            ConcreteDecoratorA d1 = new ConcreteDecoratorA();
            ConcreteDecoratorB d2 = new ConcreteDecoratorB();

            // Link decorators

            d1.SetComponent(c);
            d2.SetComponent(d1);

            //c.Operation();
            //d1.Operation();
            d2.Operation();

            // Wait for user

            Console.ReadKey();
        }
    }

    /// The 'Component' abstract class

    abstract class Persona {
        public abstract void Operation();
    }

    /// The 'ConcreteComponent' class

    class Mati : Persona {
        
        public override void Operation() {
            Console.WriteLine("Me llamo Mati!");
        }
    }

    /// The 'Decorator' abstract class

    abstract class Decorator : Persona {
        
        protected Persona component;

        public void SetComponent(Persona component) {
            this.component = component;
        }

        public override void Operation() {
            if (component != null) {
                component.Operation();
            }
        }
    }

    /// The 'ConcreteDecoratorA' class

    class ConcreteDecoratorA : Decorator {
        
        public override void Operation() {
            base.Operation();
            Console.WriteLine("Ahora soy ingeniero!");
        }
    }

    /// The 'ConcreteDecoratorB' class

    class ConcreteDecoratorB : Decorator {
        
        public override void Operation() {
            base.Operation();
            Console.WriteLine("Ahora soy gerente!");
            DespedirGente();
        }

        void DespedirGente(){
            Console.WriteLine("Juan está despedido!");
        }
    }
}
