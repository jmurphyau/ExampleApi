# ExampleApi

An example

## For developers needing to use ExampleApi as a library in their own code

`dotnet add ExampleApi`

## For developers needing to use consume ExampleApi as a client [netcore]

`dotnet add ExampleApi.Client`

## For developers needing to use consume ExampleApi as a client [typescript]

`npm install @jmurphyau/example-api-client --save`

## GitHub Actions

When a new tag is pushed for this repo (`git tag v1.0.0; git push --tags`), GitHub actions do the following:

- compile, build and test this repo
- publish this repo to GitHub package repo
- generates the code for the netcore client
- pushes generated code to it's own repo [jmurphyau/ExampleApi.Client](https://github.com/jmurphyau/ExampleApi.Client) and tags the commit with the same tag
- generates the code for the typescript client
- pushes generated code to it's own repo [jmurphyau/example-api-client](https://github.com/jmurphyau/example-api-client) and tags the commit with the same tag

Each client repo has GitHub actions that automatically build and publish themselves.

# Related Repositories
* https://github.com/jmurphyau/ExampleApi.Client - Client for netcore
* https://github.com/jmurphyau/example-api-client - Client for TypeScript

# Related Packages
* NuGet: https://github.com/jmurphyau/ExampleApi/packages
* NuGet: https://github.com/jmurphyau/ExampleApi.Client/packages
* NPM: https://github.com/jmurphyau/example-api-client/packages
