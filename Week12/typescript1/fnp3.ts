function callIt(someFunction){
    console.log('Got it! Ready to call it!');
    someFunction(); 
}

function sample1() {
    console.log('Hello World, I am sample!');
}

function sample2() {
    console.log('Leave me alone please!');
    console.log("I'm trying to code here!");
}

function sample3() {
    console.log('I like to add. 1 +1 = 2');
}

callIt(sample2); 
callIt(sample1);
callIt(sample3);

callIt(
    function(){
        console.log('I am an anonymous function!');
    }
);

// API's will work like this: 
//    CallSomeAPI('https://ww.example.com', sample1)

