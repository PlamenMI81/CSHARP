function result(arr) {
    let arrRes=[];
    for(let i=0; i<arr.length;i++){
        let comArgs=arr[i].split(' ');
        let command=comArgs[0];
        let index=Number(comArgs[1]);
        if(command=='add'){
            arrRes.push(index);
        }else if(command=='remove'){
            arrRes.splice(index,1);
        }
    }
    for (let element of arrRes) {
        console.log(element);
    }
}
result(['add 3','add 5','remove 1','add 2']);