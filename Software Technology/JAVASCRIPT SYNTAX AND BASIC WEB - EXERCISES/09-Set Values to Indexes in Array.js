function result(arr) {
    let lines=Number(arr[0]);
    let resArr=[];
    for (let i = 1; i < arr.length; i++) {
        let currLine=arr[i].split(' - ');
        let index=Number(currLine[0]);
        let value=currLine[1];
        resArr.splice(index,1,value);
    }
    for (let i=0;i<lines;i++) {
        let value=resArr[i];
        if(typeof value == 'undefined'){
            value=0;
        }
        console.log(value);
    }

}
result(['5','0 - 3','3 - -1','4 - 2']);