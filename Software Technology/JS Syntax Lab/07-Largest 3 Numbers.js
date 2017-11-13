function largest(arr) {
    let numArr=arr.map(Number);
    numArr.sort(function(a, b){return b-a});
    let count=Math.min(3,numArr.length);
    for(let i=0;i<count;i++){
        console.log(numArr[i]);
    }
}

largest(['10', '30', '15', '20', '50', '5']);