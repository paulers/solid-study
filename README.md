# SOLID Programming Principles

1. Single Responsibility Principle
Classes should not have methods or properties unrelated to the class' purpose.

2. Open / Closed Principle
Once classes are written and tested, they should not be modified except to fix bugs. Instead, they should be extended.

3. Liskov Substitution Principle
Classes which inherit from a base class should be able to substitute the base class and behave the same way.

4. Interface Segregation Principle
Classes should not implement interfaces which contain elements those classes won't use. Basically, create small interfaces.

5. Dependency Inversion Principle
Top-level classes should not depend on lower-level classes. Both should depend on abstractions (commonly, interfaces).
Abstractions should not depend on details, but details should depend on abstractions.
This principle is basically layering of code. Lower level classes deal with details, while higher level classes deal with architecture. Dependency inversion can often be achieved with Dependency Injection.
