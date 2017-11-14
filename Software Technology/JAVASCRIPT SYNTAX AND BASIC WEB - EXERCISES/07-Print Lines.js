function result(arr) {
    for (let obj of arr) {
        if(obj==='Stop'){
            return;
        }
        console.log(obj);
    }
}
result(['3','6','5','4','Stop','10','12']);