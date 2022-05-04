//------------------------------------------------------------------------------
//        This code was generated by myriad.
//        Changes to this file will be lost when the code is regenerated.
//------------------------------------------------------------------------------
namespace rec TestLens

module Test1Lenses =
    open Input

    let one =
        (fun (x: Test1) -> x.one), (fun (x: Test1) (value: int) -> { x with one = value })

    let two =
        (fun (x: Test1) -> x.two), (fun (x: Test1) (value: string) -> { x with two = value })

    let three =
        (fun (x: Test1) -> x.three), (fun (x: Test1) (value: float) -> { x with three = value })

    let four =
        (fun (x: Test1) -> x.four), (fun (x: Test1) (value: float32) -> { x with four = value })
namespace rec TestLens

module RecordWithWrappedLensLenses =
    open Input

    let one =
        Example.Lens(
            (fun (x: RecordWithWrappedLens) -> x.one),
            (fun (x: RecordWithWrappedLens) (value: int) -> { x with one = value })
        )
namespace rec TestLens

module RecordWithEmptyWrapperNameLenses =
    open Input

    let one_empty_wrapper_name =
        (fun (x: RecordWithEmptyWrapperName) -> x.one_empty_wrapper_name),
        (fun (x: RecordWithEmptyWrapperName) (value: int) -> { x with one_empty_wrapper_name = value })
namespace rec TestLens

module RecordWithWrappedLensViaTypedefofLenses =
    open Input

    let one_typedefof =
        Example.Lens(
            (fun (x: RecordWithWrappedLensViaTypedefof) -> x.one_typedefof),
            (fun (x: RecordWithWrappedLensViaTypedefof) (value: Option<int>) -> { x with one_typedefof = value })
        )
namespace rec TestLens

module RecordWithWrappedLensViaTypeofLenses =
    open Input

    let one_typeof =
        Example.Lens(
            (fun (x: RecordWithWrappedLensViaTypeof) -> x.one_typeof),
            (fun (x: RecordWithWrappedLensViaTypeof) (value: Option<int>) -> { x with one_typeof = value })
        )
namespace rec TestLens

module AddressLenses =
    open Input

    let Street =
        Example.Lens((fun (x: Address) -> x.Street), (fun (x: Address) (value: string) -> { x with Street = value }))

    let HouseNumber =
        Example.Lens(
            (fun (x: Address) -> x.HouseNumber),
            (fun (x: Address) (value: int) -> { x with HouseNumber = value })
        )
namespace rec TestLens

module PersonLenses =
    open Input

    let Name =
        Example.Lens((fun (x: Person) -> x.Name), (fun (x: Person) (value: string) -> { x with Name = value }))

    let Address =
        Example.Lens((fun (x: Person) -> x.Address), (fun (x: Person) (value: Address) -> { x with Address = value }))
namespace rec AetherTestLens

module AetherAddressLenses =
    open Input

    let Street =
        (fun (x: AetherAddress) -> x.Street), (fun (value: string) (x: AetherAddress) -> { x with Street = value })

    let HouseNumber =
        (fun (x: AetherAddress) -> x.HouseNumber),
        (fun (value: int) (x: AetherAddress) -> { x with HouseNumber = value })
namespace rec AetherTestLens

module AetherPersonLenses =
    open Input

    let Name =
        (fun (x: AetherPerson) -> x.Name), (fun (value: string) (x: AetherPerson) -> { x with Name = value })

    let Address =
        (fun (x: AetherPerson) -> x.Address),
        (fun (value: AetherAddress) (x: AetherPerson) -> { x with Address = value })
namespace rec TestLens

module SingleCaseDULenses =
    open Input

    let Lens' =
        let getter (x: SingleCaseDU) =
            match x with
            | Single x -> x

        getter, (fun (_: SingleCaseDU) (value: int) -> Single value)
namespace rec TestLens

module WrappedSingleCaseDULenses =
    open Input

    let Lens' =
        Example.Lens(
            let getter (x: WrappedSingleCaseDU) =
                match x with
                | SingleWrapped x -> x

            getter, (fun (_: WrappedSingleCaseDU) (value: int) -> SingleWrapped value)
        )
namespace rec TestLens

module FullyQualifiedDULenses =
    open Input

    let Lens' =
        let getter (x: FullyQualifiedDU) =
            match x with
            | FullyQualifiedDU.FullyQualified x -> x

        getter, (fun (_: FullyQualifiedDU) (value: string) -> FullyQualifiedDU.FullyQualified value)
namespace rec TestLens

module Module_SingleCaseDULenses =
    open Input.ModuleWithDUs

    let Lens' =
        let getter (x: Module_SingleCaseDU) =
            match x with
            | Single x -> x

        getter, (fun (_: Module_SingleCaseDU) (value: int) -> Single value)
namespace rec TestLens

module Module_WrappedSingleCaseDULenses =
    open Input.ModuleWithDUs

    let Lens' =
        Example.Lens(
            let getter (x: Module_WrappedSingleCaseDU) =
                match x with
                | SingleWrapped x -> x

            getter, (fun (_: Module_WrappedSingleCaseDU) (value: int) -> SingleWrapped value)
        )
namespace rec TestLens

module Module_FullyQualifiedDULenses =
    open Input.ModuleWithDUs

    let Lens' =
        let getter (x: Module_FullyQualifiedDU) =
            match x with
            | Module_FullyQualifiedDU.FullyQualifiedCase x -> x

        getter, (fun (_: Module_FullyQualifiedDU) (value: int) -> Module_FullyQualifiedDU.FullyQualifiedCase value)

namespace rec TestFields

module Test1 =
    open Input
    let one (x: Test1) = x.one
    let two (x: Test1) = x.two
    let three (x: Test1) = x.three
    let four (x: Test1) = x.four

    let create (one: int) (two: string) (three: float) (four: float32) : Test1 =
        { one = one
          two = two
          three = three
          four = four }

    let map
        (mapone: int -> int)
        (maptwo: string -> string)
        (mapthree: float -> float)
        (mapfour: float32 -> float32)
        (record': Test1)
        =
        { record' with
            one = mapone record'.one
            two = maptwo record'.two
            three = mapthree record'.three
            four = mapfour record'.four }

namespace rec TestDus

module Currency =
    open Input

    let toString (x: Currency) =
        match x with
        | CAD -> "CAD"
        | PLN -> "PLN"
        | EUR -> "EUR"
        | USD -> "USD"
        | Custom _ -> "Custom"

    let fromString (x: string) =
        match x with
        | "CAD" -> Some CAD
        | "PLN" -> Some PLN
        | "EUR" -> Some EUR
        | "USD" -> Some USD
        | _ -> None

    let toTag (x: Currency) =
        match x with
        | CAD -> 0
        | PLN -> 1
        | EUR -> 2
        | USD -> 3
        | Custom _ -> 4

    let isCAD (x: Currency) =
        match x with
        | CAD -> true
        | _ -> false

    let isPLN (x: Currency) =
        match x with
        | PLN -> true
        | _ -> false

    let isEUR (x: Currency) =
        match x with
        | EUR -> true
        | _ -> false

    let isUSD (x: Currency) =
        match x with
        | USD -> true
        | _ -> false

    let isCustom (x: Currency) =
        match x with
        | Custom _ -> true
        | _ -> false


