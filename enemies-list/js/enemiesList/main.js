// Put your code here

const enemies = [
    {
        FirstName: "Joshua",
        LastName: "Flowers",
        IsReallyHated: "true",
        Offenses: ["Being a jerk to me in elementary school", "Not being nice to me in elementary school"]
    },
    {
        FirstName: "Betty",
        LastName: "Rudelady",
        IsReallyHated: "true",
        Offenses: ["Phone calls in the theater", "Phone calls on the bus", "Phone calls in line at the grocery store", "Poor conversationalist"]
    },
    {
        FirstName: "Leon",
        LastName: "Peck",
        IsReallyHated: "false",
        Offenses: ["Keeps giving me a hotplate"]
    }

];

console.log("My Enemies List");

for (const myEnemies of enemies) {
    console.log(myEnemies.FirstName, "is horrible person", myEnemies.Offenses);
}

for (const theworst of enemies) {
    if (theworst.IsReallyHated) {
        console.log(`${theworst.FirstName}${theworst.LastName} Really really dislike}`)
    }
    else {
        console.log(`${theworst.FirstName} ${theworst.LastName}`)
    }
}