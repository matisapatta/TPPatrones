using System;

namespace TPPatrones {
    
    class Program {
        
        static void Main() {
            
            // Create ConcreteComponent and two Decorators

            Mati componente = new Mati();
            DecoratorIng componenteIng = new DecoratorIng();
            DecoratorGerente componenteGerente = new DecoratorGerente();


            // Link decorators prueba

            //componenteIng.SetComponent(componente);
            componenteGerente.SetComponent(componenteIng);

            componente.Operation();
            componenteIng.Operation();
            componenteGerente.Operation();

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

    class DecoratorIng : Decorator {
        
        public override void Operation() {
            base.Operation();
            Console.WriteLine("Ahora soy ingeniero!");
        }
    }

    /// The 'ConcreteDecoratorB' class

    class DecoratorGerente : Decorator {
        
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
