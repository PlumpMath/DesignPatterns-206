module Singleton

type Singleton private() =
    static let instance = lazy(Singleton())
    static member Instance with get() = instance