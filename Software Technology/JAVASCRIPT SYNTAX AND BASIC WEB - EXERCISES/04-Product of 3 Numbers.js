function result(arr) {
    let arrNums=arr.map(Number);
    let count=0;
    for(let num of arrNums){
        if(num<0){
            count++;
        }else if(num===0){
            console.log('Positive');
            return;
        }
    }
    if(count%2===0){
        console.log('Positive');
    }else{
        console.log('Negative');
    }
}

result(['2','3','-1']);