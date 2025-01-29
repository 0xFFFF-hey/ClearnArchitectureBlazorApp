## Chapter 12: Components
### 1. What Are Components?
  - Components are the smallest units of deployment in a software system.
  - They are typically represented as files (e.g., .jar, .dll, .gem) that can be independently deployed and linked together.
  - Components are the building blocks of a system’s architecture.
### 2. The Role of Components
  - Components allow for separation of concerns and modularity.
  - They enable teams to work on different parts of the system independently.
  - Components facilitate reusability and maintainability.
### 3. Component Principles
The chapter introduces three key principles for organizing components:
  - Reuse/Release Equivalence Principle (REP):
    * "The granule of reuse is the granule of release."
    * Components must be versioned and released as a unit.
    * Users of a component should depend on a specific version, ensuring stability and compatibility.
  - Common Closure Principle (CCP):
    * "Gather into components those classes that change for the same reasons and at the same times."
    * Similar to the Single Responsibility Principle (SRP) but at the component level.
    * Reduces the impact of changes by localizing them to specific components.
  - Common Reuse Principle (CRP):
    * "Don’t force users of a component to depend on things they don’t need."
    * Avoids unnecessary dependencies by ensuring that components contain only related classes.
    * Promotes high cohesion within components.
### 4. Tension Between Principles
- REP, CCP, and CRP often conflict with each other:
  * REP and CCP encourage larger components for reuse and maintainability.
  * CRP encourages smaller components to avoid unnecessary dependencies.

- The balance between these principles depends on the stage of the project:
  * Early stages: Focus on CCP to minimize the impact of changes.
  * Later stages: Shift toward REP and CRP to improve reusability and reduce coupling.
