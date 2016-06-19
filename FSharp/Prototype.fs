module Prototype

type Component = 
    | Type1Component
    | Type2Component

let getType = 
    function 
    | Type1Component -> 1
    | Type2Component -> 2

let getCategory = 
    function 
    | Type1Component -> "Category 1"
    | Type2Component -> "Category 2"

let printInformation createComponent = 
    let componentInst = createComponent()
    printfn "%d" (getType componentInst)
    printfn "%s" (getCategory componentInst)

do printInformation (fun () -> Type1Component)
