# Design Patterns

just me, remembering clever stuff

## Table of Contents
* [10 Coding Commandments](#10-coding-commandments)
* [Naming things and Cache invalidation](#naming-things-and-cache-invalidation)
* [Sources of Spaghetti Code](#sources-of-spaghetti-code)
* [Guideline of Demeter](#guideline-of-demeter)
  
## 10 Coding Commandments
1. Thy shall read like English (a.k.a without comments)
2. Thous shalt take time to name things well.
3. Thy classes (and functions) shall **do one thing** and only!
4. Thou shalt use as little state as possible.
5. Thou shalt not refactor before the 3rd repetition.
6. Thou shalt not use **Static** and **Global State**.
7. Thy classes shall be **Highly Cohesive**.
8. Thy classes shall be **Loosely Coupled**.
9. Thou shalt use **Composition** over **Inheritance**.
10. Thou shalt follow the **Law of Demeter**.

## Naming things and Cache invalidation
#### Common signs of caching:
- boolean flags
- GetComponent stored in Awake
- updating variables on callbacks

#### Naming
- measure of code quality = WTFs/Minute
- **bad:** int t; // seconds since smth
- classes should be **nouns**
- **avoid:** Manager, Controller, Processor, etc.
- methods should be **verbs**
- talk to somebody else!

## Sources of Spaghetti Code
- Static and Global State -
  * bugs, 
  * poor unit testability, 
  * code comprehension, 
  * multithreading, 
  * aaand you might need 2 of those classes

- Low Cohesion / Tight Coupling
<img src="https://user-images.githubusercontent.com/59497202/189487761-fa079f06-f682-48e8-8bcb-2fc4e111a005.png" width="400px">

## Guideline of Demeter
`enemy.GetCurrentTarget().GetHealthComponent().DoDamage()`
chains like that are *bad* since we depend on *more* classes to get things done
