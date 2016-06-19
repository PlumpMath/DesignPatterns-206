module Builder

type Item = {mutable FirstPart : string; mutable SecondPart : string} 
    with member this.ShowParts() = sprintf "%s, %s." this.FirstPart this.SecondPart

type ItemBuilder =
    abstract member BuildFirstPart : unit->unit
    abstract member BuildSecondPart : unit->unit
    abstract member GetItem : unit -> Item
    abstract member item : Item

let yellowItemBuilder =  { new ItemBuilder with
      member this.item = {FirstPart = ""; SecondPart = ""}
      member this.BuildFirstPart() = this.item.FirstPart <- "YellowFirstPart"
      member this.BuildSecondPart() = this.item.FirstPart <- "YellowSecondPart"  
      member this.GetItem() = this.item }

let construct(builder:ItemBuilder) =
    builder.BuildFirstPart()
    builder.BuildSecondPart()
    builder.GetItem()

let run = 
    let item = construct yellowItemBuilder
    item.ShowParts()