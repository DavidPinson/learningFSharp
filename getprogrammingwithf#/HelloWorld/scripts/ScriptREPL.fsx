open System

let greeting = "Hello World"
let askForName = "What is your name?"

let greetPerson name age =
    sprintf "Hello, %s. You are %d years young" name age

let greeting2 = greetPerson "Fred" 25

let add first second = first + second

let result = add 2 3

let foo =
    let x = 10
    printfn "%d" (10 + 20)
    let x = "test"
    let x = 50
    x + 200

let getLength (name:string) = sprintf "Name is %d letters." name.Length
let foo2 (name) = "Hello! " + getLength name
foo2 "bob"

let sayHello someValue = 
    let innerFunction number = 
        if number > "Hello" then "Isaac"
        elif number > 20 then "Fred"
        else "Sara"
    let resultOfInner = 
        if someValue < 10.0 then innerFunction 5
        else innerFunction 15
    "Hello " + resultOfInner
let result2 = sayHello 10.5
