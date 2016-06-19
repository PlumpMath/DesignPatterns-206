module Singleton

type Singleton private() =
    static let mutable instance = lazy(Singleton())
    static member Instance with get() = instance