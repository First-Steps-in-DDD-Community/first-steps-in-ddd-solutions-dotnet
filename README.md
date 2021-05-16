# First Steps in Domain-Driven Design - C# Solution
![Build](https://github.com/First-Steps-in-DDD-Community/first-steps-in-ddd-solutions-dotnet/workflows/Build/badge.svg)

This is the starter project for the exercises in the "First Steps in Domain-Driven Design" course for O'Reilly.  If you are more of a Java person, take a look at the [Java version of this codebase](https://github.com/First-Steps-in-DDD-Community/first-steps-in-ddd-solutions/blob/main/README.md).

You should be able to fork and then clone this repo to get an almost-empty .NET project ready to work with.

## Pre-requisites
* .NET Core SDK (at least .net standard 2.1)
* IDE of your choice
* Git client (unless you already have one in your IDE)

## What you get
A directory `first-steps-in-ddd` containing this README.md, a solution file with the code and test projects.
XUnit dependencies for testing, standard `src` with `JusticeApp` and `JusticeApp.Tests` directory structure, and some example unit tests
(`APoliceInvestigation.cs`, `APreChargeDecision.cs` and `ACriminalCase.cs`) and associated starter
classes (e.g. `PoliceInvestigation.cs`, `PNCId.cs`, `Suspect.cs`) and an Enum, `CriminalOffence.cs`.

## Up and running
The training relies entirely on your writing unit tests (ideally you use test-driven development)
so you want to be able to run them very quickly.

Open the newly checked out project in your IDE (probably point it at the solution file (.sln), or simply the
top-level project directory under `src`). Then check you can execute all the tests with the click of a single mouse
button, or ideally a single keyboard shortcut.

Additionally, it can be handy to check your build on the command line. Open a terminal and change to the
top-level project directory. Then run the command `dotnet test` (this command runs `dotnet build` first).
You ought to see your code and tests compile, and all but one of the tests run successfully.

The failing test is where we will start exercise one.

## Get ahead of the game
We're going to work on this code based on a [Domain Expert Statement from a Public Prosecutor](https://docs.google.com/document/d/1HpRJj1lk_M80Xvwzs5F-lZ1oACkVNeWRMG0s7BQxZzk/edit?usp=sharing).  If you want to read it in advance, that'll help you in the first workshop exercise and beyond.
