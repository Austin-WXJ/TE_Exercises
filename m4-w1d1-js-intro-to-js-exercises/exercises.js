function sumDouble(x, y){
    if (x===y){
        return 2*(x+y);
    }
    else{
        return x+y;
    }
}

function hasTeen(x, y, z){

    var a = [x, y, z];

    for(i = 0; i < a.length; i++){
        output = false;
       if( a[i] >=13 && a[i]<= 19){
           output = true;
           break;
        }       
        
    }
    return output; 
}

function lastDigit(x, y){
    a = x.toString();
    b = y.toString();
    if(a[a.length - 1] === b[b.length - 1]){
        return true;
    }
    else{
        return false;
    }
}

function seeColor(str){
    
    if(str.indexOf("red")===0){
        return "red";
    }
    else if(str.indexOf("blue")===0){
        return "blue";
    }
    else{
        return "";
    }
}

function middleThree(str){

    return str.substring(Math.floor(str.length/2-1), Math.floor(str.length/2+2));
}

function frontAgain(str){
    ff = str.substring(0,2);
    rr = str.substring(str.length - 2, str.length)
    if(ff === rr){
        return true;
    }
    else{
        return false;
    }
}

function alarmClock(dayint, vacbool){
    alarm = "7:00";    

    switch(dayint){
        case 0: 
        day = "Sunday"; 
            break;
        case 1: 
        day = "Monday"; 
            break;
        case 2: 
        day = "Tuesday"; 
            break;
        case 3: 
        day = "Wednesday"; 
            break;
        case 4: 
        day = "Thursday"; 
            break;
        case 5: 
        day = "Friday"; 
            break;
        case 6: 
        day = "Saturday"; 
            break;


    }

    if (vacbool && ( dayint ===0 || dayint ===6)){
        alarm = "off";
    }
    else if(vacbool){
        alarm = "10:00";
    }
    return day + " " + alarm;
}

function makeMiddle(arg){
    if(arg.length ===2||( arg.length > 3 && (arg.length /2 )% 2 === 0)){
        midTwo = [Math.floor((arg.length)/2 ), Math.floor((arg.length)/2+1)];
        return midTwo;
    }
    else if(arg.length > 3 &&( arg.length/2) % 2 !==0){
        midTwo = [Math.floor((arg.length-1)/2 ), Math.floor((arg.length)/2)];
        return midTwo;
    }
    else{
        return [];
    }
}

function oddOnly(arg){
    var answer = [];
    n=0;
    for(i = 0; i<arg.length; i++){
        if ( arg[i] % 2 !== 0 ){
            answer[n] = arg[i];
            n++;
        }
    }
    return answer;
}

function weave(argOne, argTwo){
    var returnArg = [];

    var weaveLength = (argOne.length + argTwo.length);

        for( i = 0 ; i < weaveLength ; i++){

            if(argOne[i] != undefined){
                returnArg.push(argOne[i]);
            }
            if(argTwo[i] != undefined){
                returnArg.push(argTwo[i]);
            }
        }
        return returnArg;
    }

function cigarParty(num, isWeekEnd){
    if(isWeekEnd){
        return true;
    }
    else if(num > 40 && num< 60){
        return true;
    }
    else{ return false;}
}

function stringSplosion(input){

    var output = "";
    for(i= 0; i< input.length; i++){

        output+=input.substring(0, i+1);

    }
    return output;
}

function fizzBuzz(arg){
    if (arg %15 ===0){
        return "FizzBuzz";
    }
    else if(arg% 5 === 0){
        return "Buzz";
    }
    else if(arg % 3 === 0){
        return "Fizz";
    }
    else{
        return arg;
    }
}

function countValues(arg){
    var result = {};

    for (i = 0;i < arg.length; i++){
        key = arg[i];
        value = 1;

        if(result[key]!== undefined){
            value = result[key];
            value++;
            result[key] = value;
        }
        else{
            result[key] = value;
        }
    }
    return result;
}

function reverseArray(arg){
    return arg.reverse();
}