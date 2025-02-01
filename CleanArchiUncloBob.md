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
### 5. Practical Implications
- Use package managers for dependency management.
- Regularly refactor components to align with principles.

### 6. Key Takeaways
- Components are key to modularity and reusability.
- REP, CCP, and CRP guide effective component design.
- Balance principles based on project needs.

# Part V
## Chapter 22 : The Clean Architecture 
![image](https://github.com/user-attachments/assets/16155197-7725-4304-9ed4-5a45692f39d4)
### THE	DEPENDENCY RULE
 Source	code	dependencies	must	point	only	inward,	toward	higher-level	policies.
### ENTITIES
  - They	are	the	least	likely	to	change	when something	external	changes.
  - No	operational	change	to any	particular	application	should	affect	the	entity	layer.
###  USE	CASES
  - The	software	in	the	use	cases	layer	contains	application-specific	business	rules. It	encapsulates	and	implements	all	of	the	use	cases	of	the	system.
  - We	do	not	expect	changes	in	this	layer	to	affect	the	entities.	We	also	do	not expect	this	layer	to	be	affected	by	changes	to	externalities	such	as	the	database, the	UI,	or	any	of	the	common	frameworks.	The	use	cases	layer	is	isolated	from such	concerns
### INTERFACE	ADAPTERS
  - The	software	in	the	interface	adapters	layer	is	a	set	of	adapters	that	convert	data from	the	format	most	convenient	for	the	use	cases	and	entities,	to	the	format most	convenient	for	some	external	agency	such	as	the	database	or	the	web.
  - For	example,	that	will	wholly	contain	the	MVC	architecture	of	a	GUI
###  FRAMEWORKS	AND	DRIVERS
  -  Composed	of frameworks	and	tools	such	as	the	database	and	the	web	framework.
