## About This Repo

This repository is me going through and solving algorithms and data structures from the free [Frontend Masters](https://frontendmasters.com/) course from ThePrimeagen called "[The Last Algorithms Course You'll Need](https://frontendmasters.com/courses/algorithms/)"

This repository will attempt to code each one in different languages. Currently it is done in C# and TypeScript though more could be done. I view this as a great way to learn languages so it is possible I will use this as an example of different langauges. Each language as their own directory with a project setup to use.

### C# (.NET 6)

The C# directory/project is done using NET 6 and has a Visual Studio Solution with multiple projects.

* Algorithms Project - This is a Standard .NET class library where all the algorithms and data structures are placed.
* Benchmark - This is a console application that uses the Algorithms class library and attempts to use [BecnhmarkDotNet](https://github.com/dotnet/BenchmarkDotNet) to run some simple benchmarks on the algorithms. The idea was to see how some algorithms could be quicker than others, though I will admit I don't know how scientific this is right now.
*  Tests - This is a XUnit Text Project that tests the different algorithms in the Algorithms class library. The idea is just to show they work.

### TypeScript

This is the `js` directory and it uses a TypeScript and Node boilerpalte project to get everything ready. You just need to do preform a `npm install` in this directory to install all of the dependencies. This project currently uses jest for its testing and code coverage

To run the tests just run `npm run test` and this will automatically run all tests. Currently there isn't a way to filter down and run specific tests, though this is planned to be added.