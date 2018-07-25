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
    // var returnArg = [];
    // var isTrue = argTwo.length > argOne.length;
    // weaveLength = argOne.length + argTwo.length;
    // switch(isTrue)
    // {
    //     case true:
    //     for( i = 0 ; i < weaveLength ; i+2){
    //         if(argTwo[i-1]!= undefined || argTwo[i+1]!= undefined){
    //             returnArg[i] = argOne[i]; 
    //             returnArg[i+1] = argTwo[i-1];
    //         }
    //     }
    //     break;
    //     case false:
    //         for( i = 0 ; i < weaveLength ; i++){
    //             if(argOne[i-1]!= undefined || argOne[i+1]!= undefined){
    //                 returnArg[i] = argOne[i]; 
    //                 returnArg[i+1] = argTwo[i-1];
    //             }
    //         }

    //     break;
    // }
    // return returnArg;
}