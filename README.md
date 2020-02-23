# Dependency-Injection

Demonstration of dependency injection using abstracts.

---

//Brendon Morgan - 07/31/2018

/*The purpose of this is to demonstrate the capabilities of Dependency Injection.

Animals were used as classes because they had enough in common to create an Abstract.

This process will work largely the same with an Interface, but an Abstract has more functionality for this purpose.

Theoretically the Birds, Cats, and Dogs projects can all have very different references. By referencing them through their Abstract instead of directly, the Project using them does not need to have references for the entire collective, and those references will instead be loaded only as needed.

An added benefit of this programming style is the ability to create new versions of these classes, and because a large majority of the program will actually be referencing them through their Abstract, it reduces the number of places your code must be changed to implement the new versions of the classes.*/
