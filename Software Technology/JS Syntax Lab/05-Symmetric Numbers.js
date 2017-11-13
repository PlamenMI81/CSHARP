function symetricNum(arr) {
    let num=Number(arr[0]);
    let result="";
    function isPalindrom(num) {
        for(let i=0; i<num.length/2;i++){
            if(num[i]!=num[num.length-1-i]){
                return false;
            }
        }
        return true;
    }

    for(let i=1; i<=num;i++){
        if(isPalindrom(i.toString())){
            result+=i+" ";
        }
    }
    console.log(result);

}
symetricNum(['2000'])