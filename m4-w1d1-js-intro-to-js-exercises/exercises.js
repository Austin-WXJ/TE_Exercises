function sumDouble(x, y){
    if (x===y){
        return 2*(x+y);
    }
    else{
        return x+y;
    }
}

function hasTeen(x, y, z){
    if((x || y || z) >= 13 || (x || y || z)<= 19 ){
        return true;
    }
    else{
        return false;
    }
}