module AbstractFactory

type Component = 
    | Type1Component
    | Type2Component

type ComponentFactory = 
    { Component : Component }

let getComponent (componentFactory : ComponentFactory) = componentFactory.Component

let getType = 
    function 
    | Type1Component -> 1
    | Type2Component -> 2

let getCategory = 
    function 
    | Type1Component -> "Category 1"
    | Type2Component -> "Category 2"

let printInformation componentFactory = 
    let componentInst = getComponent componentFactory
    printfn "%d" (getType componentInst)
    printfn "%s" (getCategory componentInst)

do printInformation { Component = Type1Component }