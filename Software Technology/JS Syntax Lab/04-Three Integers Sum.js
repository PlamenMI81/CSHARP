function threeIntSum(nums) {
    let numsAsNumbers=nums[0].split(' ').map(Number);
    let n1=numsAsNumbers[0];
    let n2=numsAsNumbers[1];
    let n3=numsAsNumbers[2];
    if(n1+n2==n3){
        console.log(`${Math.min(n1,n2)} + ${Math.max(n1,n2)} = ${n1+n2}`)
    }else if(n1+n3==n2){
        console.log(`${Math.min(n1,n3)} + ${Math.max(n1,n3)} = ${n1+n3}`)
    }else if(n2+n3==n1){
        console.log(`${Math.min(n2,n3)} + ${Math.max(n2,n3)} = ${n2+n3}`)
    }else{
        console.log('No')
    }

}

threeIntSum(['3 8 12']);