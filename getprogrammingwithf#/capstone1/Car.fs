module Car

open System

//TODO: Create helper functions to provide the building blocks to implement driveTo.
/// Gets the distance to a given destination
let getDistance destination =
    if destination = "Gas" then 10
    elif destination = "Home" then 25
    elif destination = "Office" then 50
    elif destination = "Stadium" then 25
    else failwith "Unknown destination!"


let calculateRemainingPetrol currentPetrol distance =
    let remaingPetrol = currentPetrol - distance

    if remaingPetrol > 0 then
        remaingPetrol
    else
        failwith "Oops! you run out of petrol!"

// Drives to a given destination given a starting amount of petrol
let driveTo petrol destination =
    let distanceToDestination = getDistance destination
    let remainingPetrol = calculateRemainingPetrol petrol distanceToDestination

    if destination = "Gas" then
        remainingPetrol + 50
    else
        remainingPetrol
