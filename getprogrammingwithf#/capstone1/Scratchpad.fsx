open System

/// Gets the distance to a given destination 
let getDistance destination =
    if destination = "Gas" then 10
    elif destination = "Home" then 25
    elif destination = "Office" then 50
    elif destination = "Stadium" then 25
    else failwith "Unknown destination!"

// Couple of quick tests
getDistance "Home" = 25
getDistance "Stadium" = 25
getDistance "Gas" = 10
getDistance "Office" = 50
//getDistance "bobos" = 12

let calculateRemainingPetrol currentPetrol distance = 
    let remaingPetrol = currentPetrol - distance
    if remaingPetrol > 0 then remaingPetrol
    else failwith "Oops! you run out of petrol!"

calculateRemainingPetrol 50 20 = 30
//calculateRemainingPetrol 20 50 = 100

let distanceToGas = getDistance "Gas"
calculateRemainingPetrol 25 distanceToGas
//calculateRemainingPetrol 5 distanceToGas

let driveTo petrol destination = 
    let distanceToDestination = getDistance destination
    let remainingPetrol = calculateRemainingPetrol petrol distanceToDestination
    if destination = "Gas" then remainingPetrol + 50
    else remainingPetrol

let a = driveTo 100 "Office"
let b = driveTo a "Stadium"
let c = driveTo b "Gas"
let answer = driveTo c "Home"

